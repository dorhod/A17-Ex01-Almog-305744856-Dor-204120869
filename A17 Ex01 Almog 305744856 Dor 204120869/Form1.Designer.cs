namespace A17_Ex01_UI
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoredBlockTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.Control;
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
            this.pictureBoxColoredBlockTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBoxColoredBlockTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxColoredBlockTop.Location = new System.Drawing.Point(20, 28);
            this.pictureBoxColoredBlockTop.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxColoredBlockTop.Name = "pictureBoxColoredBlockTop";
            this.pictureBoxColoredBlockTop.Size = new System.Drawing.Size(1061, 31);
            this.pictureBoxColoredBlockTop.TabIndex = 7;
            this.pictureBoxColoredBlockTop.TabStop = false;
            // 
            // checkBoxUserTaggedWith
            // 
            this.checkBoxUserTaggedWith.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBoxUserTaggedWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxUserTaggedWith.FormattingEnabled = true;
            this.checkBoxUserTaggedWith.Location = new System.Drawing.Point(45, 112);
            this.checkBoxUserTaggedWith.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUserTaggedWith.Name = "checkBoxUserTaggedWith";
            this.checkBoxUserTaggedWith.Size = new System.Drawing.Size(199, 493);
            this.checkBoxUserTaggedWith.TabIndex = 9;
            this.checkBoxUserTaggedWith.SelectedIndexChanged += new System.EventHandler(this.checkBoxUserTaggedWith_SelectedIndexChanged);
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.Location = new System.Drawing.Point(248, 567);
            this.buttonSearchPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(105, 38);
            this.buttonSearchPhotos.TabIndex = 10;
            this.buttonSearchPhotos.Text = "SearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // pictureBoxProfilPicture
            // 
            this.pictureBoxProfilPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilPicture.Location = new System.Drawing.Point(981, 11);
            this.pictureBoxProfilPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfilPicture.Name = "pictureBoxProfilPicture";
            this.pictureBoxProfilPicture.Size = new System.Drawing.Size(91, 75);
            this.pictureBoxProfilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilPicture.TabIndex = 11;
            this.pictureBoxProfilPicture.TabStop = false;
            this.pictureBoxProfilPicture.Click += new System.EventHandler(this.pictureBoxProfilPicture_Click_1);
            // 
            // listViewPhotoDisplay
            // 
            this.listViewPhotoDisplay.Location = new System.Drawing.Point(367, 102);
            this.listViewPhotoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPhotoDisplay.Name = "listViewPhotoDisplay";
            this.listViewPhotoDisplay.Size = new System.Drawing.Size(705, 503);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 727);
            this.Controls.Add(this.listViewPhotoDisplay);
            this.Controls.Add(this.pictureBoxProfilPicture);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.checkBoxUserTaggedWith);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxColoredBlockTop);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

