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
        readonly List<Photo>        r_PhotosDisplayed = new List<Photo>();
        private ImageSearcherLogic  m_ImageSearcherLogicItem;
        User                        m_LoggedInUser;

        public ImageSearcher(User i_LoggedUser)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedUser;
            m_ImageSearcherLogicItem = new ImageSearcherLogic(i_LoggedUser);
            showAllPicturesOfMainUser();
        }

        private void buttonSearchPhotos_Click(object sender, EventArgs e)
        {
            listViewPhotoDisplay.Clear();
            imageListFromUser.Dispose();

            m_ImageSearcherLogicItem.filterPhotosByUserName(checkBoxUserTaggedWith.CheckedItems);
            m_ImageSearcherLogicItem.filterPhotosByYear(checkedListBoxYearOfPhoto.CheckedItems);
            showPhotos(m_ImageSearcherLogicItem.m_PhotosCheckedByUser);
        }

        private void showAllPicturesOfMainUser()
        {
            showPhotos(m_ImageSearcherLogicItem.fetchAllPicturesOfMainUser(m_LoggedInUser));
        }

        private void showPhotos(List<Photo> i_Photolist)
        {
            r_PhotosDisplayed.Clear();
            foreach (Photo photo in i_Photolist)
            {
                imageListFromUser.Images.Add(photo.ImageNormal);
                r_PhotosDisplayed.Add(photo);
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
            foreach (Photo photo in m_ImageSearcherLogicItem.m_AllPhotosList)
            {
                int yearOfPhoto = photo.CreatedTime.GetValueOrDefault().Year;
                if (m_ImageSearcherLogicItem.m_PhotosByYearList.ContainsKey(yearOfPhoto))
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
            foreach (PhotoTag phototag in m_ImageSearcherLogicItem.m_ListOfTaggedUsers)
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
            ImageReaction newImageReaction = new ImageReaction(r_PhotosDisplayed.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

    }
}
