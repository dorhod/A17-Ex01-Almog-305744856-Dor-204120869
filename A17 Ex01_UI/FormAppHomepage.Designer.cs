namespace A17_Ex01_UI
{
    partial class FormAppHomepage
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
            this.tabControlFeatureViewer = new System.Windows.Forms.TabControl();
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
            // 
            // tabControlFeatureViewer
            // 
            this.tabControlFeatureViewer.Location = new System.Drawing.Point(30, 196);
            this.tabControlFeatureViewer.Name = "tabControlFeatureViewer";
            this.tabControlFeatureViewer.SelectedIndex = 0;
            this.tabControlFeatureViewer.Size = new System.Drawing.Size(1600, 930);
            this.tabControlFeatureViewer.TabIndex = 15;
            // 
            // AppHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1723, 1133);
            this.Controls.Add(this.tabControlFeatureViewer);
            this.Controls.Add(this.pictureBoxProfilPicture);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxColoredBlockTop);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
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
        private System.Windows.Forms.TabControl tabControlFeatureViewer;
    }
}

