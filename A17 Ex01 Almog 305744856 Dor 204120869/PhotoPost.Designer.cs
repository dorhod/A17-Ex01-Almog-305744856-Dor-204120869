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
            this.pictureBox_PostPic = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_LikesAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PostPic
            // 
            this.pictureBox_PostPic.Location = new System.Drawing.Point(144, 88);
            this.pictureBox_PostPic.Name = "pictureBox_PostPic";
            this.pictureBox_PostPic.Size = new System.Drawing.Size(410, 250);
            this.pictureBox_PostPic.TabIndex = 0;
            this.pictureBox_PostPic.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 407);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(629, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label_LikesAmount
            // 
            this.label_LikesAmount.AutoSize = true;
            this.label_LikesAmount.Location = new System.Drawing.Point(37, 368);
            this.label_LikesAmount.Name = "label_LikesAmount";
            this.label_LikesAmount.Size = new System.Drawing.Size(70, 25);
            this.label_LikesAmount.TabIndex = 2;
            this.label_LikesAmount.Text = "label1";
            // 
            // PhotoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_LikesAmount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_PostPic);
            this.Name = "PhotoPost";
            this.Size = new System.Drawing.Size(738, 466);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PostPic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_LikesAmount;
    }
}
