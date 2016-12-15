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
            foreach (Photo photo in i_Photos)
            {
                r_AllPhotosList.Add(photo);
                // Create a list of years that has photos
                createListOfYears(photo);
            }

            foreach (Photo photo in r_AllPhotosList)
            {
                // Create a list of photos and by the user tagged in it
                createListOfPhotosByUser(photo);
                // Create a list of photos by the year they were added
                r_PhotosByYearList[photo.CreatedTime.GetValueOrDefault().Year].Add(photo);
            }
        }

        private void createListOfYears(Photo i_Photo)
        {
            // Create a list of years that has photos
            int yearOfPhoto = i_Photo.CreatedTime.GetValueOrDefault().Year;
            if (!r_PhotosByYearList.ContainsKey(yearOfPhoto))
            {
                r_PhotosByYearList.Add(yearOfPhoto, new List<Photo>());
                checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
            }
        }

        private void createListOfUsers(PhotoTag i_PhotoTag)
        {
            string taggedUserName = i_PhotoTag.User.Name;
            if (!checkBoxUserTaggedWith.Items.Contains(taggedUserName))
            {
                r_TagsWith.Add(i_PhotoTag.User);
                checkBoxUserTaggedWith.Items.Add(taggedUserName);
            }
        }

        private void createListOfPhotosByUser(Photo i_Photo)
        {
            FacebookObjectCollection<PhotoTag> photoTags = i_Photo.Tags;
            int indexOfTaggedUser;

            if (i_Photo.Tags != null)
            {
                foreach (PhotoTag photoTag in photoTags)
                {
                    indexOfTaggedUser = photosByUserListContains(photoTag.User.Name);

                    if (indexOfTaggedUser != -1)
                    {
                        r_PhotosByUserList[indexOfTaggedUser].AddPhotoToUser(i_Photo);
                    }
                    else
                    {
                        r_PhotosByUserList.Add(new UserWithPhotos(photoTag.User, i_Photo));
                    }

                    // Add all tagged names to check box list
                    createListOfUsers(photoTag);
                }
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
                else {
                    fetchYearPhotos(year);
                }
            }
        }

        private void fetchYearPhotos(int i_Year)
        {
            if (checkedListBoxYearOfPhoto.CheckedItems.Contains(i_Year))
            {
                if (b_FirstCheck == true)
                {
                    foreach (Photo photo in r_PhotosByYearList[i_Year])
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
                    deletePhotos(i_Year);
                }
            }
        }

        private void deletePhotos(int i_Year)
        {
            List<Photo> photosToDelete = new List<Photo>();
            foreach (Photo photo in m_photosCheckedByUser)
            {
                if (photo.CreatedTime.GetValueOrDefault().Year != i_Year)
                {
                    photosToDelete.Add(photo);
                }
            }

            foreach (Photo photo in photosToDelete)
            {
                m_photosCheckedByUser.Remove(photo);
            }
        }

        private void filterPhotosByUserName()
        {
            b_FirstCheck = true;

            foreach (UserWithPhotos taggedUser in r_PhotosByUserList)
            {
                if (checkBoxUserTaggedWith.CheckedItems.Contains(taggedUser.TaggedUser.Name))
                {
                    fetchUserPhotos(taggedUser);
                }
       
            }
        }

        private void fetchUserPhotos(UserWithPhotos i_TaggedUser)
        {
            if (b_FirstCheck == true)
            {
                addUserPhotos(i_TaggedUser.PhotosOfUser);          
            }
            else
            {
                crossUsersPhotos(i_TaggedUser);
            }
        }

        private void addUserPhotos(List<Photo> i_PhotosOfUser)
        {
            foreach (Photo photo in i_PhotosOfUser)
            {
                if (!m_photosCheckedByUser.Contains(photo))
                {
                    m_photosCheckedByUser.Add(photo);
                }
            }
            b_FirstCheck = false;
        }

        private void crossUsersPhotos(UserWithPhotos i_TaggedUser)
        {
            List<Photo> newPhotoCheckedByUser = new List<Photo>();
            foreach (Photo photo in m_photosCheckedByUser)
            {
                if (i_TaggedUser.IsPhotoExist(photo) == true)
                {
                    newPhotoCheckedByUser.Add(photo);
                }
            }
            m_photosCheckedByUser = newPhotoCheckedByUser;
        }

        private void buttonOpenSelectedPhoto_Click(object sender, EventArgs e)
        {
            ImageReaction newImageReaction = new ImageReaction(r_photosToReactOn.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

    }
}
