namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            tournamentDashboardLabel = new Label();
            loadExistingTournamentComboBox = new ComboBox();
            loadExistingTournamentLabel = new Label();
            loadTournamentButton = new Button();
            dbCreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentDashboardLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentDashboardLabel.Location = new Point(192, 26);
            tournamentDashboardLabel.Margin = new Padding(4, 0, 4, 0);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(416, 51);
            tournamentDashboardLabel.TabIndex = 16;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentComboBox
            // 
            loadExistingTournamentComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentComboBox.FormattingEnabled = true;
            loadExistingTournamentComboBox.Location = new Point(176, 201);
            loadExistingTournamentComboBox.Margin = new Padding(4);
            loadExistingTournamentComboBox.Name = "loadExistingTournamentComboBox";
            loadExistingTournamentComboBox.Size = new Size(454, 48);
            loadExistingTournamentComboBox.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            loadExistingTournamentLabel.Location = new Point(219, 147);
            loadExistingTournamentLabel.Margin = new Padding(4, 0, 4, 0);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(359, 41);
            loadExistingTournamentLabel.TabIndex = 19;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            loadTournamentButton.Location = new Point(291, 270);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(233, 55);
            loadTournamentButton.TabIndex = 21;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // dbCreateTournamentButton
            // 
            dbCreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            dbCreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            dbCreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            dbCreateTournamentButton.FlatStyle = FlatStyle.Flat;
            dbCreateTournamentButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dbCreateTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            dbCreateTournamentButton.Location = new Point(271, 346);
            dbCreateTournamentButton.Name = "dbCreateTournamentButton";
            dbCreateTournamentButton.Size = new Size(271, 68);
            dbCreateTournamentButton.TabIndex = 22;
            dbCreateTournamentButton.Text = "Create Tournament";
            dbCreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dbCreateTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(loadExistingTournamentComboBox);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(tournamentDashboardLabel);
            Name = "TournamentDashboardForm";
            Text = "TournamentDashboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private ComboBox loadExistingTournamentComboBox;
        private Label loadExistingTournamentLabel;
        private Button loadTournamentButton;
        private Button dbCreateTournamentButton;
    }
}