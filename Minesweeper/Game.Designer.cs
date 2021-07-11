namespace Minesweeper
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.GameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TutorialMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MinesQuantity = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.ClockIcon = new System.Windows.Forms.PictureBox();
            this.MineIcon = new System.Windows.Forms.PictureBox();
            this.Board = new System.Windows.Forms.PictureBox();
            this.MinesAndClock = new System.Windows.Forms.GroupBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MineIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).BeginInit();
            this.MinesAndClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Control;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMenu,
            this.HelpMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(249, 24);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "menuStrip1";
            // 
            // GameMenu
            // 
            this.GameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameMenu,
            this.OptionsMenu,
            this.RecordsMenu,
            this.toolStripSeparator1,
            this.ExitMenu});
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(50, 20);
            this.GameMenu.Text = "Game";
            // 
            // NewGameMenu
            // 
            this.NewGameMenu.Name = "NewGameMenu";
            this.NewGameMenu.Size = new System.Drawing.Size(132, 22);
            this.NewGameMenu.Text = "New Game";
            this.NewGameMenu.Click += new System.EventHandler(this.NewGameMenu_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(132, 22);
            this.OptionsMenu.Text = "Options";
            this.OptionsMenu.Click += new System.EventHandler(this.OptionsMenu_Click);
            // 
            // RecordsMenu
            // 
            this.RecordsMenu.Name = "RecordsMenu";
            this.RecordsMenu.Size = new System.Drawing.Size(132, 22);
            this.RecordsMenu.Text = "Records";
            this.RecordsMenu.Click += new System.EventHandler(this.RecordsMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(132, 22);
            this.ExitMenu.Text = "Exit";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenu,
            this.toolStripSeparator2,
            this.TutorialMenu});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(44, 20);
            this.HelpMenu.Text = "Help";
            // 
            // AboutMenu
            // 
            this.AboutMenu.Name = "AboutMenu";
            this.AboutMenu.Size = new System.Drawing.Size(115, 22);
            this.AboutMenu.Text = "About";
            this.AboutMenu.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(112, 6);
            // 
            // TutorialMenu
            // 
            this.TutorialMenu.Name = "TutorialMenu";
            this.TutorialMenu.Size = new System.Drawing.Size(115, 22);
            this.TutorialMenu.Text = "Tutorial";
            this.TutorialMenu.Click += new System.EventHandler(this.TutorialMenu_Click);
            // 
            // MinesQuantity
            // 
            this.MinesQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MinesQuantity.AutoSize = true;
            this.MinesQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinesQuantity.Location = new System.Drawing.Point(161, 21);
            this.MinesQuantity.Name = "MinesQuantity";
            this.MinesQuantity.Size = new System.Drawing.Size(36, 20);
            this.MinesQuantity.TabIndex = 5;
            this.MinesQuantity.Text = "841";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Time.Location = new System.Drawing.Point(41, 21);
            this.Time.Name = "Time";
            this.Time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Time.Size = new System.Drawing.Size(49, 20);
            this.Time.TabIndex = 6;
            this.Time.Text = "00.00";
            // 
            // ClockIcon
            // 
            this.ClockIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClockIcon.Image = global::Minesweeper.Images.Clock;
            this.ClockIcon.Location = new System.Drawing.Point(6, 14);
            this.ClockIcon.Name = "ClockIcon";
            this.ClockIcon.Size = new System.Drawing.Size(35, 39);
            this.ClockIcon.TabIndex = 4;
            this.ClockIcon.TabStop = false;
            // 
            // MineIcon
            // 
            this.MineIcon.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MineIcon.Image = global::Minesweeper.Images.MineIcon;
            this.MineIcon.InitialImage = null;
            this.MineIcon.Location = new System.Drawing.Point(125, 14);
            this.MineIcon.Name = "MineIcon";
            this.MineIcon.Size = new System.Drawing.Size(33, 36);
            this.MineIcon.TabIndex = 2;
            this.MineIcon.TabStop = false;
            // 
            // Board
            // 
            this.Board.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Board.Location = new System.Drawing.Point(12, 27);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(225, 223);
            this.Board.TabIndex = 0;
            this.Board.TabStop = false;
            this.Board.Paint += new System.Windows.Forms.PaintEventHandler(this.Board_Paint);
            this.Board.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Board_MouseClick);
            this.Board.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Board_MouseDoubleClick);
            // 
            // MinesAndClock
            // 
            this.MinesAndClock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MinesAndClock.Controls.Add(this.MineIcon);
            this.MinesAndClock.Controls.Add(this.Time);
            this.MinesAndClock.Controls.Add(this.MinesQuantity);
            this.MinesAndClock.Controls.Add(this.ClockIcon);
            this.MinesAndClock.Location = new System.Drawing.Point(24, 256);
            this.MinesAndClock.MaximumSize = new System.Drawing.Size(200, 56);
            this.MinesAndClock.MinimumSize = new System.Drawing.Size(200, 56);
            this.MinesAndClock.Name = "MinesAndClock";
            this.MinesAndClock.Size = new System.Drawing.Size(200, 56);
            this.MinesAndClock.TabIndex = 7;
            this.MinesAndClock.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Visual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(249, 316);
            this.Controls.Add(this.MinesAndClock);
            this.Controls.Add(this.Board);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "Visual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClockIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MineIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Board)).EndInit();
            this.MinesAndClock.ResumeLayout(false);
            this.MinesAndClock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Board;
        private new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem GameMenu;
        private System.Windows.Forms.ToolStripMenuItem NewGameMenu;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem RecordsMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem AboutMenu;
        private System.Windows.Forms.ToolStripMenuItem TutorialMenu;
        private System.Windows.Forms.PictureBox MineIcon;
        private System.Windows.Forms.PictureBox ClockIcon;
        private System.Windows.Forms.Label MinesQuantity;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox MinesAndClock;
        private System.Windows.Forms.Timer Timer;
    }
}

