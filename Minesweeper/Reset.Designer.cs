namespace Minesweeper
{
    partial class Reset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset));
            this.All = new System.Windows.Forms.RadioButton();
            this.Novice = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Restart = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Checked = true;
            this.All.Location = new System.Drawing.Point(12, 12);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(36, 17);
            this.All.TabIndex = 0;
            this.All.TabStop = true;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            // 
            // Novice
            // 
            this.Novice.AutoSize = true;
            this.Novice.Location = new System.Drawing.Point(54, 12);
            this.Novice.Name = "Novice";
            this.Novice.Size = new System.Drawing.Size(59, 17);
            this.Novice.TabIndex = 1;
            this.Novice.Text = "Novice";
            this.Novice.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Location = new System.Drawing.Point(119, 12);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(83, 17);
            this.Intermediate.TabIndex = 2;
            this.Intermediate.Text = "Intermediate";
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(208, 12);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(55, 17);
            this.Expert.TabIndex = 3;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(39, 41);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(75, 23);
            this.Restart.TabIndex = 4;
            this.Restart.Text = "Restart";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(149, 41);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(268, 76);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.Expert);
            this.Controls.Add(this.Intermediate);
            this.Controls.Add(this.Novice);
            this.Controls.Add(this.All);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton All;
        private System.Windows.Forms.RadioButton Novice;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button Cancel;
    }
}