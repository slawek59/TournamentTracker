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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            headerLabel = new Label();
            loadExistingTournamentDropDown = new ComboBox();
            loadExistingTournamentLabel = new Label();
            createTournamentButton = new Button();
            loadTournamentButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Navy;
            headerLabel.Location = new Point(272, 37);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(553, 74);
            headerLabel.TabIndex = 3;
            headerLabel.Text = "Tournament Dashbord";
            // 
            // loadExistingTournamentDropDown
            // 
            loadExistingTournamentDropDown.BackColor = SystemColors.Menu;
            loadExistingTournamentDropDown.FormattingEnabled = true;
            loadExistingTournamentDropDown.Location = new Point(324, 223);
            loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            loadExistingTournamentDropDown.Size = new Size(448, 53);
            loadExistingTournamentDropDown.TabIndex = 16;
            // 
            // loadExistingTournamentLabel
            // 
            loadExistingTournamentLabel.AutoSize = true;
            loadExistingTournamentLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            loadExistingTournamentLabel.ForeColor = Color.Navy;
            loadExistingTournamentLabel.Location = new Point(324, 150);
            loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            loadExistingTournamentLabel.Size = new Size(448, 54);
            loadExistingTournamentLabel.TabIndex = 15;
            loadExistingTournamentLabel.Text = "Load Existing Tournament";
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
            createTournamentButton.Location = new Point(338, 431);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(420, 98);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = false;
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.BackColor = SystemColors.ControlLight;
            loadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            loadTournamentButton.FlatAppearance.BorderSize = 5;
            loadTournamentButton.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            loadTournamentButton.FlatAppearance.MouseOverBackColor = Color.Bisque;
            loadTournamentButton.FlatStyle = FlatStyle.Flat;
            loadTournamentButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            loadTournamentButton.ForeColor = Color.Navy;
            loadTournamentButton.Location = new Point(338, 295);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(420, 67);
            loadTournamentButton.TabIndex = 27;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashbordForm
            // 
            AutoScaleDimensions = new SizeF(17F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1044, 591);
            Controls.Add(loadTournamentButton);
            Controls.Add(createTournamentButton);
            Controls.Add(loadExistingTournamentDropDown);
            Controls.Add(loadExistingTournamentLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "TournamentDashbordForm";
            Text = "Tournament Dashbord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private ComboBox loadExistingTournamentDropDown;
        private Label loadExistingTournamentLabel;
        private Button createTournamentButton;
        private Button loadTournamentButton;
    }
}