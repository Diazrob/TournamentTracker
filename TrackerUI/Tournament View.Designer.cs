namespace TrackerUI
{
    partial class TournamentViewForm
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
            tournamentLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundComboBox = new ComboBox();
            unplayedCheckBox = new CheckBox();
            scoreLabel = new Label();
            teamOnelabel = new Label();
            teamOneScoreTextBox = new TextBox();
            teamTwoScoreTextBox = new TextBox();
            teamTwoLabel = new Label();
            versusLabel = new Label();
            matchupListBox = new ListBox();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentLabel.Location = new Point(33, 31);
            tournamentLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(232, 51);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentName.Location = new Point(257, 31);
            tournamentName.Margin = new Padding(4, 0, 4, 0);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(160, 51);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(33, 137);
            roundLabel.Margin = new Padding(4, 0, 4, 0);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(112, 41);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round:";
            // 
            // roundComboBox
            // 
            roundComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            roundComboBox.FormattingEnabled = true;
            roundComboBox.Location = new Point(257, 127);
            roundComboBox.Margin = new Padding(4);
            roundComboBox.Name = "roundComboBox";
            roundComboBox.Size = new Size(297, 48);
            roundComboBox.TabIndex = 3;
            // 
            // unplayedCheckBox
            // 
            unplayedCheckBox.AutoSize = true;
            unplayedCheckBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            unplayedCheckBox.Location = new Point(257, 223);
            unplayedCheckBox.Margin = new Padding(4);
            unplayedCheckBox.Name = "unplayedCheckBox";
            unplayedCheckBox.Size = new Size(247, 45);
            unplayedCheckBox.TabIndex = 4;
            unplayedCheckBox.Text = "Unplayed Only";
            unplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            scoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            scoreLabel.Location = new Point(257, 300);
            scoreLabel.Margin = new Padding(4, 0, 4, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(105, 41);
            scoreLabel.TabIndex = 5;
            scoreLabel.Text = "Scores";
            // 
            // teamOnelabel
            // 
            teamOnelabel.AutoSize = true;
            teamOnelabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamOnelabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOnelabel.Location = new Point(33, 360);
            teamOnelabel.Margin = new Padding(4, 0, 4, 0);
            teamOnelabel.Name = "teamOnelabel";
            teamOnelabel.Size = new Size(186, 41);
            teamOnelabel.TabIndex = 6;
            teamOnelabel.Text = "<team one>";
            // 
            // teamOneScoreTextBox
            // 
            teamOneScoreTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreTextBox.Location = new Point(419, 360);
            teamOneScoreTextBox.Margin = new Padding(4);
            teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            teamOneScoreTextBox.Size = new Size(134, 47);
            teamOneScoreTextBox.TabIndex = 7;
            // 
            // teamTwoScoreTextBox
            // 
            teamTwoScoreTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreTextBox.Location = new Point(419, 472);
            teamTwoScoreTextBox.Margin = new Padding(4);
            teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            teamTwoScoreTextBox.Size = new Size(134, 47);
            teamTwoScoreTextBox.TabIndex = 9;
            // 
            // teamTwoLabel
            // 
            teamTwoLabel.AutoSize = true;
            teamTwoLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoLabel.Location = new Point(33, 472);
            teamTwoLabel.Margin = new Padding(4, 0, 4, 0);
            teamTwoLabel.Name = "teamTwoLabel";
            teamTwoLabel.Size = new Size(185, 41);
            teamTwoLabel.TabIndex = 8;
            teamTwoLabel.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            versusLabel.Location = new Point(257, 412);
            versusLabel.Margin = new Padding(4, 0, 4, 0);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(77, 41);
            versusLabel.TabIndex = 10;
            versusLabel.Text = "-VS-";
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 40;
            matchupListBox.Location = new Point(619, 127);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(500, 404);
            matchupListBox.TabIndex = 11;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(1154, 300);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(134, 68);
            scoreButton.TabIndex = 12;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1322, 579);
            Controls.Add(scoreButton);
            Controls.Add(matchupListBox);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreTextBox);
            Controls.Add(teamTwoLabel);
            Controls.Add(teamOneScoreTextBox);
            Controls.Add(teamOnelabel);
            Controls.Add(scoreLabel);
            Controls.Add(unplayedCheckBox);
            Controls.Add(roundComboBox);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "TournamentViewForm";
            Text = "Tournament Viewer";
            Load += tournamentViewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundComboBox;
        private CheckBox unplayedCheckBox;
        private Label scoreLabel;
        private Label teamOnelabel;
        private TextBox teamOneScoreTextBox;
        private TextBox teamTwoScoreTextBox;
        private Label teamTwoLabel;
        private Label versusLabel;
        private ListBox matchupListBox;
        private Button scoreButton;
    }
}