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
            tournamentValue = new TextBox();
            entryFeeLabel = new Label();
            entryFeeValue = new TextBox();
            selectTeamLabel = new Label();
            selectTeamComboBox = new ComboBox();
            createNewTeamLinkLabel = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            deleteSelectedPlayerButton = new Button();
            deleteSelectedPrizeButton = new Button();
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
            createTournamentLabel.Location = new Point(33, 31);
            createTournamentLabel.Margin = new Padding(4, 0, 4, 0);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(343, 51);
            createTournamentLabel.TabIndex = 1;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(33, 130);
            tournamentNameLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(264, 41);
            tournamentNameLabel.TabIndex = 3;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // tournamentValue
            // 
            tournamentValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentValue.Location = new Point(33, 175);
            tournamentValue.Margin = new Padding(4);
            tournamentValue.Name = "tournamentValue";
            tournamentValue.Size = new Size(368, 47);
            tournamentValue.TabIndex = 8;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(33, 258);
            entryFeeLabel.Margin = new Padding(4, 0, 4, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(140, 41);
            entryFeeLabel.TabIndex = 9;
            entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeValue.Location = new Point(196, 252);
            entryFeeValue.Margin = new Padding(4);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(205, 47);
            entryFeeValue.TabIndex = 10;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(33, 359);
            selectTeamLabel.Margin = new Padding(4, 0, 4, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(175, 41);
            selectTeamLabel.TabIndex = 11;
            selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamComboBox
            // 
            selectTeamComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamComboBox.FormattingEnabled = true;
            selectTeamComboBox.Location = new Point(33, 413);
            selectTeamComboBox.Margin = new Padding(4);
            selectTeamComboBox.Name = "selectTeamComboBox";
            selectTeamComboBox.Size = new Size(368, 48);
            selectTeamComboBox.TabIndex = 12;
            // 
            // createNewTeamLinkLabel
            // 
            createNewTeamLinkLabel.AutoSize = true;
            createNewTeamLinkLabel.Location = new Point(263, 365);
            createNewTeamLinkLabel.Name = "createNewTeamLinkLabel";
            createNewTeamLinkLabel.Size = new Size(138, 32);
            createNewTeamLinkLabel.TabIndex = 13;
            createNewTeamLinkLabel.TabStop = true;
            createNewTeamLinkLabel.Text = "Create New";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(132, 493);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(165, 68);
            addTeamButton.TabIndex = 14;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(132, 591);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(165, 68);
            createPrizeButton.TabIndex = 15;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentPlayersLabel.Location = new Point(512, 120);
            tournamentPlayersLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(222, 41);
            tournamentPlayersLabel.TabIndex = 16;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 32;
            tournamentPlayersListBox.Location = new Point(512, 182);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(432, 196);
            tournamentPlayersListBox.TabIndex = 17;
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPlayerButton.Location = new Point(969, 230);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(165, 101);
            deleteSelectedPlayerButton.TabIndex = 18;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(969, 511);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(165, 101);
            deleteSelectedPrizeButton.TabIndex = 21;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 32;
            prizesListBox.Location = new Point(512, 463);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(432, 196);
            prizesListBox.TabIndex = 20;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(512, 401);
            prizesLabel.Margin = new Padding(4, 0, 4, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(95, 41);
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
            createTournamentButton.Location = new Point(424, 691);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(292, 68);
            createTournamentButton.TabIndex = 22;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1159, 791);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(prizesLabel);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLinkLabel);
            Controls.Add(selectTeamComboBox);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentValue;
        private Label entryFeeLabel;
        private TextBox entryFeeValue;
        private Label selectTeamLabel;
        private ComboBox selectTeamComboBox;
        private LinkLabel createNewTeamLinkLabel;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label tournamentPlayersLabel;
        private ListBox tournamentPlayersListBox;
        private Button deleteSelectedPlayerButton;
        private Button deleteSelectedPrizeButton;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button createTournamentButton;
    }
}