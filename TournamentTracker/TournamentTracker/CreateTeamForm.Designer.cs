using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            teamNameValue = new TextBox();
            teamNameLabel = new Label();
            headerLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            addNewMemberGroupBox = new GroupBox();
            firstNameValue = new TextBox();
            firstNameLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            createMemberButton = new Button();
            teamMembersListBox = new ListBox();
            deleteSelectedMemberButton = new Button();
            createTeamButton = new Button();
            addNewMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValue
            // 
            teamNameValue.BackColor = SystemColors.Menu;
            teamNameValue.Location = new Point(35, 172);
            teamNameValue.Name = "teamNameValue";
            teamNameValue.Size = new Size(499, 50);
            teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamNameLabel.ForeColor = Color.Navy;
            teamNameLabel.Location = new Point(35, 106);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(222, 54);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Navy;
            headerLabel.Location = new Point(22, 20);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(322, 74);
            headerLabel.TabIndex = 11;
            headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.BackColor = SystemColors.ControlLight;
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.BorderSize = 5;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addMemberButton.ForeColor = Color.Navy;
            addMemberButton.Location = new Point(161, 396);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(233, 66);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = false;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.BackColor = SystemColors.Menu;
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(35, 316);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(499, 53);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamMemberLabel.ForeColor = Color.Navy;
            selectTeamMemberLabel.Location = new Point(38, 250);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(371, 54);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // addNewMemberGroupBox
            // 
            addNewMemberGroupBox.Controls.Add(createMemberButton);
            addNewMemberGroupBox.Controls.Add(cellphoneValue);
            addNewMemberGroupBox.Controls.Add(cellphoneLabel);
            addNewMemberGroupBox.Controls.Add(emailValue);
            addNewMemberGroupBox.Controls.Add(emailLabel);
            addNewMemberGroupBox.Controls.Add(lastNameValue);
            addNewMemberGroupBox.Controls.Add(lastNameLabel);
            addNewMemberGroupBox.Controls.Add(firstNameValue);
            addNewMemberGroupBox.Controls.Add(firstNameLabel);
            addNewMemberGroupBox.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            addNewMemberGroupBox.ForeColor = Color.SteelBlue;
            addNewMemberGroupBox.Location = new Point(49, 482);
            addNewMemberGroupBox.Name = "addNewMemberGroupBox";
            addNewMemberGroupBox.Size = new Size(511, 448);
            addNewMemberGroupBox.TabIndex = 20;
            addNewMemberGroupBox.TabStop = false;
            addNewMemberGroupBox.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            firstNameValue.BackColor = SystemColors.Menu;
            firstNameValue.Location = new Point(238, 60);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(247, 61);
            firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.Navy;
            firstNameLabel.Location = new Point(12, 56);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(203, 54);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            lastNameValue.BackColor = SystemColors.Menu;
            lastNameValue.Location = new Point(238, 130);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(247, 61);
            lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.Navy;
            lastNameLabel.Location = new Point(12, 126);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(201, 54);
            lastNameLabel.TabIndex = 11;
            lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            emailValue.BackColor = SystemColors.Menu;
            emailValue.Location = new Point(238, 202);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(247, 61);
            emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.Navy;
            emailLabel.Location = new Point(12, 198);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(112, 54);
            emailLabel.TabIndex = 13;
            emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            cellphoneValue.BackColor = SystemColors.Menu;
            cellphoneValue.Location = new Point(238, 278);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(247, 61);
            cellphoneValue.TabIndex = 16;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cellphoneLabel.ForeColor = Color.Navy;
            cellphoneLabel.Location = new Point(12, 274);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(190, 54);
            cellphoneLabel.TabIndex = 15;
            cellphoneLabel.Text = "Cellphone";
            // 
            // createMemberButton
            // 
            createMemberButton.BackColor = SystemColors.ControlLight;
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.BorderSize = 5;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createMemberButton.ForeColor = Color.Navy;
            createMemberButton.Location = new Point(95, 361);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(278, 64);
            createMemberButton.TabIndex = 21;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = false;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.BackColor = SystemColors.Menu;
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 45;
            teamMembersListBox.Location = new Point(630, 172);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(443, 679);
            teamMembersListBox.TabIndex = 21;
            teamMembersListBox.SelectedIndexChanged += tournamentPlayersListBox_SelectedIndexChanged;
            // 
            // deleteSelectedMemberButton
            // 
            deleteSelectedMemberButton.BackColor = SystemColors.ControlLight;
            deleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedMemberButton.FlatAppearance.BorderSize = 5;
            deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            deleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedMemberButton.ForeColor = Color.Navy;
            deleteSelectedMemberButton.Location = new Point(1119, 454);
            deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            deleteSelectedMemberButton.Size = new Size(163, 112);
            deleteSelectedMemberButton.TabIndex = 25;
            deleteSelectedMemberButton.Text = "Delete Selected";
            deleteSelectedMemberButton.UseVisualStyleBackColor = false;
            // 
            // createTeamButton
            // 
            createTeamButton.BackColor = SystemColors.ControlLight;
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.BorderSize = 5;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createTeamButton.ForeColor = Color.Navy;
            createTeamButton.Location = new Point(428, 949);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(420, 75);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(17F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1319, 1050);
            Controls.Add(createTeamButton);
            Controls.Add(deleteSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(addNewMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValue);
            Controls.Add(teamNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Navy;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreateTeamForm";
            Text = "Create Team";
            addNewMemberGroupBox.ResumeLayout(false);
            addNewMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox addNewMemberGroupBox;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}