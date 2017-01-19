namespace A17_Ex01_UI
{
    partial class UserControlPost
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_likeAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_message = new System.Windows.Forms.Label();
            this.pictureBox_PostPic = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSenderPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.labelStory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_message, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_PostPic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelStory, 0, 4);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(29, 4);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(1114, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1114, 411);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.5F));
            this.tableLayoutPanel5.Controls.Add(this.label_likeAmount, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 288);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 42);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // label_likeAmount
            // 
            this.label_likeAmount.AutoSize = true;
            this.label_likeAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_likeAmount.Location = new System.Drawing.Point(3, 10);
            this.label_likeAmount.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label_likeAmount.Name = "label_likeAmount";
            this.label_likeAmount.Size = new System.Drawing.Size(40, 32);
            this.label_likeAmount.TabIndex = 3;
            this.label_likeAmount.Text = "Likes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::A17_Ex01_UI.Properties.Resources.facebook_like_icon__3;
            this.pictureBox1.Image = global::A17_Ex01_UI.Properties.Resources.facebook_like_icon__3;
            this.pictureBox1.Location = new System.Drawing.Point(56, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_message
            // 
            this.label_message.AutoEllipsis = true;
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_message.Location = new System.Drawing.Point(0, 151);
            this.label_message.Margin = new System.Windows.Forms.Padding(0);
            this.label_message.Name = "label_message";
            this.label_message.Padding = new System.Windows.Forms.Padding(10);
            this.label_message.Size = new System.Drawing.Size(176, 77);
            this.label_message.TabIndex = 0;
            this.label_message.Text = "message";
            // 
            // pictureBox_PostPic
            // 
            this.pictureBox_PostPic.Location = new System.Drawing.Point(3, 233);
            this.pictureBox_PostPic.Name = "pictureBox_PostPic";
            this.pictureBox_PostPic.Size = new System.Drawing.Size(68, 49);
            this.pictureBox_PostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_PostPic.TabIndex = 0;
            this.pictureBox_PostPic.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.39785F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.60215F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxSenderPhoto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(465, 100);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // pictureBoxSenderPhoto
            // 
            this.pictureBoxSenderPhoto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxSenderPhoto.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSenderPhoto.Name = "pictureBoxSenderPhoto";
            this.pictureBoxSenderPhoto.Size = new System.Drawing.Size(100, 78);
            this.pictureBoxSenderPhoto.TabIndex = 4;
            this.pictureBoxSenderPhoto.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.labelTime, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelSender, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(149, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(313, 94);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelTime.Location = new System.Drawing.Point(3, 47);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(59, 25);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time";
            // 
            // labelSender
            // 
            this.labelSender.AutoSize = true;
            this.labelSender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSender.Location = new System.Drawing.Point(3, 0);
            this.labelSender.Name = "labelSender";
            this.labelSender.Size = new System.Drawing.Size(81, 25);
            this.labelSender.TabIndex = 5;
            this.labelSender.Text = "Sender";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.46069F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53931F));
            this.tableLayoutPanel2.Controls.Add(this.buttonComment, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxComment, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1108, 72);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonComment
            // 
            this.buttonComment.BackgroundImage = global::A17_Ex01_UI.Properties.Resources.Top;
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonComment.Location = new System.Drawing.Point(938, 6);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(160, 47);
            this.buttonComment.TabIndex = 8;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
            this.buttonComment.Click += new System.EventHandler(this.buttonComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.AllowDrop = true;
            this.textBoxComment.BackColor = System.Drawing.Color.White;
            this.textBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxComment.Location = new System.Drawing.Point(3, 16);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(906, 31);
            this.textBoxComment.TabIndex = 1;
            this.textBoxComment.Text = "Write a comment...";
            // 
            // labelStory
            // 
            this.labelStory.AutoSize = true;
            this.labelStory.Font = new System.Drawing.Font("Narkisim", 10.125F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStory.ForeColor = System.Drawing.Color.Blue;
            this.labelStory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelStory.Location = new System.Drawing.Point(3, 106);
            this.labelStory.Name = "labelStory";
            this.labelStory.Size = new System.Drawing.Size(68, 27);
            this.labelStory.TabIndex = 7;
            this.labelStory.Text = "Story";
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1400, 0);
            this.Name = "Post";
            this.Size = new System.Drawing.Size(1182, 418);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PostPic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.Label labelStory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBoxSenderPhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Label label_likeAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
