namespace A17_Ex01_UI
{
    partial class PhotoPost
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
            this.label_message = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonComment = new System.Windows.Forms.Button();
            this.label_likeAmount = new System.Windows.Forms.Label();
            this.labelStory = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_PostPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxSenderPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_message, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_PostPic, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelStory, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(165, 0);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 523);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label_message
            // 
            this.label_message.AutoEllipsis = true;
            this.label_message.AutoSize = true;
            this.label_message.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_message.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_message.Location = new System.Drawing.Point(3, 151);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(156, 57);
            this.label_message.TabIndex = 0;
            this.label_message.Text = "message";
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
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 450);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1094, 70);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(906, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Write a comment...";
            // 
            // buttonComment
            // 
            this.buttonComment.BackgroundImage = global::A17_Ex01_UI.Properties.Resources.Top;
            this.buttonComment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonComment.Location = new System.Drawing.Point(926, 6);
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.Size = new System.Drawing.Size(160, 47);
            this.buttonComment.TabIndex = 8;
            this.buttonComment.Text = "Comment";
            this.buttonComment.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.5F));
            this.tableLayoutPanel5.Controls.Add(this.label_likeAmount, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 42);
            this.tableLayoutPanel5.TabIndex = 11;
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
            // pictureBox_PostPic
            // 
            this.pictureBox_PostPic.Location = new System.Drawing.Point(3, 233);
            this.pictureBox_PostPic.Name = "pictureBox_PostPic";
            this.pictureBox_PostPic.Size = new System.Drawing.Size(255, 163);
            this.pictureBox_PostPic.TabIndex = 0;
            this.pictureBox_PostPic.TabStop = false;
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
            // PhotoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhotoPost";
            this.Size = new System.Drawing.Size(1400, 522);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.Label label_likeAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
