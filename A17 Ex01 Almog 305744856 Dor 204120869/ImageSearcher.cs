using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A17_Ex01_UI
{
    public partial class ImageSearcher : UserControl
    {
        List<Photo> m_AllPhotosList = new List<Photo>();
        List<User> m_TagsWith = new List<User>();
        List<Photo> m_25photosList;
        List<Photo> m_photosCheckedByUser;
        List<A17_Ex01_Logic. UserWithPhotos> m_PhotosByUserList = new List<UserWithPhotos>();
        Dictionary<int, List<Photo>> m_PhotosByYearList = new Dictionary<int, List<Photo>>(); 
        List<Photo> m_photosToReactOn = new List<Photo>();
        Boolean b_FirstCheck = true;
        User m_LoggedInUser;
        AppSettings m_Settings;

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

            FilterPhotosByUserName();
            FilterPhotosByYear();

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
            for (int i = 1; i < 5; i++)
            {
                m_25photosList.Add(m_AllPhotosList[i]);

            }

            showPhotos(m_25photosList);
        }

        private void showPhotos(List<Photo> photolist)
        {
            m_photosToReactOn.Clear();
            foreach (Photo photo in photolist)
            {
                imageListFromUser.Images.Add(photo.ImageNormal);
                m_photosToReactOn.Add(photo);
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

        private void addPhotos(FacebookObjectCollection<Photo> photos)
        {
            string taggedUserName;
            int IndexOfTaggedUser;
            int yearOfPhoto;
            foreach (Photo photo in photos)
            {
                m_AllPhotosList.Add(photo);
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;

                // Create a list of years that has photos
                yearOfPhoto = photo.CreatedTime.GetValueOrDefault().Year;
                if (!m_PhotosByYearList.ContainsKey(yearOfPhoto))
                {
                    m_PhotosByYearList.Add(yearOfPhoto, new List<Photo>());
                    checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
                }

                // Create a list of users and the photos their tagged in
                if (photo.Tags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        taggedUserName = photoTag.User.Name;
                        IndexOfTaggedUser = PhotosByUserListContains(taggedUserName);
                        if (IndexOfTaggedUser != -1)
                        {
                            m_PhotosByUserList[IndexOfTaggedUser].AddPhotoToUser(photo);
                        }
                        else
                        {
                            this.m_PhotosByUserList.Add(new UserWithPhotos(photoTag.User, photo));
                        }

                        // Add all tagged names to check box list
                        if (!checkBoxUserTaggedWith.Items.Contains(taggedUserName))
                        {
                            m_TagsWith.Add(photoTag.User);
                            checkBoxUserTaggedWith.Items.Add(taggedUserName);
                        }
                    }
                }
            }

            foreach (Photo photo in m_AllPhotosList)
            {
                // Create a list of photos by the year they were added
                m_PhotosByYearList[photo.CreatedTime.GetValueOrDefault().Year].Add(photo);
            }
        }

        private int PhotosByUserListContains(string nameOfUser)
        {
            int indexOfTaggedUser = 0;
            foreach (UserWithPhotos taggedUser in this.m_PhotosByUserList)
            {
                if (taggedUser.m_TaggedUser.Name.Equals(nameOfUser))
                    return indexOfTaggedUser;
                indexOfTaggedUser++;
            }

            return -1;
        }

        private void FilterPhotosByYear()
        {
            foreach (int year in m_PhotosByYearList.Keys)
            {
                if (checkedListBoxYearOfPhoto.CheckedItems.Count > 1)
                {
                    m_photosCheckedByUser.Clear();
                }

                else if (checkedListBoxYearOfPhoto.CheckedItems.Contains(year))
                {
                    if (b_FirstCheck == true)
                    {
                        foreach (Photo photo in m_PhotosByYearList[year])
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

        private void FilterPhotosByUserName()
        {
            b_FirstCheck = true;

            foreach (UserWithPhotos taggedUser in m_PhotosByUserList)
            {
                if (checkBoxUserTaggedWith.CheckedItems.Contains(taggedUser.m_TaggedUser.Name))
                {

                    if (b_FirstCheck == true)
                    {
                        foreach (Photo photo in taggedUser.m_PhotosOfUser)
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
            ImageReaction newImageReaction = new ImageReaction(m_photosToReactOn.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

        private void checkBoxUserTaggedWith_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
