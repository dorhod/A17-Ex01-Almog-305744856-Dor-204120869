namespace A17_Ex01_UI
{
    partial class UserFeed
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Posts = new System.Windows.Forms.Panel();
            this.panel_Posts.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1065, 740);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // panel_Posts
            // 
            this.panel_Posts.AutoScroll = true;
            this.panel_Posts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Posts.Controls.Add(this.flowLayoutPanel);
            this.panel_Posts.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_Posts.Location = new System.Drawing.Point(0, 0);
            this.panel_Posts.Name = "panel_Posts";
            this.panel_Posts.Size = new System.Drawing.Size(1069, 744);
            this.panel_Posts.TabIndex = 0;
            // 
            // UserFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 744);
            this.Controls.Add(this.panel_Posts);
            this.Name = "UserFeed";
            this.Text = "UserFeed";
            this.panel_Posts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panel_Posts;
    }
}