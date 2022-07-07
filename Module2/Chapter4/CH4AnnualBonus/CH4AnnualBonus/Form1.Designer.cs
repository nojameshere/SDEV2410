namespace CH4AnnualBonus
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bonusOutput = new System.Windows.Forms.Label();
            this.yearsServed = new System.Windows.Forms.TextBox();
            this.yearlySales = new System.Windows.Forms.TextBox();
            this.calcBonusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Annual Bonuses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Years of Service";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Yearly Sales";
            // 
            // bonusOutput
            // 
            this.bonusOutput.AutoSize = true;
            this.bonusOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bonusOutput.Location = new System.Drawing.Point(382, 280);
            this.bonusOutput.Name = "bonusOutput";
            this.bonusOutput.Size = new System.Drawing.Size(0, 29);
            this.bonusOutput.TabIndex = 3;
            // 
            // yearsServed
            // 
            this.yearsServed.Location = new System.Drawing.Point(332, 125);
            this.yearsServed.Name = "yearsServed";
            this.yearsServed.Size = new System.Drawing.Size(150, 31);
            this.yearsServed.TabIndex = 4;
            this.yearsServed.Text = "0";
            // 
            // yearlySales
            // 
            this.yearlySales.Location = new System.Drawing.Point(332, 189);
            this.yearlySales.Name = "yearlySales";
            this.yearlySales.Size = new System.Drawing.Size(150, 31);
            this.yearlySales.TabIndex = 5;
            this.yearlySales.Text = "0";
            // 
            // calcBonusButton
            // 
            this.calcBonusButton.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcBonusButton.Location = new System.Drawing.Point(131, 272);
            this.calcBonusButton.Name = "calcBonusButton";
            this.calcBonusButton.Size = new System.Drawing.Size(234, 41);
            this.calcBonusButton.TabIndex = 6;
            this.calcBonusButton.Text = "Calculate Bonus";
            this.calcBonusButton.UseVisualStyleBackColor = true;
            this.calcBonusButton.Click += new System.EventHandler(this.calcBonusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcBonusButton);
            this.Controls.Add(this.yearlySales);
            this.Controls.Add(this.yearsServed);
            this.Controls.Add(this.bonusOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label bonusOutput;
        private TextBox yearsServed;
        private TextBox yearlySales;
        private Button calcBonusButton;
    }
}