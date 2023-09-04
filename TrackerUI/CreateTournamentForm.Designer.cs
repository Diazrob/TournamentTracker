namespace TrackerUI
{
    partial class CreateTournamentForm
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
            createTournamentLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentNameValue = new TextBox();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamComboBox = new ComboBox();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersLabel = new Label();
            tournamentTeamsListBox = new ListBox();
            removeSelectedTeamButton = new Button();
            removeSelectedPrizeButton = new Button();
            prizesListBox = new ListBox();
            prizesLabel = new Label();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentLabel.Location = new Point(20, 19);
            createTournamentLabel.Margin = new Padding(2, 0, 2, 0);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(219, 32);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(20, 81);
            tournamentNameLabel.Margin = new Padding(2, 0, 2, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(168, 25);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameValue.Location = new Point(20, 109);
            tournamentNameValue.Margin = new Padding(2);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(228, 32);
            tournamentNameValue.TabIndex = 8;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(20, 161);
            entryFeeLabel.Margin = new Padding(2, 0, 2, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(89, 25);
            entryFeeLabel.TabIndex = 9;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeValue.Location = new Point(121, 158);
            entryFeeValue.Margin = new Padding(2);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(128, 32);
            entryFeeValue.TabIndex = 10;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(20, 224);
            selectTeamLabel.Margin = new Padding(2, 0, 2, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(111, 25);
            selectTeamLabel.TabIndex = 11;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamComboBox
            // 
            selectTeamComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamComboBox.FormattingEnabled = true;
            selectTeamComboBox.Location = new Point(20, 258);
            selectTeamComboBox.Margin = new Padding(2);
            selectTeamComboBox.Name = "selectTeamComboBox";
            selectTeamComboBox.Size = new Size(228, 33);
            selectTeamComboBox.TabIndex = 12;
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Location = new Point(162, 228);
            createNewTeamLinkLabel.Margin = new Padding(2, 0, 2, 0);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(86, 20);
            createNewTeamLinkLabel.TabIndex = 13;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "Create New";
            createNewTeamLinkLabel.LinkClicked += createNewTeamLinkLabel_LinkClicked;
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(81, 308);
            addTeamButton.Margin = new Padding(2);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(102, 42);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += addTeamButton_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(81, 369);
            createPrizeButton.Margin = new Padding(2);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(102, 42);
            createPrizeButton.TabIndex = 15;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(315, 75);
            tournamentPlayersLabel.Margin = new Padding(2, 0, 2, 0);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(141, 25);
            tournamentPlayersLabel.TabIndex = 16;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // tournamentTeamsListBox
            // 
            tournamentTeamsListBox.FormattingEnabled = true;
            tournamentTeamsListBox.ItemHeight = 20;
            tournamentTeamsListBox.Location = new Point(315, 114);
            tournamentTeamsListBox.Margin = new Padding(2);
            tournamentTeamsListBox.Name = "tournamentTeamsListBox";
            tournamentTeamsListBox.Size = new Size(267, 124);
            tournamentTeamsListBox.TabIndex = 17;
            // 
            // removeSelectedTeamButton
            // 
            removeSelectedTeamButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedTeamButton.FlatStyle = FlatStyle.Flat;
            removeSelectedTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedTeamButton.Location = new Point(596, 144);
            removeSelectedTeamButton.Margin = new Padding(2);
            removeSelectedTeamButton.Name = "removeSelectedTeamButton";
            removeSelectedTeamButton.Size = new Size(102, 63);
            removeSelectedTeamButton.TabIndex = 18;
            removeSelectedTeamButton.Text = "Remove Selected";
            removeSelectedTeamButton.UseVisualStyleBackColor = true;
            removeSelectedTeamButton.Click += removeSelectedTeamButton_Click;
            // 
            // removeSelectedPrizeButton
            // 
            removeSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            removeSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedPrizeButton.Location = new Point(596, 319);
            removeSelectedPrizeButton.Margin = new Padding(2);
            removeSelectedPrizeButton.Name = "removeSelectedPrizeButton";
            removeSelectedPrizeButton.Size = new Size(102, 63);
            removeSelectedPrizeButton.TabIndex = 21;
            removeSelectedPrizeButton.Text = "Remove Selected";
            removeSelectedPrizeButton.UseVisualStyleBackColor = true;
            removeSelectedPrizeButton.Click += removeSelectedPrizeButton_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 20;
            prizesListBox.Location = new Point(315, 289);
            prizesListBox.Margin = new Padding(2);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(267, 124);
            prizesListBox.TabIndex = 20;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(315, 251);
            prizesLabel.Margin = new Padding(2, 0, 2, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(62, 25);
            prizesLabel.TabIndex = 19;
            prizesLabel.Text = "Prizes";
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(261, 432);
            createTournamentButton.Margin = new Padding(2);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(180, 42);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += createTournamentButton_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(713, 494);
            Controls.Add(createTournamentButton);
            Controls.Add(removeSelectedPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(prizesLabel);
            Controls.Add(removeSelectedTeamButton);
            Controls.Add(tournamentTeamsListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamComboBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Margin = new Padding(2);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentNameValue;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamComboBox;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label tournamentPlayersLabel;
        private ListBox tournamentTeamsListBox;
        private Button removeSelectedTeamButton;
        private Button removeSelectedPrizeButton;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button createTournamentButton;
    }
}