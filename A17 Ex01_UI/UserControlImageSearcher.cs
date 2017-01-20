using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A17_Ex01_Logic;
using System.Threading;

namespace A17_Ex01_UI
{
    public partial class UserControlImageSearcher : UserControl
    {
        readonly List<Photo>        r_PhotosDisplayed = new List<Photo>();
        private ImageSearcherLogic  m_ImageSearcherLogicItem;
        User                        m_LoggedInUser;

        public UserControlImageSearcher(User i_LoggedUser)
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

            List<System.Drawing.Image> sy = new List<System.Drawing.Image>();

            Thread featch = new Thread(() =>
            {
                foreach (Photo photo in i_Photolist)
                {
                    Thread T = new Thread(() =>
                    {
                        System.Drawing.Image newPhoto = photo.ImageNormal;
                        lock (this)
                        {
                            sy.Add(newPhoto);
                        }

                    });
                    T.Start();

                    r_PhotosDisplayed.Add(photo);
                }
            });

            featch.Start();
            featch.Join();

            imageListFromUser.Images.AddRange(sy.ToArray()); 

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
            List<int> yearsOfPhotos = m_ImageSearcherLogicItem.m_PhotosByYearList.Keys.ToList();
            foreach (int yearOfPhoto in yearsOfPhotos)
            {
                checkedListBoxYearOfPhoto.Items.Add(yearOfPhoto);
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
            FormImageReaction newImageReaction = new FormImageReaction(r_PhotosDisplayed.ElementAt(listViewPhotoDisplay.SelectedIndices[0]));
            newImageReaction.Show();
        }

    }
}
