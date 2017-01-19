namespace A17_Ex01_UI
{
    partial class UserControlImageSearcher
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
            this.checkedListBoxYearOfPhoto = new System.Windows.Forms.CheckedListBox();
            this.labelYearOfPhotos = new System.Windows.Forms.Label();
            this.labelUserInPhoto = new System.Windows.Forms.Label();
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxUserTaggedWith
            // 
            this.checkBoxUserTaggedWith.BackColor = System.Drawing.SystemColors.Menu;
            this.checkBoxUserTaggedWith.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkBoxUserTaggedWith.FormattingEnabled = true;
            this.checkBoxUserTaggedWith.Location = new System.Drawing.Point(13, 83);
            this.checkBoxUserTaggedWith.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxUserTaggedWith.Name = "checkBoxUserTaggedWith";
            this.checkBoxUserTaggedWith.Size = new System.Drawing.Size(199, 204);
            this.checkBoxUserTaggedWith.TabIndex = 10;
            // 
            // listViewPhotoDisplay
            // 
            this.listViewPhotoDisplay.Location = new System.Drawing.Point(265, 12);
            this.listViewPhotoDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPhotoDisplay.Name = "listViewPhotoDisplay";
            this.listViewPhotoDisplay.Size = new System.Drawing.Size(705, 465);
            this.listViewPhotoDisplay.TabIndex = 13;
            this.listViewPhotoDisplay.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSearchPhotos
            // 
            this.buttonSearchPhotos.Location = new System.Drawing.Point(265, 488);
            this.buttonSearchPhotos.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearchPhotos.Name = "buttonSearchPhotos";
            this.buttonSearchPhotos.Size = new System.Drawing.Size(116, 38);
            this.buttonSearchPhotos.TabIndex = 14;
            this.buttonSearchPhotos.Text = "SearchPhotos";
            this.buttonSearchPhotos.UseVisualStyleBackColor = true;
            this.buttonSearchPhotos.Click += new System.EventHandler(this.buttonSearchPhotos_Click);
            // 
            // buttonOpenSelectedPhoto
            // 
            this.buttonOpenSelectedPhoto.Location = new System.Drawing.Point(858, 488);
            this.buttonOpenSelectedPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenSelectedPhoto.Name = "buttonOpenSelectedPhoto";
            this.buttonOpenSelectedPhoto.Size = new System.Drawing.Size(112, 38);
            this.buttonOpenSelectedPhoto.TabIndex = 15;
            this.buttonOpenSelectedPhoto.Text = "Select";
            this.buttonOpenSelectedPhoto.UseVisualStyleBackColor = true;
            this.buttonOpenSelectedPhoto.Click += new System.EventHandler(this.buttonOpenSelectedPhoto_Click);
            // 
            // imageListFromUser
            // 
            this.imageListFromUser.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListFromUser.ImageSize = new System.Drawing.Size(192, 144);
            this.imageListFromUser.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // checkedListBoxYearOfPhoto
            // 
            this.checkedListBoxYearOfPhoto.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBoxYearOfPhoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxYearOfPhoto.FormattingEnabled = true;
            this.checkedListBoxYearOfPhoto.Location = new System.Drawing.Point(13, 333);
            this.checkedListBoxYearOfPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBoxYearOfPhoto.Name = "checkedListBoxYearOfPhoto";
            this.checkedListBoxYearOfPhoto.Size = new System.Drawing.Size(199, 153);
            this.checkedListBoxYearOfPhoto.TabIndex = 16;
            // 
            // labelYearOfPhotos
            // 
            this.labelYearOfPhotos.AutoSize = true;
            this.labelYearOfPhotos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelYearOfPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYearOfPhotos.Location = new System.Drawing.Point(10, 303);
            this.labelYearOfPhotos.Name = "labelYearOfPhotos";
            this.labelYearOfPhotos.Size = new System.Drawing.Size(228, 17);
            this.labelYearOfPhotos.TabIndex = 17;
            this.labelYearOfPhotos.Text = "Choose a year:                      ";
            // 
            // labelUserInPhoto
            // 
            this.labelUserInPhoto.AutoSize = true;
            this.labelUserInPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelUserInPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserInPhoto.Location = new System.Drawing.Point(10, 52);
            this.labelUserInPhoto.Name = "labelUserInPhoto";
            this.labelUserInPhoto.Size = new System.Drawing.Size(227, 17);
            this.labelUserInPhoto.TabIndex = 18;
            this.labelUserInPhoto.Text = "Choose friends in the photo\\s:";
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadLine.ForeColor = System.Drawing.Color.White;
            this.labelHeadLine.Image = global::A17_Ex01_UI.Properties.Resources.Top;
            this.labelHeadLine.Location = new System.Drawing.Point(5, 17);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(216, 20);
            this.labelHeadLine.TabIndex = 19;
            this.labelHeadLine.Text = "Filter Your Images Here!";
            // 
            // ImageSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHeadLine);
            this.Controls.Add(this.labelUserInPhoto);
            this.Controls.Add(this.labelYearOfPhotos);
            this.Controls.Add(this.checkedListBoxYearOfPhoto);
            this.Controls.Add(this.buttonOpenSelectedPhoto);
            this.Controls.Add(this.buttonSearchPhotos);
            this.Controls.Add(this.listViewPhotoDisplay);
            this.Controls.Add(this.checkBoxUserTaggedWith);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageSearcher";
            this.Size = new System.Drawing.Size(983, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkBoxUserTaggedWith;
        private System.Windows.Forms.ListView listViewPhotoDisplay;
        private System.Windows.Forms.Button buttonSearchPhotos;
        private System.Windows.Forms.Button buttonOpenSelectedPhoto;
        private System.Windows.Forms.ImageList imageListFromUser;
        private System.Windows.Forms.CheckedListBox checkedListBoxYearOfPhoto;
        private System.Windows.Forms.Label labelYearOfPhotos;
        private System.Windows.Forms.Label labelUserInPhoto;
        private System.Windows.Forms.Label labelHeadLine;
    }
}
