namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            headerLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.Navy;
            headerLabel.Location = new Point(12, 24);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(313, 74);
            headerLabel.TabIndex = 2;
            headerLabel.Text = "Create Prize";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.BackColor = SystemColors.Menu;
            prizePercentageValue.Location = new Point(352, 445);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(247, 50);
            prizePercentageValue.TabIndex = 24;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizePercentageLabel.ForeColor = Color.Navy;
            prizePercentageLabel.Location = new Point(30, 441);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(301, 54);
            prizePercentageLabel.TabIndex = 23;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.BackColor = SystemColors.Menu;
            prizeAmountValue.Location = new Point(352, 280);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(247, 50);
            prizeAmountValue.TabIndex = 22;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            prizeAmountLabel.ForeColor = Color.Navy;
            prizeAmountLabel.Location = new Point(30, 276);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(250, 54);
            prizeAmountLabel.TabIndex = 21;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.BackColor = SystemColors.Menu;
            placeNameValue.Location = new Point(352, 208);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(247, 50);
            placeNameValue.TabIndex = 20;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNameLabel.ForeColor = Color.Navy;
            placeNameLabel.Location = new Point(30, 204);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(223, 54);
            placeNameLabel.TabIndex = 19;
            placeNameLabel.Text = "Place Name";
            // 
            // placeNumberValue
            // 
            placeNumberValue.BackColor = SystemColors.Menu;
            placeNumberValue.Location = new Point(352, 138);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(247, 50);
            placeNumberValue.TabIndex = 18;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            placeNumberLabel.ForeColor = Color.Navy;
            placeNumberLabel.Location = new Point(30, 134);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(259, 54);
            placeNumberLabel.TabIndex = 17;
            placeNumberLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI Light", 20F, FontStyle.Regular, GraphicsUnit.Point);
            orLabel.ForeColor = Color.Navy;
            orLabel.Location = new Point(283, 366);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(86, 54);
            orLabel.TabIndex = 25;
            orLabel.Text = "-or-";
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
            createPrizeButton.Location = new Point(119, 558);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(420, 75);
            createPrizeButton.TabIndex = 27;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(665, 710);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Light", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Navy;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 5, 5, 5);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}