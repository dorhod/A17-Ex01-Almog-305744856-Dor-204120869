namespace A17_Ex01_UI
{
    partial class UserControlFilterWall
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
            this.labelHeadLine = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelHowMuchDisplay = new System.Windows.Forms.Label();
            this.comboBoxNumberToDisplay = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(395, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1256, 889);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // comboBoxWallFilter
            // 
            this.comboBoxWallFilter.Font = new System.Drawing.Font("Narkisim", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWallFilter.FormattingEnabled = true;
            this.comboBoxWallFilter.Items.AddRange(new object[] {
            "Most Recent",
            "Most Liked"});
            this.comboBoxWallFilter.Location = new System.Drawing.Point(20, 116);
            this.comboBoxWallFilter.Name = "comboBoxWallFilter";
            this.comboBoxWallFilter.Size = new System.Drawing.Size(182, 35);
            this.comboBoxWallFilter.TabIndex = 0;
            this.comboBoxWallFilter.Text = "Most Recent";
            this.comboBoxWallFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxWallFilter_SelectedIndexChanged);
            // 
            // labelHeadLine
            // 
            this.labelHeadLine.AutoSize = true;
            this.labelHeadLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadLine.ForeColor = System.Drawing.Color.White;
            this.labelHeadLine.Image = global::A17_Ex01_UI.Properties.Resources.Top;
            this.labelHeadLine.Location = new System.Drawing.Point(14, 14);
            this.labelHeadLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadLine.Name = "labelHeadLine";
            this.labelHeadLine.Size = new System.Drawing.Size(316, 32);
            this.labelHeadLine.TabIndex = 20;
            this.labelHeadLine.Text = "Filter Your Feed Here!";
            // 
            // labelFilter
            // 
            this.labelFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFilter.Location = new System.Drawing.Point(6, 64);
            this.labelFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(357, 27);
            this.labelFilter.TabIndex = 21;
            this.labelFilter.Text = "Filter By:  ";
            // 
            // labelHowMuchDisplay
            // 
            this.labelHowMuchDisplay.AutoSize = true;
            this.labelHowMuchDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelHowMuchDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHowMuchDisplay.Location = new System.Drawing.Point(6, 193);
            this.labelHowMuchDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHowMuchDisplay.Name = "labelHowMuchDisplay";
            this.labelHowMuchDisplay.Size = new System.Drawing.Size(357, 25);
            this.labelHowMuchDisplay.TabIndex = 22;
            this.labelHowMuchDisplay.Text = "Choose how much posts display:";
            // 
            // comboBoxNumberToDisplay
            // 
            this.comboBoxNumberToDisplay.Font = new System.Drawing.Font("Narkisim", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumberToDisplay.FormattingEnabled = true;
            this.comboBoxNumberToDisplay.Items.AddRange(new object[] {
            "10",
            "20",
            "50",
            "100",
            "200",
            "All"});
            this.comboBoxNumberToDisplay.Location = new System.Drawing.Point(20, 251);
            this.comboBoxNumberToDisplay.Name = "comboBoxNumberToDisplay";
            this.comboBoxNumberToDisplay.Size = new System.Drawing.Size(182, 35);
            this.comboBoxNumberToDisplay.TabIndex = 23;
            this.comboBoxNumberToDisplay.Text = "10";
            this.comboBoxNumberToDisplay.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberToDisplay_SelectedIndexChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(91, 839);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(173, 35);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh Feed";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // FilterWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxNumberToDisplay);
            this.Controls.Add(this.labelHowMuchDisplay);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.labelHeadLine);
            this.Controls.Add(this.comboBoxWallFilter);
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "FilterWall";
            this.Size = new System.Drawing.Size(1652, 889);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ComboBox comboBoxWallFilter;
        private System.Windows.Forms.Label labelHeadLine;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelHowMuchDisplay;
        private System.Windows.Forms.ComboBox comboBoxNumberToDisplay;
        private System.Windows.Forms.Button buttonRefresh;
    }
}
