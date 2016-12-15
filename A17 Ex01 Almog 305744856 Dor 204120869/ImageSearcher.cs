using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A17_Ex01_Logic;

namespace A17_Ex01_UI
{
    public partial class ImageSearcher : UserControl
    {
        readonly List<Photo> r_AllPhotosList = new List<Photo>();
        readonly List<User> r_TagsWith = new List<User>();
        readonly List<UserWithPhotos> r_PhotosByUserList = new List<UserWithPhotos>();
        readonly Dictionary<int, List<Photo>> r_PhotosByYearList = new Dictionary<int, List<Photo>>();
        readonly List<Photo> r_photosToReactOn = new List<Photo>();
        List<Photo> m_25photosList;
        List<Photo> m_photosCheckedByUser;
        Boolean b_FirstCheck;
        User m_LoggedInUser;

        public ImageSearcher(User i_LoggedUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedUser;
            fetchAlltaggedPictures();
        }

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            m_photosCheckedByUser = new List<Photo>();
            listViewPhotoDisplay.Clear();
            imageListFromUser.Dispose();
            filterPhotosByUserName();
            filterPhotosByYear();
            showPhotos(m_photosCheckedByUser);
        }

 

        private void fetchAlltaggedPictures()
        {
            PicturesColleciton picture = m_LoggedInUser.Pictures;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                addPhotos(album.Photos);
            }
            addPhotos(m_LoggedInUser.PhotosTaggedIn);

            m_25photosList = new List<Photo>();
            for (int i = 1; i < 25; i++)
            {
                m_25photosList.Add(r_AllPhotosList[i]);

            }

            showPhotos(m_25photosList);
        }


        private void showPhotos(List<Photo> i_Photolist)
        {
            r_photosToReactOn.Clear();
            foreach (Photo photo in i_Photolist)
            {
                imageListFromUser.Images.Add(photo.ImageNormal);
                r_photosToReactOn.Add(photo);
            }

            listViewPhotoDisplay.View = View.LargeIcon;
            listViewPhotoDisplay.LargeImageList = imageListFromUser;

            for (int j = 0; j < this.imageListFromUser.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewPhotoDisplay.Items.Add(item);
            }
        }


        private void addPhotos(FacebookObjectCollection<Photo> i_Photos)
        {
            string taggedUserName;
            int indexOfTaggedUser;
            int yearOfPhoto;

            foreach (Photo photo in i_Photos)
            {
                r_AllPhotosList.Add(photo);
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;

                // Create a list of years that has photos
                yearOfPhoto = photo.CreatedTime.GetValueOrDefault().Year;
                if (!r_PhotosByYearList.ContainsKey(yearOfPhoto))
                {
                    r_PhotosByYearList.Add(yearOfPhoto, new List<Photo>());
                    checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
                }

                // Create a list of users and the photos their tagged in
                if (photo.Tags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        taggedUserName = photoTag.User.Name;
                        indexOfTaggedUser = photosByUserListContains(taggedUserName);
                        if (indexOfTaggedUser != -1)
                        {
                            r_PhotosByUserList[indexOfTaggedUser].AddPhotoToUser(photo);
                        }
                        else
                        {
                            this.r_PhotosByUserList.Add(new UserWithPhotos(photoTag.User, photo));
                        }

                        // Add all tagged names to check box list
                        if (!checkBoxUserTaggedWith.Items.Contains(taggedUserName))
                        {
                            r_TagsWith.Add(photoTag.User);
                            checkBoxUserTaggedWith.Items.Add(taggedUserName);
                        }
                    }
                }
            }

            foreach (Photo photo in r_AllPhotosList)
            {
                // Create a list of photos by the year they were added
                r_PhotosByYearList[photo.CreatedTime.GetValueOrDefault().Year].Add(photo);
            }
        }

        private int photosByUserListContains(string i_NameOfUser)
        {
            int indexOfTaggedUser = 0;
            foreach (UserWithPhotos taggedUser in this.r_PhotosByUserList)
            {
                if (taggedUser.TaggedUser.Name.Equals(i_NameOfUser))
                    return indexOfTaggedUser;
                indexOfTaggedUser++;
            }

            return -1;
        }

        private void filterPhotosByYear()
        {
            foreach (int year in r_PhotosByYearList.Keys)
            {
                if (checkedListBoxYearOfPhoto.CheckedItems.Count > 1)
                {
                    m_photosCheckedByUser.Clear();
                }

                else if (checkedListBoxYearOfPhoto.CheckedItems.Contains(year))
                {
                    if (b_FirstCheck == true)
                    {
                        foreach (Photo photo in r_PhotosByYearList[year])
                        {
                            if (!m_photosCheckedByUser.Contains(photo))
                            {
                                m_photosCheckedByUser.Add(photo);
                            }
                        }
                        b_FirstCheck = false;
                    }

                    else
                    {
                        List<Photo> photosToDelete = new List<Photo>();
                        foreach (Photo photo in m_photosCheckedByUser)
                        {
                            if (photo.CreatedTime.GetValueOrDefault().Year != year)
                            {
                                photosToDelete.Add(photo);
                            }
                        }
                        foreach (Photo photo in photosToDelete)
                        {
                            m_photosCheckedByUser.Remove(photo);
                        }
                    }
                }
            }
        }

        private void filterPhotosByUserName()
        {
            b_FirstCheck = true;

            foreach (UserWithPhotos taggedUser in r_PhotosByUserList)
            {
                if (checkBoxUserTaggedWith.CheckedItems.Contains(taggedUser.TaggedUser.Name))
                {

                    if (b_FirstCheck == true)
                    {
                        foreach (Photo photo in taggedUser.PhotosOfUser)
                        {
                            if (!m_photosCheckedByUser.Contains(photo))
                            {
                                m_photosCheckedByUser.Add(photo);
                            }
                        }
                        b_FirstCheck = false;
                    }
                    else
                    {
                        List<Photo> newPhotoCheckedByUser = new List<Photo>();
                        foreach (Photo photo in m_photosCheckedByUser)
                        {
                            if (taggedUser.IsPhotoExist(photo) == true)
                            {
                                newPhotoCheckedByUser.Add(photo);
                            }
                        }
                        m_photosCheckedByUser = newPhotoCheckedByUser;
                    }
                }

            }
        }

        private void buttonOpenSelectedPhoto_Click(object sender, EventArgs e)
        {
            ImageReaction newImageReaction = new ImageReaction(r_photosToReactOn.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

    }
}
