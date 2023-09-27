using System.Drawing;
using System.Windows.Forms;

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
            this.headerLabel = new System.Windows.Forms.Label();
            this.prizePercentageValue = new System.Windows.Forms.TextBox();
            this.prizePercentageLabel = new System.Windows.Forms.Label();
            this.prizeAmountValue = new System.Windows.Forms.TextBox();
            this.prizeAmountLabel = new System.Windows.Forms.Label();
            this.placeNameValue = new System.Windows.Forms.TextBox();
            this.placeNameLabel = new System.Windows.Forms.Label();
            this.placeNumberValue = new System.Windows.Forms.TextBox();
            this.placeNumberLabel = new System.Windows.Forms.Label();
            this.orLabel = new System.Windows.Forms.Label();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.headerLabel.ForeColor = System.Drawing.Color.Navy;
            this.headerLabel.Location = new System.Drawing.Point(12, 24);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(313, 74);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Prize";
            // 
            // prizePercentageValue
            // 
            this.prizePercentageValue.BackColor = System.Drawing.SystemColors.Menu;
            this.prizePercentageValue.Location = new System.Drawing.Point(352, 445);
            this.prizePercentageValue.Name = "prizePercentageValue";
            this.prizePercentageValue.Size = new System.Drawing.Size(247, 50);
            this.prizePercentageValue.TabIndex = 24;
            this.prizePercentageValue.Text = "0";
            // 
            // prizePercentageLabel
            // 
            this.prizePercentageLabel.AutoSize = true;
            this.prizePercentageLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.prizePercentageLabel.ForeColor = System.Drawing.Color.Navy;
            this.prizePercentageLabel.Location = new System.Drawing.Point(30, 441);
            this.prizePercentageLabel.Name = "prizePercentageLabel";
            this.prizePercentageLabel.Size = new System.Drawing.Size(301, 54);
            this.prizePercentageLabel.TabIndex = 23;
            this.prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            this.prizeAmountValue.BackColor = System.Drawing.SystemColors.Menu;
            this.prizeAmountValue.Location = new System.Drawing.Point(352, 280);
            this.prizeAmountValue.Name = "prizeAmountValue";
            this.prizeAmountValue.Size = new System.Drawing.Size(247, 50);
            this.prizeAmountValue.TabIndex = 22;
            this.prizeAmountValue.Text = "0";
            // 
            // prizeAmountLabel
            // 
            this.prizeAmountLabel.AutoSize = true;
            this.prizeAmountLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.prizeAmountLabel.ForeColor = System.Drawing.Color.Navy;
            this.prizeAmountLabel.Location = new System.Drawing.Point(30, 276);
            this.prizeAmountLabel.Name = "prizeAmountLabel";
            this.prizeAmountLabel.Size = new System.Drawing.Size(250, 54);
            this.prizeAmountLabel.TabIndex = 21;
            this.prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            this.placeNameValue.BackColor = System.Drawing.SystemColors.Menu;
            this.placeNameValue.Location = new System.Drawing.Point(352, 208);
            this.placeNameValue.Name = "placeNameValue";
            this.placeNameValue.Size = new System.Drawing.Size(247, 50);
            this.placeNameValue.TabIndex = 20;
            // 
            // placeNameLabel
            // 
            this.placeNameLabel.AutoSize = true;
            this.placeNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.placeNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.placeNameLabel.Location = new System.Drawing.Point(30, 204);
            this.placeNameLabel.Name = "placeNameLabel";
            this.placeNameLabel.Size = new System.Drawing.Size(223, 54);
            this.placeNameLabel.TabIndex = 19;
            this.placeNameLabel.Text = "Place Name";
            // 
            // placeNumberValue
            // 
            this.placeNumberValue.BackColor = System.Drawing.SystemColors.Menu;
            this.placeNumberValue.Location = new System.Drawing.Point(352, 138);
            this.placeNumberValue.Name = "placeNumberValue";
            this.placeNumberValue.Size = new System.Drawing.Size(247, 50);
            this.placeNumberValue.TabIndex = 18;
            // 
            // placeNumberLabel
            // 
            this.placeNumberLabel.AutoSize = true;
            this.placeNumberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.placeNumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.placeNumberLabel.Location = new System.Drawing.Point(30, 134);
            this.placeNumberLabel.Name = "placeNumberLabel";
            this.placeNumberLabel.Size = new System.Drawing.Size(259, 54);
            this.placeNumberLabel.TabIndex = 17;
            this.placeNumberLabel.Text = "Place Number";
            // 
            // orLabel
            // 
            this.orLabel.AutoSize = true;
            this.orLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.orLabel.ForeColor = System.Drawing.Color.Navy;
            this.orLabel.Location = new System.Drawing.Point(283, 366);
            this.orLabel.Name = "orLabel";
            this.orLabel.Size = new System.Drawing.Size(86, 54);
            this.orLabel.TabIndex = 25;
            this.orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.BorderSize = 5;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque;
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.createPrizeButton.ForeColor = System.Drawing.Color.Navy;
            this.createPrizeButton.Location = new System.Drawing.Point(119, 558);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(420, 75);
            this.createPrizeButton.TabIndex = 27;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = false;
            this.createPrizeButton.Click += new System.EventHandler(this.createPrizeButton_Click);
            // 
            // CreatePrizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(665, 710);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.orLabel);
            this.Controls.Add(this.prizePercentageValue);
            this.Controls.Add(this.prizePercentageLabel);
            this.Controls.Add(this.prizeAmountValue);
            this.Controls.Add(this.prizeAmountLabel);
            this.Controls.Add(this.placeNameValue);
            this.Controls.Add(this.placeNameLabel);
            this.Controls.Add(this.placeNumberValue);
            this.Controls.Add(this.placeNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CreatePrizeForm";
            this.Text = "Create Prize";
            this.ResumeLayout(false);
            this.PerformLayout();

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