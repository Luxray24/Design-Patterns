namespace ProjectCreationManager
{
    partial class Product
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
            this.labelBox = new System.Windows.Forms.ListBox();
            this.infoBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelBox
            // 
            this.labelBox.FormattingEnabled = true;
            this.labelBox.Items.AddRange(new object[] {
            "Project Name:",
            "Project Type:",
            "IDE:",
            "Browser:",
            "FTP Client:",
            "Shell Interface:",
            "Github Desktop Active:",
            "MySQL Server Active:",
            "XAMPP Active:"});
            this.labelBox.Location = new System.Drawing.Point(12, 12);
            this.labelBox.Name = "labelBox";
            this.labelBox.Size = new System.Drawing.Size(120, 225);
            this.labelBox.TabIndex = 1;
            // 
            // infoBox
            // 
            this.infoBox.FormattingEnabled = true;
            this.infoBox.Location = new System.Drawing.Point(138, 12);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(120, 225);
            this.infoBox.TabIndex = 2;
            this.infoBox.SelectedIndexChanged += new System.EventHandler(this.infoBox_SelectedIndexChanged);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.labelBox);
            this.Name = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox labelBox;
        private System.Windows.Forms.ListBox infoBox;
    }
}