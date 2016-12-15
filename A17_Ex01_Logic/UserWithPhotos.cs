using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using FacebookWrapper.ObjectModel;

namespace A17_Ex01_Logic
{
    public class UserWithPhotos
    {
        public List<Photo> m_PhotosOfUser { get; set; }
        public User m_TaggedUser { get; set; }

        public UserWithPhotos(User taggedUser, Photo photoOfUser)
        {
            this.m_PhotosOfUser = new List<Photo>();
            this.m_TaggedUser = taggedUser;
            m_PhotosOfUser.Add(photoOfUser);
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
 
