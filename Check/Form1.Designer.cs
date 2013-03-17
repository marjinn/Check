namespace Check
{
    partial class Check
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.Fix = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.Fixlabel = new System.Windows.Forms.Label();
            this.Scan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fix
            // 
            this.Fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.Fix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Fix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fix.Image = ((System.Drawing.Image)(resources.GetObject("Fix.Image")));
            this.Fix.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Fix.Location = new System.Drawing.Point(575, 13);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(83, 35);
            this.Fix.TabIndex = 1;
            this.Fix.Text = "Fix";
            this.Fix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fix.UseVisualStyleBackColor = false;
            this.Fix.Click += new System.EventHandler(this.Fix_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(24, 29);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 2;
            // 
            // Fixlabel
            // 
            this.Fixlabel.AutoSize = true;
            this.Fixlabel.Location = new System.Drawing.Point(24, 31);
            this.Fixlabel.Name = "Fixlabel";
            this.Fixlabel.Size = new System.Drawing.Size(0, 13);
            this.Fixlabel.TabIndex = 3;
            // 
            // Scan
            // 
            this.Scan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(198)))));
            this.Scan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scan.ForeColor = System.Drawing.Color.White;
            this.Scan.Image = ((System.Drawing.Image)(resources.GetObject("Scan.Image")));
            this.Scan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Scan.Location = new System.Drawing.Point(153, 13);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(83, 35);
            this.Scan.TabIndex = 0;
            this.Scan.Text = "Scan";
            this.Scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Scan.UseVisualStyleBackColor = false;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 285);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Fixlabel);
            this.groupBox2.Location = new System.Drawing.Point(418, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 285);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(64)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(804, 352);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Fix);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 390);
            this.MinimumSize = new System.Drawing.Size(820, 390);
            this.Name = "Check";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Fix;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label Fixlabel;
        private System.Windows.Forms.Button Scan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

