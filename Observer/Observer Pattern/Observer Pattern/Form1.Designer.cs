namespace Observer_Pattern
{
    partial class Form1
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
            this.songResultBox = new System.Windows.Forms.ListBox();
            this.albumResultBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // songResultBox
            // 
            this.songResultBox.FormattingEnabled = true;
            this.songResultBox.Location = new System.Drawing.Point(13, 13);
            this.songResultBox.Name = "songResultBox";
            this.songResultBox.Size = new System.Drawing.Size(213, 329);
            this.songResultBox.TabIndex = 0;
            // 
            // albumResultBox
            // 
            this.albumResultBox.FormattingEnabled = true;
            this.albumResultBox.Location = new System.Drawing.Point(232, 13);
            this.albumResultBox.Name = "albumResultBox";
            this.albumResultBox.Size = new System.Drawing.Size(213, 329);
            this.albumResultBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 350);
            this.Controls.Add(this.albumResultBox);
            this.Controls.Add(this.songResultBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox songResultBox;
        private System.Windows.Forms.ListBox albumResultBox;
    }
}

