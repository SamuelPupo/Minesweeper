namespace Minesweeper
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.OK = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.By = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OK.Location = new System.Drawing.Point(526, 239);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            // 
            // Description
            // 
            this.Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description.Location = new System.Drawing.Point(205, 107);
            this.Description.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Description.Size = new System.Drawing.Size(396, 126);
            this.Description.TabIndex = 23;
            this.Description.TabStop = false;
            this.Description.Text = resources.GetString("Description.Text");
            // 
            // Year
            // 
            this.Year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Year.Location = new System.Drawing.Point(205, 78);
            this.Year.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Year.MaximumSize = new System.Drawing.Size(0, 17);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(396, 17);
            this.Year.TabIndex = 22;
            this.Year.Text = "2017";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Location
            // 
            this.Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Location.Location = new System.Drawing.Point(205, 52);
            this.Location.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Location.MaximumSize = new System.Drawing.Size(0, 17);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(396, 17);
            this.Location.TabIndex = 21;
            this.Location.Text = "Made in Cuba";
            this.Location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // By
            // 
            this.By.Dock = System.Windows.Forms.DockStyle.Fill;
            this.By.Location = new System.Drawing.Point(205, 26);
            this.By.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.By.MaximumSize = new System.Drawing.Size(0, 17);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(396, 17);
            this.By.TabIndex = 0;
            this.By.Text = "By: Samuel Efraín Pupo Wong";
            this.By.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            this.Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Game.Location = new System.Drawing.Point(205, 0);
            this.Game.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.Game.MaximumSize = new System.Drawing.Size(0, 17);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(396, 17);
            this.Game.TabIndex = 19;
            this.Game.Text = "Game: Minesweeper";
            this.Game.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.Game, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.By, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.Location, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.Year, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.Description, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.OK, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(604, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(193, 259);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // About
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(622, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 322);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 322);
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label Year;
        private new System.Windows.Forms.Label Location;
        private System.Windows.Forms.Label By;
        private System.Windows.Forms.Label Game;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}
