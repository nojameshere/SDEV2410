namespace SnackStandCorrect
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
            this.snackItem = new System.Windows.Forms.TextBox();
            this.drinkItem = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Snack Stand";
            // 
            // snackItem
            // 
            this.snackItem.Location = new System.Drawing.Point(0, 0);
            this.snackItem.Name = "snackItem";
            this.snackItem.Size = new System.Drawing.Size(100, 31);
            this.snackItem.TabIndex = 0;
            // 
            // drinkItem
            // 
            this.drinkItem.Location = new System.Drawing.Point(0, 0);
            this.drinkItem.Name = "drinkItem";
            this.drinkItem.Size = new System.Drawing.Size(100, 31);
            this.drinkItem.TabIndex = 0;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(0, 0);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1611, 1043);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox snackItem;
        private TextBox drinkItem;
        private Button calculate;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}