using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A17_Ex01_Logic
{
    public class ImageSearcherLogic
    {
        public List<Photo>                  m_AllPhotosList = new List<Photo>();
        public List<UserWithPhotos>         m_PhotosByUserList = new List<UserWithPhotos>();
        public Dictionary<int, List<Photo>> m_PhotosByYearList = new Dictionary<int, List<Photo>>();
        public List<Photo>                  m_ListOfYears = new List<Photo>();
        public List<PhotoTag>               m_ListOfTaggedUsers = new List<PhotoTag>();
        public List<Photo>                  m_PhotosCheckedByUser;
        public Boolean                      b_FirstCheck;

        public ImageSearcherLogic(User i_LoggedInUser)
        {
            fetchAllPicturesOfMainUser(i_LoggedInUser);
        }

        public List<Photo> fetchAllPicturesOfMainUser(User i_LoggedInUser)
        {
            PicturesColleciton picture = i_LoggedInUser.Pictures;

            foreach (Album album in i_LoggedInUser.Albums)
            {
                addAllPhotos(album.Photos);
            }
            addAllPhotos(i_LoggedInUser.PhotosTaggedIn);

            return m_AllPhotosList;
        }

        public void addAllPhotos(FacebookObjectCollection<Photo> i_Photos)
        {
            foreach (Photo photo in i_Photos)
            {
                m_AllPhotosList.Add(photo);
                // Create a list of years that has photos
                if (!m_PhotosByYearList.ContainsKey(photo.CreatedTime.GetValueOrDefault().Year))
                {
                    m_PhotosByYearList.Add(photo.CreatedTime.GetValueOrDefault().Year, new List<Photo>());
                }
            }

            foreach (Photo photo in m_AllPhotosList)
            {
                // Create a list of photos and by the user tagged in it
                createListOfPhotosByUser(photo);
                // Create a list of photos by the year they were added
                m_PhotosByYearList[photo.CreatedTime.GetValueOrDefault().Year].Add(photo);
            }
        }

        public void createListOfPhotosByUser(Photo i_Photo)
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
                        m_PhotosByUserList[indexOfTaggedUser].AddPhotoToUser(i_Photo);
                    }
                    else
                    {
                        m_PhotosByUserList.Add(new UserWithPhotos(photoTag.User, i_Photo));
                    }

                    // Add all tagged names to check box list
                    m_ListOfTaggedUsers.Add(photoTag);
                }
            }
        }

        private int photosByUserListContains(string i_NameOfUser)
        {
            int indexOfTaggedUser = 0;
            foreach (UserWithPhotos taggedUser in this.m_PhotosByUserList)
            {
                if (taggedUser.TaggedUser.Name.Equals(i_NameOfUser))
                    return indexOfTaggedUser;
                indexOfTaggedUser++;
            }

            return -1;
        }

        public void filterPhotosByYear(CheckedListBox.CheckedItemCollection i_CheckedItemsYearOfPhoto)
        {
            foreach (int year in m_PhotosByYearList.Keys)
            {
                if (i_CheckedItemsYearOfPhoto.Count > 1)
                {
                    m_PhotosCheckedByUser.Clear();
                }
                else
                {
                    fetchYearPhotos(year, i_CheckedItemsYearOfPhoto);
                }
            }
        }

        private void fetchYearPhotos(int i_Year, CheckedListBox.CheckedItemCollection i_CheckedItemsYearOfPhoto)
        {
            if (i_CheckedItemsYearOfPhoto.Contains(i_Year))
            {
                if (b_FirstCheck == true)
                {
                    foreach (Photo photo in m_PhotosByYearList[i_Year])
                    {
                        if (!m_PhotosCheckedByUser.Contains(photo))
                        {
                            m_PhotosCheckedByUser.Add(photo);
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
            foreach (Photo photo in m_PhotosCheckedByUser)
            {
                if (photo.CreatedTime.GetValueOrDefault().Year != i_Year)
                {
                    photosToDelete.Add(photo);
                }
            }

            foreach (Photo photo in photosToDelete)
            {
                m_PhotosCheckedByUser.Remove(photo);
            }
        }

        public void filterPhotosByUserName(CheckedListBox.CheckedItemCollection i_CheckedItemsTaggedInPhoto)
        {
            m_PhotosCheckedByUser = new List<Photo>();
            b_FirstCheck = true;

            foreach (UserWithPhotos taggedUser in m_PhotosByUserList)
            {
                if (i_CheckedItemsTaggedInPhoto.Contains(taggedUser.TaggedUser.Name))
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
                if (!m_PhotosCheckedByUser.Contains(photo))
                {
                    m_PhotosCheckedByUser.Add(photo);
                }
            }
            b_FirstCheck = false;
        }

        private void crossUsersPhotos(UserWithPhotos i_TaggedUser)
        {
            List<Photo> newPhotoCheckedByUser = new List<Photo>();
            foreach (Photo photo in m_PhotosCheckedByUser)
            {
                if (i_TaggedUser.IsPhotoExist(photo) == true)
                {
                    newPhotoCheckedByUser.Add(photo);
                }
            }
            m_PhotosCheckedByUser = newPhotoCheckedByUser;
        }
    }
}
