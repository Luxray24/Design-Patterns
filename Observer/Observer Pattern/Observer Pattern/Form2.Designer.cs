namespace Observer_Pattern
{
    partial class Form2
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
            this.songBox = new System.Windows.Forms.TextBox();
            this.albumBox = new System.Windows.Forms.TextBox();
            this.albumLabel = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songBox
            // 
            this.songBox.Location = new System.Drawing.Point(87, 6);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(259, 20);
            this.songBox.TabIndex = 0;
            this.songBox.TextChanged += new System.EventHandler(this.songBox_TextChanged);
            // 
            // albumBox
            // 
            this.albumBox.Location = new System.Drawing.Point(87, 35);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(259, 20);
            this.albumBox.TabIndex = 1;
            this.albumBox.TextChanged += new System.EventHandler(this.albumBox_TextChanged);
            // 
            // albumLabel
            // 
            this.albumLabel.AutoSize = true;
            this.albumLabel.Location = new System.Drawing.Point(5, 38);
            this.albumLabel.Name = "albumLabel";
            this.albumLabel.Size = new System.Drawing.Size(76, 13);
            this.albumLabel.TabIndex = 3;
            this.albumLabel.Text = "Album Search:";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Location = new System.Drawing.Point(5, 9);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(72, 13);
            this.songLabel.TabIndex = 4;
            this.songLabel.Text = "Song Search:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 70);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.albumLabel);
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.songBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox songBox;
        private System.Windows.Forms.TextBox albumBox;
        private System.Windows.Forms.Label albumLabel;
        private System.Windows.Forms.Label songLabel;
    }
}