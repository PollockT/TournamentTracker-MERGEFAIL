namespace TrackerUI
{
    partial class TournamentViewer
    {
        /// <summary>
        ///  Build the UI of the tournament Viewer
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Holds all the component variables and values
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewer));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.unplayedOnlyCheckBox = new System.Windows.Forms.CheckBox();
            this.teamOneNabeLabel = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.teamTwoNameLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentLabel.Location = new System.Drawing.Point(47, 26);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(164, 37);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament:";
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tournamentNameLabel.Location = new System.Drawing.Point(204, 26);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(113, 37);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.roundLabel.Location = new System.Drawing.Point(68, 86);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(94, 37);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(187, 83);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(121, 45);
            this.roundDropDown.TabIndex = 1;
            // 
            // matchupListBox
            // 
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 37;
            this.matchupListBox.Location = new System.Drawing.Point(38, 208);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(327, 300);
            this.matchupListBox.TabIndex = 4;
            // 
            // unplayedOnlyCheckBox
            // 
            this.unplayedOnlyCheckBox.AutoSize = true;
            this.unplayedOnlyCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.unplayedOnlyCheckBox.Location = new System.Drawing.Point(148, 146);
            this.unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            this.unplayedOnlyCheckBox.Size = new System.Drawing.Size(212, 41);
            this.unplayedOnlyCheckBox.TabIndex = 5;
            this.unplayedOnlyCheckBox.Text = "Unplayed Only";
            this.unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamOneNabeLabel
            // 
            this.teamOneNabeLabel.AutoSize = true;
            this.teamOneNabeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneNabeLabel.Location = new System.Drawing.Point(441, 184);
            this.teamOneNabeLabel.Name = "teamOneNabeLabel";
            this.teamOneNabeLabel.Size = new System.Drawing.Size(165, 37);
            this.teamOneNabeLabel.TabIndex = 0;
            this.teamOneNabeLabel.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneScoreLabel.Location = new System.Drawing.Point(371, 224);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamOneScoreLabel.TabIndex = 0;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versusLabel.Location = new System.Drawing.Point(477, 292);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(44, 37);
            this.versusLabel.TabIndex = 0;
            this.versusLabel.Text = "- VS -";
            // 
            // teamTwoNameLabel
            // 
            this.teamTwoNameLabel.AutoSize = true;
            this.teamTwoNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoNameLabel.Location = new System.Drawing.Point(441, 371);
            this.teamTwoNameLabel.Name = "teamTwoNameLabel";
            this.teamTwoNameLabel.Size = new System.Drawing.Size(165, 37);
            this.teamTwoNameLabel.TabIndex = 0;
            this.teamTwoNameLabel.Text = "<team two>";
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(371, 417);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(82, 37);
            this.teamTwoScoreLabel.TabIndex = 0;
            this.teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoScoreTextBox
            // 
            this.teamTwoScoreTextBox.Location = new System.Drawing.Point(467, 417);
            this.teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            this.teamTwoScoreTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamTwoScoreTextBox.TabIndex = 6;
            // 
            // teamOneScoreTextBox
            // 
            this.teamOneScoreTextBox.Location = new System.Drawing.Point(467, 224);
            this.teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            this.teamOneScoreTextBox.Size = new System.Drawing.Size(100, 43);
            this.teamOneScoreTextBox.TabIndex = 7;
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(604, 287);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(134, 52);
            this.scoreButton.TabIndex = 8;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 559);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.teamOneScoreTextBox);
            this.Controls.Add(this.teamTwoScoreTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoNameLabel);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneNabeLabel);
            this.Controls.Add(this.unplayedOnlyCheckBox);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewer";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckBox;
        private System.Windows.Forms.Label teamOneNabeLabel;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Label teamTwoNameLabel;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.TextBox teamTwoScoreTextBox;
        private System.Windows.Forms.TextBox teamOneScoreTextBox;
        private System.Windows.Forms.Button scoreButton;
    }
}

