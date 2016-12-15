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
        readonly List<Photo> r_photosDisplayed = new List<Photo>();
        private ImageSearcherLogic ImageSearcherLogicItem;
        User m_LoggedInUser;

        public ImageSearcher(User i_LoggedUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedUser;
            ImageSearcherLogicItem = new ImageSearcherLogic(i_LoggedUser);
            showAllPicturesOfMainUser();
        }

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            listViewPhotoDisplay.Clear();
            imageListFromUser.Dispose();

            ImageSearcherLogicItem.filterPhotosByUserName(checkBoxUserTaggedWith.CheckedItems);
            ImageSearcherLogicItem.filterPhotosByYear(checkedListBoxYearOfPhoto.CheckedItems);
            showPhotos(ImageSearcherLogicItem.m_photosCheckedByUser);
        }

        private void showAllPicturesOfMainUser()
        {
            showPhotos(ImageSearcherLogicItem.fetchAllPicturesOfMainUser(m_LoggedInUser));
        }

        private void showPhotos(List<Photo> i_Photolist)
        {
            r_photosDisplayed.Clear();
            foreach (Photo photo in i_Photolist)
            {
                imageListFromUser.Images.Add(photo.ImageNormal);
                r_photosDisplayed.Add(photo);
            }

            listViewPhotoDisplay.View = View.LargeIcon;
            listViewPhotoDisplay.LargeImageList = imageListFromUser;

            for (int j = 0; j < this.imageListFromUser.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listViewPhotoDisplay.Items.Add(item);
            }

            createListOfYears();
            createListOfUsers();
        }

        private void createListOfYears()
        {
            // Create a list of years that has photos
            foreach (Photo photo in ImageSearcherLogicItem.m_AllPhotosList)
            {
                int yearOfPhoto = photo.CreatedTime.GetValueOrDefault().Year;
                if (ImageSearcherLogicItem.m_PhotosByYearList.ContainsKey(yearOfPhoto))
                {
                    if (!checkedListBoxYearOfPhoto.Items.Contains(yearOfPhoto))
                    {
                        checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
                    }             
                }

            }
        }

        private void createListOfUsers()
        {
            foreach (PhotoTag phototag in ImageSearcherLogicItem.m_ListOfTaggedUsers)
            {
                string taggedUserName = phototag.User.Name;
                if (!checkBoxUserTaggedWith.Items.Contains(taggedUserName))
                {
                    checkBoxUserTaggedWith.Items.Add(taggedUserName);
                }

            }
        }

        private void buttonOpenSelectedPhoto_Click(object sender, EventArgs e)
        {
            ImageReaction newImageReaction = new ImageReaction(r_photosDisplayed.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

    }
}
