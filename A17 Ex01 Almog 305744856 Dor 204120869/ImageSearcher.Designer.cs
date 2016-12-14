namespace A17_Ex01_UI
{
    partial class ImageSearcher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxUserTaggedWith = new System.Windows.Forms.CheckedListBox();
            this.listViewPhotoDisplay = new System.Windows.Forms.ListView();
            this.buttonSearchPhotos = new System.Windows.Forms.Button();
            this.buttonOpenSelectedPhoto = new System.Windows.Forms.Button();
            this.imageListFromUser = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // checkBoxUserTaggedWith
            // 
            this.checkBoxUserTaggedWith.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBoxUserTaggedWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxUserTaggedWith.FormattingEnabled = true;
            this.checkBoxUserTaggedWith.Location = new System.Drawing.Point(20, 29);
            this.checkBoxUserTaggedWith.Name = "checkBoxUserTaggedWith";
            this.checkBoxUserTaggedWith.Size = new System.Drawing.Size(298, 728);
            this.checkBoxUserTaggedWith.TabIndex = 10;
            // 
            // listViewPhotoDisplay
            // 
            this.listViewPhotoDisplay.Location = new System.Drawing.Point(382, 18);
            this.listViewPhotoDisplay.Name = "listViewPhotoDisplay";
            this.listViewPhotoDisplay.Size = new System.Drawing.Size(1056, 794);
            this.listViewPhotoDisplay.TabIndex = 13;
            this.listViewPhotoDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.Location = new System.Drawing.Point(382, 831);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(174, 59);
            this.buttonSearchPhotos.TabIndex = 14;
            this.buttonSearchPhotos.Text = "SearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // buttonOpenSelectedPhoto
            // 
            this.buttonOpenSelectedPhoto.Location = new System.Drawing.Point(571, 833);
            this.buttonOpenSelectedPhoto.Name = "buttonOpenSelectedPhoto";
            this.buttonOpenSelectedPhoto.Size = new System.Drawing.Size(168, 59);
            this.buttonOpenSelectedPhoto.TabIndex = 15;
            this.buttonOpenSelectedPhoto.Text = "Select";
            this.buttonOpenSelectedPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenSelectedPhoto.Click += new System.EventHandler(this.buttonOpenSelectedPhoto_Click_1);
            // 
            // imageListFromUser
            // 
            this.imageListFromUser.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListFromUser.ImageSize = new System.Drawing.Size(192, 144);
            this.imageListFromUser.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImageSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOpenSelectedPhoto);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.listViewPhotoDisplay);
            this.Controls.Add(this.checkBoxUserTaggedWith);
            this.Name = "ImageSearcher";
            this.Size = new System.Drawing.Size(1474, 914);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkBoxUserTaggedWith;
        private System.Windows.Forms.ListView listViewPhotoDisplay;
        private System.Windows.Forms.Button buttonSearchPhotos;
        private System.Windows.Forms.Button buttonOpenSelectedPhoto;
        private System.Windows.Forms.ImageList imageListFromUser;
    }
}
