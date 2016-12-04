using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace A17_Ex01_UI
{
    class UserWithPhotos
    {
        private List<Photo> m_PhotosOfUser;
        private User m_TaggedUser;

        public UserWithPhotos(User taggedUser, Photo photoOfUser)
        {
            this.m_PhotosOfUser = new List<Photo>();
            this.m_TaggedUser = taggedUser;
            m_PhotosOfUser.Add(photoOfUser);
        }

        public User GetTaggedUser()
        {
            return this.m_TaggedUser;
        }

        public List<Photo> GetPhotosOfUser()
        {
            return this.m_PhotosOfUser;
        }

        public void AddPhotoToUser(Photo i_photo)
        {
            if (!IsPhotoExist(i_photo))
            {
                this.m_PhotosOfUser.Add(i_photo);
            }
        }

        public Boolean IsPhotoExist(Photo i_photo)
        {
            foreach (Photo photo in m_PhotosOfUser)
            {
                if (photo.Id == i_photo.Id)
                {
                    return true;
                }
            }

            return false;
        }

    }
}

