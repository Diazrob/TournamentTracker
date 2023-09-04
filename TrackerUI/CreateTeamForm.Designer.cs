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
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellPhoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedTeamMemberButton = new Button();
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
            addMemberButton.Location = new Point(81, 246);
            addMemberButton.Margin = new Padding(2);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(143, 42);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberComboBox
            // 
            selectTeamMemberComboBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberComboBox.FormattingEnabled = true;
            selectTeamMemberComboBox.Location = new Point(20, 202);
            selectTeamMemberComboBox.Margin = new Padding(2);
            selectTeamMemberComboBox.Name = "selectTeamMemberComboBox";
            selectTeamMemberComboBox.Size = new Size(281, 33);
            selectTeamMemberComboBox.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamMemberLabel.Location = new Point(20, 167);
            selectTeamMemberLabel.Margin = new Padding(2, 0, 2, 0);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(187, 25);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamNameLabel.Location = new Point(20, 81);
            teamNameLabel.Margin = new Padding(2, 0, 2, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(111, 25);
            teamNameLabel.TabIndex = 16;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamLabel.Location = new Point(20, 19);
            createTeamLabel.Margin = new Padding(2, 0, 2, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(147, 32);
            createTeamLabel.TabIndex = 15;
            createTeamLabel.Text = "Create Team";
            // 
            // teamNameValue
            // 
            teamNameValue.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameValue.Location = new Point(20, 115);
            teamNameValue.Margin = new Padding(2);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(281, 32);
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
            addNewMemberGroupBox.Location = new Point(20, 312);
            addNewMemberGroupBox.Margin = new Padding(2);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Padding = new Padding(2);
            addNewMemberGroupBox.Size = new Size(279, 246);
            addNewMemberGroupBox.TabIndex = 21;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            createMemberButton.Location = new Point(60, 192);
            createMemberButton.Margin = new Padding(2);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(143, 42);
            createMemberButton.TabIndex = 22;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneValue.Location = new Point(98, 152);
            cellphoneValue.Margin = new Padding(2);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(170, 27);
            cellphoneValue.TabIndex = 27;
            // 
            // cellPhoneLabel
            // 
            cellPhoneLabel.AutoSize = true;
            cellPhoneLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cellPhoneLabel.ForeColor = Color.FromArgb(51, 153, 255);
            cellPhoneLabel.Location = new Point(14, 152);
            cellPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            cellPhoneLabel.Name = "cellPhoneLabel";
            cellPhoneLabel.Size = new Size(76, 20);
            cellPhoneLabel.TabIndex = 28;
            cellPhoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailValue.Location = new Point(97, 113);
            emailValue.Margin = new Padding(2);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(170, 27);
            emailValue.TabIndex = 25;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            emailLabel.Location = new Point(13, 113);
            emailLabel.Margin = new Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 26;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameValue.Location = new Point(98, 76);
            lastNameValue.Margin = new Padding(2);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(170, 27);
            lastNameValue.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            lastNameLabel.Location = new Point(14, 76);
            lastNameLabel.Margin = new Padding(2, 0, 2, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameValue.Location = new Point(97, 37);
            firstNameValue.Margin = new Padding(2);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(170, 27);
            firstNameValue.TabIndex = 22;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            firstNameLabel.Location = new Point(13, 37);
            firstNameLabel.Margin = new Padding(2, 0, 2, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 22;
            firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 20;
            teamMembersListBox.Location = new Point(350, 115);
            teamMembersListBox.Margin = new Padding(2);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(307, 444);
            teamMembersListBox.TabIndex = 22;
            // 
            // removeSelectedTeamMemberButton
            // 
            removeSelectedTeamMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedTeamMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedTeamMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedTeamMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedTeamMemberButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            removeSelectedTeamMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            removeSelectedTeamMemberButton.Location = new Point(673, 306);
            removeSelectedTeamMemberButton.Margin = new Padding(2);
            removeSelectedTeamMemberButton.Name = "removeSelectedTeamMemberButton";
            removeSelectedTeamMemberButton.Size = new Size(102, 63);
            removeSelectedTeamMemberButton.TabIndex = 23;
            removeSelectedTeamMemberButton.Text = "Remove Selected";
            removeSelectedTeamMemberButton.UseVisualStyleBackColor = true;
            removeSelectedTeamMemberButton.Click += removeSelectedTeamMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTeamButton.Location = new Point(300, 579);
            createTeamButton.Margin = new Padding(2);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(180, 42);
            createTeamButton.TabIndex = 24;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            createTeamButton.Click += createTeamButton_Click;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 638);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedTeamMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(teamNameValue);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberComboBox);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Margin = new Padding(2);
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
        private Button removeSelectedTeamMemberButton;
        private Button createTeamButton;
    }
}