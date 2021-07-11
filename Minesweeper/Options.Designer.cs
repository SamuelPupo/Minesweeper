namespace Minesweeper
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.Novice = new System.Windows.Forms.RadioButton();
            this.Intermediate = new System.Windows.Forms.RadioButton();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Custom = new System.Windows.Forms.RadioButton();
            this.HeightSelector = new System.Windows.Forms.Label();
            this.WidthSelector = new System.Windows.Forms.Label();
            this.MinesSelector = new System.Windows.Forms.Label();
            this.Levels = new System.Windows.Forms.GroupBox();
            this.MinesNumber = new System.Windows.Forms.NumericUpDown();
            this.WidthNumber = new System.Windows.Forms.NumericUpDown();
            this.HeightNumber = new System.Windows.Forms.NumericUpDown();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Levels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Novice
            // 
            this.Novice.AutoSize = true;
            this.Novice.Checked = true;
            this.Novice.Location = new System.Drawing.Point(8, 23);
            this.Novice.Margin = new System.Windows.Forms.Padding(4);
            this.Novice.Name = "Novice";
            this.Novice.Size = new System.Drawing.Size(86, 55);
            this.Novice.TabIndex = 2;
            this.Novice.TabStop = true;
            this.Novice.Text = "Novice\r\n10 Mines\r\n9x9 Map";
            this.Novice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Novice.UseVisualStyleBackColor = true;
            // 
            // Intermediate
            // 
            this.Intermediate.AutoSize = true;
            this.Intermediate.Location = new System.Drawing.Point(8, 84);
            this.Intermediate.Margin = new System.Windows.Forms.Padding(4);
            this.Intermediate.Name = "Intermediate";
            this.Intermediate.Size = new System.Drawing.Size(107, 55);
            this.Intermediate.TabIndex = 3;
            this.Intermediate.Text = "Intermediate\r\n40 Mines\r\n16x16 Map";
            this.Intermediate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Intermediate.UseVisualStyleBackColor = true;
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(8, 144);
            this.Expert.Margin = new System.Windows.Forms.Padding(4);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(98, 55);
            this.Expert.TabIndex = 4;
            this.Expert.Text = "Expert\r\n99 Mines\r\n16x30 Map";
            this.Expert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Expert.UseVisualStyleBackColor = true;
            // 
            // Custom
            // 
            this.Custom.AutoSize = true;
            this.Custom.Location = new System.Drawing.Point(189, 39);
            this.Custom.Margin = new System.Windows.Forms.Padding(4);
            this.Custom.Name = "Custom";
            this.Custom.Size = new System.Drawing.Size(76, 21);
            this.Custom.TabIndex = 6;
            this.Custom.Text = "Custom";
            this.Custom.UseVisualStyleBackColor = true;
            this.Custom.CheckedChanged += new System.EventHandler(this.Custom_CheckedChanged);
            // 
            // HeightSelector
            // 
            this.HeightSelector.AutoSize = true;
            this.HeightSelector.Enabled = false;
            this.HeightSelector.Location = new System.Drawing.Point(189, 84);
            this.HeightSelector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeightSelector.Name = "HeightSelector";
            this.HeightSelector.Size = new System.Drawing.Size(104, 17);
            this.HeightSelector.TabIndex = 4;
            this.HeightSelector.Text = "Height (9 - 30):";
            // 
            // WidthSelector
            // 
            this.WidthSelector.AutoSize = true;
            this.WidthSelector.Enabled = false;
            this.WidthSelector.Location = new System.Drawing.Point(191, 123);
            this.WidthSelector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WidthSelector.Name = "WidthSelector";
            this.WidthSelector.Size = new System.Drawing.Size(99, 17);
            this.WidthSelector.TabIndex = 5;
            this.WidthSelector.Text = "Width (9 - 30):";
            // 
            // MinesSelector
            // 
            this.MinesSelector.AutoSize = true;
            this.MinesSelector.Enabled = false;
            this.MinesSelector.Location = new System.Drawing.Point(185, 160);
            this.MinesSelector.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinesSelector.Name = "MinesSelector";
            this.MinesSelector.Size = new System.Drawing.Size(116, 17);
            this.MinesSelector.TabIndex = 6;
            this.MinesSelector.Text = "Mines (10 - 841):";
            // 
            // Levels
            // 
            this.Levels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Levels.Controls.Add(this.MinesNumber);
            this.Levels.Controls.Add(this.WidthNumber);
            this.Levels.Controls.Add(this.HeightNumber);
            this.Levels.Controls.Add(this.Novice);
            this.Levels.Controls.Add(this.MinesSelector);
            this.Levels.Controls.Add(this.Intermediate);
            this.Levels.Controls.Add(this.WidthSelector);
            this.Levels.Controls.Add(this.Expert);
            this.Levels.Controls.Add(this.HeightSelector);
            this.Levels.Controls.Add(this.Custom);
            this.Levels.Location = new System.Drawing.Point(16, 15);
            this.Levels.Margin = new System.Windows.Forms.Padding(4);
            this.Levels.Name = "Levels";
            this.Levels.Padding = new System.Windows.Forms.Padding(4);
            this.Levels.Size = new System.Drawing.Size(393, 219);
            this.Levels.TabIndex = 7;
            this.Levels.TabStop = false;
            this.Levels.Text = "Levels";
            // 
            // MinesNumber
            // 
            this.MinesNumber.Enabled = false;
            this.MinesNumber.Location = new System.Drawing.Point(304, 159);
            this.MinesNumber.Margin = new System.Windows.Forms.Padding(4);
            this.MinesNumber.Maximum = new decimal(new int[] {
            841,
            0,
            0,
            0});
            this.MinesNumber.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MinesNumber.Name = "MinesNumber";
            this.MinesNumber.Size = new System.Drawing.Size(64, 22);
            this.MinesNumber.TabIndex = 9;
            this.MinesNumber.TabStop = false;
            this.MinesNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // WidthNumber
            // 
            this.WidthNumber.Enabled = false;
            this.WidthNumber.Location = new System.Drawing.Point(304, 122);
            this.WidthNumber.Margin = new System.Windows.Forms.Padding(4);
            this.WidthNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.WidthNumber.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.WidthNumber.Name = "WidthNumber";
            this.WidthNumber.Size = new System.Drawing.Size(64, 22);
            this.WidthNumber.TabIndex = 8;
            this.WidthNumber.TabStop = false;
            this.WidthNumber.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // HeightNumber
            // 
            this.HeightNumber.Enabled = false;
            this.HeightNumber.Location = new System.Drawing.Point(304, 82);
            this.HeightNumber.Margin = new System.Windows.Forms.Padding(4);
            this.HeightNumber.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.HeightNumber.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.HeightNumber.Name = "HeightNumber";
            this.HeightNumber.Size = new System.Drawing.Size(64, 22);
            this.HeightNumber.TabIndex = 7;
            this.HeightNumber.TabStop = false;
            this.HeightNumber.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(223, 241);
            this.Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(115, 27);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(96, 241);
            this.OK.Margin = new System.Windows.Forms.Padding(4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(115, 27);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Options
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(423, 268);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Levels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 315);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 315);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Levels.ResumeLayout(false);
            this.Levels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Novice;
        private System.Windows.Forms.RadioButton Intermediate;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.RadioButton Custom;
        private System.Windows.Forms.Label HeightSelector;
        private System.Windows.Forms.Label WidthSelector;
        private System.Windows.Forms.Label MinesSelector;
        private System.Windows.Forms.GroupBox Levels;
        private System.Windows.Forms.NumericUpDown MinesNumber;
        private System.Windows.Forms.NumericUpDown WidthNumber;
        private System.Windows.Forms.NumericUpDown HeightNumber;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
    }
}