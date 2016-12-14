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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxColoredBlockTop = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBoxProfilPicture = new System.Windows.Forms.PictureBox();
            this.panel_FeatureViewer = new System.Windows.Forms.Panel();
            this.buttonFeed = new System.Windows.Forms.Button();
            this.buttonPhotos = new System.Windows.Forms.Button();
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
            this.buttonLogin.Location = new System.Drawing.Point(68, 69);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 70);
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
            this.pictureBoxColoredBlockTop.Location = new System.Drawing.Point(30, 44);
            this.pictureBoxColoredBlockTop.Name = "pictureBoxColoredBlockTop";
            this.pictureBoxColoredBlockTop.Size = new System.Drawing.Size(1592, 48);
            this.pictureBoxColoredBlockTop.TabIndex = 7;
            this.pictureBoxColoredBlockTop.TabStop = false;
            this.pictureBoxColoredBlockTop.Click += new System.EventHandler(this.pictureBoxColoredBlockTop_Click);
            // 
            // pictureBoxProfilPicture
            // 
            this.pictureBoxProfilPicture.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfilPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxProfilPicture.Location = new System.Drawing.Point(1419, 17);
            this.pictureBoxProfilPicture.Name = "pictureBoxProfilPicture";
            this.pictureBoxProfilPicture.Size = new System.Drawing.Size(189, 173);
            this.pictureBoxProfilPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilPicture.TabIndex = 11;
            this.pictureBoxProfilPicture.TabStop = false;
            this.pictureBoxProfilPicture.Click += new System.EventHandler(this.pictureBoxProfilPicture_Click_1);
            // 
            // panel_FeatureViewer
            // 
            this.panel_FeatureViewer.Location = new System.Drawing.Point(30, 211);
            this.panel_FeatureViewer.Name = "panel_FeatureViewer";
            this.panel_FeatureViewer.Size = new System.Drawing.Size(1592, 910);
            this.panel_FeatureViewer.TabIndex = 12;
            // 
            // buttonFeed
            // 
            this.buttonFeed.Location = new System.Drawing.Point(46, 183);
            this.buttonFeed.Name = "buttonFeed";
            this.buttonFeed.Size = new System.Drawing.Size(231, 38);
            this.buttonFeed.TabIndex = 13;
            this.buttonFeed.Text = "Feed";
            this.buttonFeed.UseVisualStyleBackColor = true;
            this.buttonFeed.Click += new System.EventHandler(this.buttonFeed_Click);
            // 
            // buttonPhotos
            // 
            this.buttonPhotos.Location = new System.Drawing.Point(286, 183);
            this.buttonPhotos.Name = "buttonPhotos";
            this.buttonPhotos.Size = new System.Drawing.Size(200, 38);
            this.buttonPhotos.TabIndex = 14;
            this.buttonPhotos.Text = "Photos";
            this.buttonPhotos.UseVisualStyleBackColor = true;
            this.buttonPhotos.Click += new System.EventHandler(this.buttonPhotos_Click);
            // 
            // AppHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1723, 1133);
            this.Controls.Add(this.buttonFeed);
            this.Controls.Add(this.buttonPhotos);
            this.Controls.Add(this.panel_FeatureViewer);
            this.Controls.Add(this.pictureBoxProfilPicture);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxColoredBlockTop);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AppHomepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColoredBlockTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxColoredBlockTop;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBoxProfilPicture;
        private System.Windows.Forms.Panel panel_FeatureViewer;
        private System.Windows.Forms.Button buttonFeed;
        private System.Windows.Forms.Button buttonPhotos;
    }
}

