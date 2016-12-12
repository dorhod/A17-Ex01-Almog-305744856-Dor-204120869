namespace A17_Ex01_UI
{
    partial class AppHomepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxColoredBlockTop = new System.Windows.Forms.PictureBox();
            this.checkBoxUserTaggedWith = new System.Windows.Forms.CheckedListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonSearchPhotos = new System.Windows.Forms.Button();
            this.pictureBoxProfilPicture = new System.Windows.Forms.PictureBox();
            this.listViewPhotoDisplay = new System.Windows.Forms.ListView();
            this.imageListFromUser = new System.Windows.Forms.ImageList(this.components);
            this.buttonRandomPhoto = new System.Windows.Forms.Button();
            this.buttonOpenSelectedPhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoredBlockTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLogin.Image = global::A17_Ex01_UI.Properties.Resources.Top;
            this.buttonLogin.Location = new System.Drawing.Point(45, 44);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(114, 45);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxColoredBlockTop
            // 
            this.pictureBoxColoredBlockTop.BackColor = System.Drawing.Color.White;
            this.pictureBoxColoredBlockTop.BackgroundImage = global::A17_Ex01_UI.Properties.Resources.Top;
            this.pictureBoxColoredBlockTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxColoredBlockTop.Location = new System.Drawing.Point(20, 28);
            this.pictureBoxColoredBlockTop.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxColoredBlockTop.Name = "pictureBoxColoredBlockTop";
            this.pictureBoxColoredBlockTop.Size = new System.Drawing.Size(1061, 31);
            this.pictureBoxColoredBlockTop.TabIndex = 7;
            this.pictureBoxColoredBlockTop.TabStop = false;
            this.pictureBoxColoredBlockTop.Click += new System.EventHandler(this.pictureBoxColoredBlockTop_Click);
            // 
            // checkBoxUserTaggedWith
            // 
            this.checkBoxUserTaggedWith.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBoxUserTaggedWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxUserTaggedWith.FormattingEnabled = true;
            this.checkBoxUserTaggedWith.Location = new System.Drawing.Point(45, 129);
            this.checkBoxUserTaggedWith.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUserTaggedWith.Name = "checkBoxUserTaggedWith";
            this.checkBoxUserTaggedWith.Size = new System.Drawing.Size(199, 476);
            this.checkBoxUserTaggedWith.TabIndex = 9;
            this.checkBoxUserTaggedWith.SelectedIndexChanged += new System.EventHandler(this.checkBoxUserTaggedWith_SelectedIndexChanged);
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.Location = new System.Drawing.Point(367, 621);
            this.buttonSearchPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(116, 38);
            this.buttonSearchPhotos.TabIndex = 10;
            this.buttonSearchPhotos.Text = "SearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // pictureBoxProfilPicture
            // 
            this.pictureBoxProfilPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfilPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilPicture.Location = new System.Drawing.Point(946, 11);
            this.pictureBoxProfilPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilPicture.Name = "pictureBoxProfilPicture";
            this.pictureBoxProfilPicture.Size = new System.Drawing.Size(126, 111);
            this.pictureBoxProfilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilPicture.TabIndex = 11;
            this.pictureBoxProfilPicture.TabStop = false;
            this.pictureBoxProfilPicture.Click += new System.EventHandler(this.pictureBoxProfilPicture_Click_1);
            // 
            // listViewPhotoDisplay
            // 
            this.listViewPhotoDisplay.Location = new System.Drawing.Point(367, 126);
            this.listViewPhotoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPhotoDisplay.Name = "listViewPhotoDisplay";
            this.listViewPhotoDisplay.Size = new System.Drawing.Size(705, 479);
            this.listViewPhotoDisplay.TabIndex = 12;
            this.listViewPhotoDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewPhotoDisplay.SelectedIndexChanged += new System.EventHandler(this.listViewPhotoDisplay_SelectedIndexChanged);
            // 
            // imageListFromUser
            // 
            this.imageListFromUser.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListFromUser.ImageSize = new System.Drawing.Size(192, 144);
            this.imageListFromUser.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonRandomPhoto
            // 
            this.buttonRandomPhoto.Location = new System.Drawing.Point(960, 621);
            this.buttonRandomPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandomPhoto.Name = "buttonRandomPhoto";
            this.buttonRandomPhoto.Size = new System.Drawing.Size(112, 38);
            this.buttonRandomPhoto.TabIndex = 13;
            this.buttonRandomPhoto.Text = "RandomPhoto";
            this.buttonRandomPhoto.UseVisualStyleBackColor = true;
            this.buttonRandomPhoto.Click += new System.EventHandler(this.buttonRandomPhoto_Click);
            // 
            // buttonOpenSelectedPhoto
            // 
            this.buttonOpenSelectedPhoto.Location = new System.Drawing.Point(487, 621);
            this.buttonOpenSelectedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenSelectedPhoto.Name = "buttonOpenSelectedPhoto";
            this.buttonOpenSelectedPhoto.Size = new System.Drawing.Size(112, 38);
            this.buttonOpenSelectedPhoto.TabIndex = 14;
            this.buttonOpenSelectedPhoto.Text = "Select";
            this.buttonOpenSelectedPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenSelectedPhoto.Click += new System.EventHandler(this.buttonOpenSelectedPhoto_Click);
            // 
            // AppHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 672);
            this.Controls.Add(this.buttonOpenSelectedPhoto);
            this.Controls.Add(this.buttonRandomPhoto);
            this.Controls.Add(this.listViewPhotoDisplay);
            this.Controls.Add(this.pictureBoxProfilPicture);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.checkBoxUserTaggedWith);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxColoredBlockTop);
            this.Name = "AppHomepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoredBlockTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxColoredBlockTop;
        private System.Windows.Forms.CheckedListBox checkBoxUserTaggedWith;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonSearchPhotos;
        private System.Windows.Forms.PictureBox pictureBoxProfilPicture;
        private System.Windows.Forms.ListView listViewPhotoDisplay;
        private System.Windows.Forms.ImageList imageListFromUser;
        private System.Windows.Forms.Button buttonRandomPhoto;
        private System.Windows.Forms.Button buttonOpenSelectedPhoto;
    }
}

