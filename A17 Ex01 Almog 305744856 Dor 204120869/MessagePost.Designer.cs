namespace A17_Ex01_UI
{
    partial class MessagePost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagePost));
            this.label_message = new System.Windows.Forms.Label();
            this.labelSender = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelStory = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_likeAmount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonComment = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSenderPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_message
            // 
            this.label_message.AutoEllipsis = true;
            resources.ApplyResources(this.label_message, "label_message");
            this.label_message.Name = "label_message";
            this.label_message.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSender
            // 
            resources.ApplyResources(this.labelSender, "labelSender");
            this.labelSender.Name = "labelSender";
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.Name = "labelTime";
            // 
            // labelStory
            // 
            resources.ApplyResources(this.labelStory, "labelStory");
            this.labelStory.ForeColor = System.Drawing.Color.Blue;
            this.labelStory.Name = "labelStory";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label_message, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelStory, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.label_likeAmount, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // label_likeAmount
            // 
            resources.ApplyResources(this.label_likeAmount, "label_likeAmount");
            this.label_likeAmount.Name = "label_likeAmount";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::A17_Ex01_UI.Properties.Resources.facebook_like_icon__3;
            this.pictureBox1.Image = global::A17_Ex01_UI.Properties.Resources.facebook_like_icon__3;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.buttonComment, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // buttonComment
            // 
            this.buttonComment.BackgroundImage = global::A17_Ex01_UI.Properties.Resources.Top;
            resources.ApplyResources(this.buttonComment, "buttonComment");
            this.buttonComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonComment.Name = "buttonComment";
            this.buttonComment.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.pictureBoxSenderPhoto, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // pictureBoxSenderPhoto
            // 
            resources.ApplyResources(this.pictureBoxSenderPhoto, "pictureBoxSenderPhoto");
            this.pictureBoxSenderPhoto.Name = "pictureBoxSenderPhoto";
            this.pictureBoxSenderPhoto.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.labelTime, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelSender, 0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // MessagePost
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MessagePost";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSenderPhoto)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.PictureBox pictureBoxSenderPhoto;
        private System.Windows.Forms.Label labelSender;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelStory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonComment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_likeAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
