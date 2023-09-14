namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            headerLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Navy;
            headerLabel.Location = new Point(27, 32);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(322, 74);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = Color.Navy;
            tournamentName.Location = new Point(324, 32);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(236, 74);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<name>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.Navy;
            roundLabel.Location = new Point(27, 129);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(131, 54);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.BackColor = SystemColors.Menu;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(151, 130);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(391, 53);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckBox.ForeColor = Color.Navy;
            unplayedOnlyCheckBox.Location = new Point(151, 204);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(289, 58);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BackColor = SystemColors.Menu;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 45;
            matchupListBox.Location = new Point(27, 272);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(515, 274);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneName.ForeColor = Color.Navy;
            teamOneName.Location = new Point(568, 190);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(234, 54);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = Color.Navy;
            teamOneScoreLabel.Location = new Point(568, 255);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(115, 54);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.BackColor = SystemColors.Menu;
            teamOneScoreValue.Location = new Point(701, 259);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(150, 50);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.BackColor = SystemColors.Menu;
            teamTwoScoreValue.Location = new Point(701, 459);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(150, 50);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.Navy;
            teamTwoScoreLabel.Location = new Point(568, 455);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(115, 54);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoName.ForeColor = Color.Navy;
            teamTwoName.Location = new Point(568, 390);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(232, 54);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = Color.Navy;
            versusLabel.Location = new Point(641, 336);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(98, 54);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.BackColor = SystemColors.ControlLight;
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.BorderSize = 5;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.Navy;
            scoreButton.Location = new Point(832, 336);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(142, 66);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = false;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(17F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1160, 605);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}