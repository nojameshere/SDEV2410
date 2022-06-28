namespace SnackStandSecondTry
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
            this.snackNumber = new System.Windows.Forms.TextBox();
            this.drinkNumber = new System.Windows.Forms.TextBox();
            this.costOutput = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(212, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(670, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Snack Stand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Snack Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(229, 398);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drink Item";
            // 
            // snackNumber
            // 
            this.snackNumber.Location = new System.Drawing.Point(557, 308);
            this.snackNumber.Name = "snackNumber";
            this.snackNumber.Size = new System.Drawing.Size(300, 55);
            this.snackNumber.TabIndex = 3;
            // 
            // drinkNumber
            // 
            this.drinkNumber.Location = new System.Drawing.Point(557, 408);
            this.drinkNumber.Name = "drinkNumber";
            this.drinkNumber.Size = new System.Drawing.Size(300, 55);
            this.drinkNumber.TabIndex = 4;
            // 
            // costOutput
            // 
            this.costOutput.AutoSize = true;
            this.costOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costOutput.Location = new System.Drawing.Point(460, 706);
            this.costOutput.Name = "costOutput";
            this.costOutput.Size = new System.Drawing.Size(245, 65);
            this.costOutput.TabIndex = 5;
            this.costOutput.Text = "Total Cost:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(442, 560);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(225, 69);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1231, 1318);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.costOutput);
            this.Controls.Add(this.drinkNumber);
            this.Controls.Add(this.snackNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox snackNumber;
        private TextBox drinkNumber;
        private Label costOutput;
        private Button calculate;
    }
}