namespace TrackerUI
{
    partial class CreateTeamForm
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
            addMemberButton = new Button();
            selectTeamMemberComboBox = new ComboBox();
            selectTeamMemberLabel = new Label();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            teamNameValue = new TextBox();
            addNewMemberGroupBox = new GroupBox();
            firstNameLabel = new Label();
            firstNameValue = new TextBox();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            cellphoneValue = new TextBox();
            cellPhoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedTeamMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            addMemberButton.Location = new Point(131, 393);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(233, 68);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberComboBox
            // 
            selectTeamMemberComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberComboBox.FormattingEnabled = true;
            selectTeamMemberComboBox.Location = new Point(33, 323);
            selectTeamMemberComboBox.Margin = new Padding(4);
            selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            selectTeamMemberComboBox.Size = new Size(454, 48);
            selectTeamMemberComboBox.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(33, 267);
            selectTeamMemberLabel.Margin = new Padding(4, 0, 4, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(296, 41);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(33, 130);
            teamNameLabel.Margin = new Padding(4, 0, 4, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(175, 41);
            teamNameLabel.TabIndex = 16;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(33, 31);
            createTeamLabel.Margin = new Padding(4, 0, 4, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(229, 51);
            createTeamLabel.TabIndex = 15;
            createTeamLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            teamNameValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameValue.Location = new Point(33, 184);
            teamNameValue.Margin = new Padding(4);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(454, 47);
            teamNameValue.TabIndex = 20;
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellPhoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.ForeColor = Color.FromArgb(51, 153, 255);
            addNewMemberGroupBox.Location = new Point(33, 499);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(454, 393);
            addNewMemberGroupBox.TabIndex = 21;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(21, 59);
            firstNameLabel.Margin = new Padding(4, 0, 4, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValue.Location = new Point(158, 59);
            firstNameValue.Margin = new Padding(4);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(273, 39);
            firstNameValue.TabIndex = 22;
            // 
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValue.Location = new Point(159, 122);
            lastNameValue.Margin = new Padding(4);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(273, 39);
            lastNameValue.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(22, 122);
            lastNameLabel.Margin = new Padding(4, 0, 4, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Last Name";
            // 
            // cellphoneValue
            // 
            cellphoneValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneValue.Location = new Point(159, 244);
            cellphoneValue.Margin = new Padding(4);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(273, 39);
            cellphoneValue.TabIndex = 27;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellPhoneLabel.Location = new Point(22, 244);
            cellPhoneLabel.Margin = new Padding(4, 0, 4, 0);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(123, 32);
            cellPhoneLabel.TabIndex = 28;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailValue.Location = new Point(158, 181);
            emailValue.Margin = new Padding(4);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(273, 39);
            emailValue.TabIndex = 25;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(21, 181);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 32);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(98, 307);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(233, 68);
            createMemberButton.TabIndex = 22;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 32;
            teamMembersListBox.Location = new Point(569, 184);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(497, 708);
            teamMembersListBox.TabIndex = 22;
            // 
            // deleteSelectedTeamMemberButton
            // 
            deleteSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeamMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedTeamMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedTeamMemberButton.Location = new Point(1093, 489);
            deleteSelectedTeamMemberButton.Name = "deleteSelectedTeamMemberButton";
            deleteSelectedTeamMemberButton.Size = new Size(165, 101);
            deleteSelectedTeamMemberButton.TabIndex = 23;
            deleteSelectedTeamMemberButton.Text = "Delete Selected";
            deleteSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            deleteSelectedTeamMemberButton.Click += deleteSelectedTeamMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(487, 927);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(292, 68);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1287, 1020);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(teamNameValue);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberComboBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Name = "CreateTeamForm";
            Text = "CreateTeamForm";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addMemberButton;
        private ComboBox selectTeamMemberComboBox;
        private Label selectTeamMemberLabel;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private TextBox teamNameValue;
        private GroupBox addNewMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private TextBox cellphoneValue;
        private Label cellPhoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedTeamMemberButton;
        private Button createTeamButton;
    }
}