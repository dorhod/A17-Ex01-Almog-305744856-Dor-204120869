﻿namespace A17_Ex01_UI
{
    partial class ImageReaction
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
            this.buttonComment = new System.Windows.Forms.Button();
            this.buttonShare = new System.Windows.Forms.Button();
            this.buttonLike = new System.Windows.Forms.Button();
            this.pictureBoxSelectedPicture = new System.Windows.Forms.PictureBox();
            this.textBoxAddAComment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComment
            // 
            this.buttonComment.Location = new System.Drawing.Point(339, 626);
            this.buttonComment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(112, 38);
            this.buttonComment.TabIndex = 16;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // buttonShare
            // 
            this.buttonShare.Location = new System.Drawing.Point(499, 626);
            this.buttonShare.Margin = new System.Windows.Forms.Padding(2);
            this.buttonShare.Name = "buttonShare";
            this.buttonShare.Size = new System.Drawing.Size(112, 38);
            this.buttonShare.TabIndex = 17;
            this.buttonShare.Text = "Share";
            this.buttonShare.UseVisualStyleBackColor = true;
            this.buttonShare.Click += new System.EventHandler(this.buttonShare_Click);
            // 
            // buttonLike
            // 
            this.buttonLike.Location = new System.Drawing.Point(46, 578);
            this.buttonLike.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLike.Name = "buttonLike";
            this.buttonLike.Size = new System.Drawing.Size(112, 38);
            this.buttonLike.TabIndex = 18;
            this.buttonLike.Text = "Like";
            this.buttonLike.UseVisualStyleBackColor = true;
            this.buttonLike.Click += new System.EventHandler(this.buttonLike_Click);
            // 
            // pictureBoxSelectedPicture
            // 
            this.pictureBoxSelectedPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxSelectedPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelectedPicture.Location = new System.Drawing.Point(46, 49);
            this.pictureBoxSelectedPicture.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxSelectedPicture.Name = "pictureBoxSelectedPicture";
            this.pictureBoxSelectedPicture.Size = new System.Drawing.Size(757, 513);
            this.pictureBoxSelectedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSelectedPicture.TabIndex = 19;
            this.pictureBoxSelectedPicture.TabStop = false;
            this.pictureBoxSelectedPicture.Click += new System.EventHandler(this.pictureBoxSelectedPicture_Click);
            // 
            // textBoxAddAComment
            // 
            this.textBoxAddAComment.Location = new System.Drawing.Point(178, 579);
            this.textBoxAddAComment.Multiline = true;
            this.textBoxAddAComment.Name = "textBoxAddAComment";
            this.textBoxAddAComment.Size = new System.Drawing.Size(625, 37);
            this.textBoxAddAComment.TabIndex = 20;
            this.textBoxAddAComment.Text = "Add a comment  / Share with status";
            // 
            // ImageReaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 676);
            this.Controls.Add(this.textBoxAddAComment);
            this.Controls.Add(this.pictureBoxSelectedPicture);
            this.Controls.Add(this.buttonLike);
            this.Controls.Add(this.buttonShare);
            this.Controls.Add(this.buttonComment);
            this.Name = "ImageReaction";
            this.Text = "ImageReaction";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Button buttonShare;
        private System.Windows.Forms.Button buttonLike;
        private System.Windows.Forms.PictureBox pictureBoxSelectedPicture;
        private System.Windows.Forms.TextBox textBoxAddAComment;
    }
}