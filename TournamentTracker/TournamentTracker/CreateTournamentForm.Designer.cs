using System.Drawing;
using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            headerLabel = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayersListBox = new ListBox();
            tournamentPlayersLabel = new Label();
            deleteSelectedPrizeButton = new Button();
            prizesLabel = new Label();
            prizesListBox = new ListBox();
            deleteSelectedPlayersButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Navy;
            headerLabel.Location = new Point(12, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(478, 74);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.BackColor = SystemColors.Menu;
            tournamentNameValue.Location = new Point(25, 161);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(442, 50);
            tournamentNameValue.TabIndex = 10;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentNameLabel.ForeColor = Color.Navy;
            tournamentNameLabel.Location = new Point(25, 95);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(332, 54);
            tournamentNameLabel.TabIndex = 9;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.BackColor = SystemColors.Menu;
            entryFeeValue.Location = new Point(285, 235);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(150, 50);
            entryFeeValue.TabIndex = 12;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            entryFeeLabel.ForeColor = Color.Navy;
            entryFeeLabel.Location = new Point(48, 231);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(179, 54);
            entryFeeLabel.TabIndex = 11;
            entryFeeLabel.Text = "Entry Fee";
            entryFeeLabel.Click += teamOneScoreLabel_Click;
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.BackColor = SystemColors.Menu;
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(25, 369);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(442, 53);
            selectTeamDropDown.TabIndex = 14;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            selectTeamLabel.ForeColor = Color.Navy;
            selectTeamLabel.Location = new Point(48, 312);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(219, 54);
            selectTeamLabel.TabIndex = 13;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(285, 319);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(166, 45);
            createNewTeamLink.TabIndex = 15;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.BackColor = SystemColors.ControlLight;
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.BorderSize = 5;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            addTeamButton.ForeColor = Color.Navy;
            addTeamButton.Location = new Point(124, 442);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(233, 66);
            addTeamButton.TabIndex = 16;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = false;
            // 
            // createPrizeButton
            // 
            createPrizeButton.BackColor = SystemColors.ControlLight;
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.BorderSize = 5;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createPrizeButton.ForeColor = Color.Navy;
            createPrizeButton.Location = new Point(124, 520);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(233, 66);
            createPrizeButton.TabIndex = 17;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.BackColor = SystemColors.Menu;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 45;
            tournamentPlayersListBox.Location = new Point(523, 119);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(388, 184);
            tournamentPlayersListBox.TabIndex = 18;
            // 
            // tournamentPlayersLabel
            // 
            tournamentPlayersLabel.AutoSize = true;
            tournamentPlayersLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentPlayersLabel.ForeColor = Color.Navy;
            tournamentPlayersLabel.Location = new Point(532, 53);
            tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            tournamentPlayersLabel.Size = new Size(280, 54);
            tournamentPlayersLabel.TabIndex = 19;
            tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.BackColor = SystemColors.ControlLight;
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.BorderSize = 5;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrizeButton.ForeColor = Color.Navy;
            deleteSelectedPrizeButton.Location = new Point(931, 432);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(163, 112);
            deleteSelectedPrizeButton.TabIndex = 23;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizesLabel.ForeColor = Color.Navy;
            prizesLabel.Location = new Point(532, 333);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(280, 54);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Teams / Players";
            // 
            // prizesListBox
            // 
            prizesListBox.BackColor = SystemColors.Menu;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 45;
            prizesListBox.Location = new Point(523, 399);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(388, 184);
            prizesListBox.TabIndex = 21;
            // 
            // deleteSelectedPlayersButton
            // 
            deleteSelectedPlayersButton.BackColor = SystemColors.ControlLight;
            deleteSelectedPlayersButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayersButton.FlatAppearance.BorderSize = 5;
            deleteSelectedPlayersButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            deleteSelectedPlayersButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            deleteSelectedPlayersButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayersButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayersButton.ForeColor = Color.Navy;
            deleteSelectedPlayersButton.Location = new Point(931, 162);
            deleteSelectedPlayersButton.Name = "deleteSelectedPlayersButton";
            deleteSelectedPlayersButton.Size = new Size(163, 112);
            deleteSelectedPlayersButton.TabIndex = 24;
            deleteSelectedPlayersButton.Text = "Delete Selected";
            deleteSelectedPlayersButton.UseVisualStyleBackColor = false;
            // 
            // createTournamentButton
            // 
            createTournamentButton.BackColor = SystemColors.ControlLight;
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.BorderSize = 5;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            createTournamentButton.ForeColor = Color.Navy;
            createTournamentButton.Location = new Point(341, 615);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(420, 98);
            createTournamentButton.TabIndex = 25;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(17F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1124, 735);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayersButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesLabel);
            Controls.Add(prizesListBox);
            Controls.Add(tournamentPlayersLabel);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "CreateTournamentForm";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayersListBox;
        private Label tournamentPlayersLabel;
        private Button deleteSelectedPrizeButton;
        private Label prizesLabel;
        private ListBox prizesListBox;
        private Button deleteSelectedPlayersButton;
        private Button createTournamentButton;
    }
}