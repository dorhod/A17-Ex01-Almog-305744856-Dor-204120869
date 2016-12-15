using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A17_Ex01_Logic
{
    public class UserWithPhotos
    {
        public List<Photo> PhotosOfUser { get; set; }
        public User        TaggedUser { get; set; }

        public UserWithPhotos(User i_TaggedUser, Photo i_PhotoOfUser)
        {
            this.PhotosOfUser = new List<Photo>();
            this.TaggedUser = i_TaggedUser;
            PhotosOfUser.Add(i_PhotoOfUser);
        }

        public void AddPhotoToUser(Photo i_Photo)
        {
            if (!IsPhotoExist(i_Photo))
            {
                this.PhotosOfUser.Add(i_Photo);
            }
        }

        public Boolean IsPhotoExist(Photo i_Photo)
        {
            Boolean photoExist = false;

            foreach (Photo photo in PhotosOfUser)
            {
                if (photo.Id == i_Photo.Id)
                {
                    photoExist = true;
                }
            }

            return photoExist;
        }

    }
}
 
