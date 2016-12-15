namespace A17_Ex01_UI
{
    partial class FilterWall
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxWallFilter = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1460, 867);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // comboBoxWallFilter
            // 
            this.comboBoxWallFilter.FormattingEnabled = true;
            this.comboBoxWallFilter.Items.AddRange(new object[] {
            "Most Recent",
            "Most Liked"});
            this.comboBoxWallFilter.Location = new System.Drawing.Point(0, 0);
            this.comboBoxWallFilter.Name = "comboBoxWallFilter";
            this.comboBoxWallFilter.Size = new System.Drawing.Size(121, 33);
            this.comboBoxWallFilter.TabIndex = 0;
            this.comboBoxWallFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxWallFilter_SelectedIndexChanged);
            // 
            // FilterFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxWallFilter);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "FilterFeed";
            this.Size = new System.Drawing.Size(1460, 889);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox comboBoxWallFilter;
    }
}
