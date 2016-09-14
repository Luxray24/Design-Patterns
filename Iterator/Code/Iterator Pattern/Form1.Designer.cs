namespace Iterator_Pattern
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
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.band_rbtnGroup = new System.Windows.Forms.GroupBox();
            this.threeDaysGrace_rbtn = new System.Windows.Forms.RadioButton();
            this.riseAgainst_rbtn = new System.Windows.Forms.RadioButton();
            this.linkinPark_rbtn = new System.Windows.Forms.RadioButton();
            this.all_rbtn = new System.Windows.Forms.RadioButton();
            this.breakingBenjamin_rbtn = new System.Windows.Forms.RadioButton();
            this.avengedSevenfold_rbtn = new System.Windows.Forms.RadioButton();
            this.band_rbtnGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.Location = new System.Drawing.Point(12, 12);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(120, 186);
            this.lbDisplay.TabIndex = 2;
            // 
            // band_rbtnGroup
            // 
            this.band_rbtnGroup.Controls.Add(this.breakingBenjamin_rbtn);
            this.band_rbtnGroup.Controls.Add(this.linkinPark_rbtn);
            this.band_rbtnGroup.Controls.Add(this.threeDaysGrace_rbtn);
            this.band_rbtnGroup.Controls.Add(this.all_rbtn);
            this.band_rbtnGroup.Controls.Add(this.riseAgainst_rbtn);
            this.band_rbtnGroup.Controls.Add(this.avengedSevenfold_rbtn);
            this.band_rbtnGroup.Location = new System.Drawing.Point(139, 13);
            this.band_rbtnGroup.Name = "band_rbtnGroup";
            this.band_rbtnGroup.Size = new System.Drawing.Size(200, 185);
            this.band_rbtnGroup.TabIndex = 3;
            this.band_rbtnGroup.TabStop = false;
            this.band_rbtnGroup.Text = "Select A Band";
            // 
            // threeDaysGrace_rbtn
            // 
            this.threeDaysGrace_rbtn.AutoSize = true;
            this.threeDaysGrace_rbtn.Location = new System.Drawing.Point(7, 134);
            this.threeDaysGrace_rbtn.Name = "threeDaysGrace_rbtn";
            this.threeDaysGrace_rbtn.Size = new System.Drawing.Size(112, 17);
            this.threeDaysGrace_rbtn.TabIndex = 0;
            this.threeDaysGrace_rbtn.Text = "Three Days Grace";
            this.threeDaysGrace_rbtn.UseVisualStyleBackColor = true;
            this.threeDaysGrace_rbtn.CheckedChanged += new System.EventHandler(this.threeDaysGrace_rbtn_CheckedChanged);
            // 
            // riseAgainst_rbtn
            // 
            this.riseAgainst_rbtn.AutoSize = true;
            this.riseAgainst_rbtn.Location = new System.Drawing.Point(7, 111);
            this.riseAgainst_rbtn.Name = "riseAgainst_rbtn";
            this.riseAgainst_rbtn.Size = new System.Drawing.Size(84, 17);
            this.riseAgainst_rbtn.TabIndex = 1;
            this.riseAgainst_rbtn.Text = "Rise Against";
            this.riseAgainst_rbtn.UseVisualStyleBackColor = true;
            this.riseAgainst_rbtn.CheckedChanged += new System.EventHandler(this.riseAgainst_rbtn_CheckedChanged);
            // 
            // linkinPark_rbtn
            // 
            this.linkinPark_rbtn.AutoSize = true;
            this.linkinPark_rbtn.Location = new System.Drawing.Point(7, 88);
            this.linkinPark_rbtn.Name = "linkinPark_rbtn";
            this.linkinPark_rbtn.Size = new System.Drawing.Size(78, 17);
            this.linkinPark_rbtn.TabIndex = 2;
            this.linkinPark_rbtn.Text = "Linkin Park";
            this.linkinPark_rbtn.UseVisualStyleBackColor = true;
            this.linkinPark_rbtn.CheckedChanged += new System.EventHandler(this.linkinPark_rbtn_CheckedChanged);
            // 
            // all_rbtn
            // 
            this.all_rbtn.AutoSize = true;
            this.all_rbtn.Location = new System.Drawing.Point(7, 19);
            this.all_rbtn.Name = "all_rbtn";
            this.all_rbtn.Size = new System.Drawing.Size(36, 17);
            this.all_rbtn.TabIndex = 3;
            this.all_rbtn.Text = "All";
            this.all_rbtn.UseVisualStyleBackColor = true;
            this.all_rbtn.CheckedChanged += new System.EventHandler(this.all_rbtn_CheckedChanged);
            // 
            // breakingBenjamin_rbtn
            // 
            this.breakingBenjamin_rbtn.AutoSize = true;
            this.breakingBenjamin_rbtn.Location = new System.Drawing.Point(7, 65);
            this.breakingBenjamin_rbtn.Name = "breakingBenjamin_rbtn";
            this.breakingBenjamin_rbtn.Size = new System.Drawing.Size(113, 17);
            this.breakingBenjamin_rbtn.TabIndex = 4;
            this.breakingBenjamin_rbtn.Text = "Breaking Benjamin";
            this.breakingBenjamin_rbtn.UseVisualStyleBackColor = true;
            this.breakingBenjamin_rbtn.CheckedChanged += new System.EventHandler(this.breakingBenjamin_rbtn_CheckedChanged);
            // 
            // avengedSevenfold_rbtn
            // 
            this.avengedSevenfold_rbtn.AutoSize = true;
            this.avengedSevenfold_rbtn.Location = new System.Drawing.Point(7, 42);
            this.avengedSevenfold_rbtn.Name = "avengedSevenfold_rbtn";
            this.avengedSevenfold_rbtn.Size = new System.Drawing.Size(119, 17);
            this.avengedSevenfold_rbtn.TabIndex = 5;
            this.avengedSevenfold_rbtn.Text = "Avenged Sevenfold";
            this.avengedSevenfold_rbtn.UseVisualStyleBackColor = true;
            this.avengedSevenfold_rbtn.CheckedChanged += new System.EventHandler(this.avengedSevenfold_rbtn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 328);
            this.Controls.Add(this.band_rbtnGroup);
            this.Controls.Add(this.lbDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.band_rbtnGroup.ResumeLayout(false);
            this.band_rbtnGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.GroupBox band_rbtnGroup;
        private System.Windows.Forms.RadioButton breakingBenjamin_rbtn;
        private System.Windows.Forms.RadioButton linkinPark_rbtn;
        private System.Windows.Forms.RadioButton threeDaysGrace_rbtn;
        private System.Windows.Forms.RadioButton all_rbtn;
        private System.Windows.Forms.RadioButton riseAgainst_rbtn;
        private System.Windows.Forms.RadioButton avengedSevenfold_rbtn;
    }
}

