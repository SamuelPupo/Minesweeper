namespace Minesweeper
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.GroupBox();
            this.Image_1 = new System.Windows.Forms.PictureBox();
            this.Events = new System.Windows.Forms.GroupBox();
            this.Image_2 = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.GroupBox();
            this.Image_4 = new System.Windows.Forms.PictureBox();
            this.Image_3 = new System.Windows.Forms.PictureBox();
            this.Description.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_1)).BeginInit();
            this.Events.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_2)).BeginInit();
            this.GameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_3)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(339, 428);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 21);
            this.Next.TabIndex = 7;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(227, 428);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 21);
            this.Back.TabIndex = 8;
            this.Back.Text = "Exit";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Description
            // 
            this.Description.Controls.Add(this.Image_1);
            this.Description.Location = new System.Drawing.Point(89, 12);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(450, 410);
            this.Description.TabIndex = 10;
            this.Description.TabStop = false;
            this.Description.Text = "Decription";
            // 
            // Image_1
            // 
            this.Image_1.Image = global::Minesweeper.Images.Capture_1;
            this.Image_1.Location = new System.Drawing.Point(6, 19);
            this.Image_1.Name = "Image_1";
            this.Image_1.Size = new System.Drawing.Size(432, 386);
            this.Image_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_1.TabIndex = 9;
            this.Image_1.TabStop = false;
            // 
            // Events
            // 
            this.Events.Controls.Add(this.Image_2);
            this.Events.Location = new System.Drawing.Point(9, 12);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(620, 410);
            this.Events.TabIndex = 0;
            this.Events.TabStop = false;
            this.Events.Text = "Events";
            this.Events.Visible = false;
            // 
            // Image_2
            // 
            this.Image_2.Image = global::Minesweeper.Images.Capture_2;
            this.Image_2.Location = new System.Drawing.Point(6, 29);
            this.Image_2.Name = "Image_2";
            this.Image_2.Size = new System.Drawing.Size(608, 364);
            this.Image_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_2.TabIndex = 10;
            this.Image_2.TabStop = false;
            // 
            // GameOver
            // 
            this.GameOver.Controls.Add(this.Image_4);
            this.GameOver.Controls.Add(this.Image_3);
            this.GameOver.Location = new System.Drawing.Point(45, 12);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(550, 410);
            this.GameOver.TabIndex = 11;
            this.GameOver.TabStop = false;
            this.GameOver.Text = "Game Over";
            this.GameOver.Visible = false;
            // 
            // Image_4
            // 
            this.Image_4.Image = global::Minesweeper.Images.Capture_4;
            this.Image_4.Location = new System.Drawing.Point(294, 29);
            this.Image_4.Name = "Image_4";
            this.Image_4.Size = new System.Drawing.Size(251, 348);
            this.Image_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_4.TabIndex = 11;
            this.Image_4.TabStop = false;
            // 
            // Image_3
            // 
            this.Image_3.Image = global::Minesweeper.Images.Capture_3;
            this.Image_3.Location = new System.Drawing.Point(6, 29);
            this.Image_3.Name = "Image_3";
            this.Image_3.Size = new System.Drawing.Size(251, 348);
            this.Image_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Image_3.TabIndex = 10;
            this.Image_3.TabStop = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(638, 461);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Events);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(654, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(654, 500);
            this.Name = "Tutorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutorial";
            this.Description.ResumeLayout(false);
            this.Description.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_1)).EndInit();
            this.Events.ResumeLayout(false);
            this.Events.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_2)).EndInit();
            this.GameOver.ResumeLayout(false);
            this.GameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox Image_1;
        private System.Windows.Forms.GroupBox Description;
        private new System.Windows.Forms.GroupBox Events;
        private System.Windows.Forms.PictureBox Image_2;
        private System.Windows.Forms.GroupBox GameOver;
        private System.Windows.Forms.PictureBox Image_3;
        private System.Windows.Forms.PictureBox Image_4;
    }
}