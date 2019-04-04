namespace PizzaOrderAlexF
{
    partial class frmPizzaOrder
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
            this.lblSizeQuestion = new System.Windows.Forms.Label();
            this.lblMedium = new System.Windows.Forms.Label();
            this.lblToppings1 = new System.Windows.Forms.Label();
            this.lblToppings5 = new System.Windows.Forms.Label();
            this.lblToppings4 = new System.Windows.Forms.Label();
            this.lblToppingsQuestion = new System.Windows.Forms.Label();
            this.lblXL = new System.Windows.Forms.Label();
            this.lblLarge = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.nudToppings = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblToppings2 = new System.Windows.Forms.Label();
            this.lblToppings3 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSizeQuestion
            // 
            this.lblSizeQuestion.AutoSize = true;
            this.lblSizeQuestion.Location = new System.Drawing.Point(104, 96);
            this.lblSizeQuestion.Name = "lblSizeQuestion";
            this.lblSizeQuestion.Size = new System.Drawing.Size(157, 13);
            this.lblSizeQuestion.TabIndex = 0;
            this.lblSizeQuestion.Text = "What size pizza would you like?";
            // 
            // lblMedium
            // 
            this.lblMedium.AutoSize = true;
            this.lblMedium.Location = new System.Drawing.Point(113, 133);
            this.lblMedium.Name = "lblMedium";
            this.lblMedium.Size = new System.Drawing.Size(98, 13);
            this.lblMedium.TabIndex = 1;
            this.lblMedium.Text = "Medium = 1 ($6.99)";
            // 
            // lblToppings1
            // 
            this.lblToppings1.AutoSize = true;
            this.lblToppings1.Location = new System.Drawing.Point(113, 248);
            this.lblToppings1.Name = "lblToppings1";
            this.lblToppings1.Size = new System.Drawing.Size(100, 13);
            this.lblToppings1.TabIndex = 3;
            this.lblToppings1.Text = "1 Topping = ($0.75)";
            // 
            // lblToppings5
            // 
            this.lblToppings5.AutoSize = true;
            this.lblToppings5.Location = new System.Drawing.Point(113, 378);
            this.lblToppings5.Name = "lblToppings5";
            this.lblToppings5.Size = new System.Drawing.Size(105, 13);
            this.lblToppings5.TabIndex = 2;
            this.lblToppings5.Text = "5 Toppings = ($3.25)";
            // 
            // lblToppings4
            // 
            this.lblToppings4.AutoSize = true;
            this.lblToppings4.Location = new System.Drawing.Point(113, 347);
            this.lblToppings4.Name = "lblToppings4";
            this.lblToppings4.Size = new System.Drawing.Size(105, 13);
            this.lblToppings4.TabIndex = 5;
            this.lblToppings4.Text = "4 Toppings = ($2.75)";
            // 
            // lblToppingsQuestion
            // 
            this.lblToppingsQuestion.AutoSize = true;
            this.lblToppingsQuestion.Location = new System.Drawing.Point(104, 218);
            this.lblToppingsQuestion.Name = "lblToppingsQuestion";
            this.lblToppingsQuestion.Size = new System.Drawing.Size(176, 13);
            this.lblToppingsQuestion.TabIndex = 4;
            this.lblToppingsQuestion.Text = "How many toppings would you like?";
            // 
            // lblXL
            // 
            this.lblXL.AutoSize = true;
            this.lblXL.Location = new System.Drawing.Point(113, 184);
            this.lblXL.Name = "lblXL";
            this.lblXL.Size = new System.Drawing.Size(121, 13);
            this.lblXL.TabIndex = 7;
            this.lblXL.Text = "Extra Large = 3 ($12.99)";
            // 
            // lblLarge
            // 
            this.lblLarge.AutoSize = true;
            this.lblLarge.Location = new System.Drawing.Point(113, 159);
            this.lblLarge.Name = "lblLarge";
            this.lblLarge.Size = new System.Drawing.Size(94, 13);
            this.lblLarge.TabIndex = 6;
            this.lblLarge.Text = "Large = 2 ($10.99)";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(342, 96);
            this.nudSize.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 9;
            this.nudSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudToppings
            // 
            this.nudToppings.Location = new System.Drawing.Point(342, 218);
            this.nudToppings.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudToppings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppings.Name = "nudToppings";
            this.nudToppings.Size = new System.Drawing.Size(120, 20);
            this.nudToppings.TabIndex = 10;
            this.nudToppings.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(342, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblToppings2
            // 
            this.lblToppings2.AutoSize = true;
            this.lblToppings2.Location = new System.Drawing.Point(113, 281);
            this.lblToppings2.Name = "lblToppings2";
            this.lblToppings2.Size = new System.Drawing.Size(105, 13);
            this.lblToppings2.TabIndex = 13;
            this.lblToppings2.Text = "2 Toppings = ($1.35)";
            // 
            // lblToppings3
            // 
            this.lblToppings3.AutoSize = true;
            this.lblToppings3.Location = new System.Drawing.Point(113, 315);
            this.lblToppings3.Name = "lblToppings3";
            this.lblToppings3.Size = new System.Drawing.Size(105, 13);
            this.lblToppings3.TabIndex = 12;
            this.lblToppings3.Text = "3 Toppings = ($2.15)";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(339, 315);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(58, 13);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal = ";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Location = new System.Drawing.Point(339, 347);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(38, 13);
            this.lblHST.TabIndex = 15;
            this.lblHST.Text = "HST =";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(339, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total =";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 444);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblToppings2);
            this.Controls.Add(this.lblToppings3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudToppings);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblXL);
            this.Controls.Add(this.lblLarge);
            this.Controls.Add(this.lblToppings4);
            this.Controls.Add(this.lblToppingsQuestion);
            this.Controls.Add(this.lblToppings1);
            this.Controls.Add(this.lblToppings5);
            this.Controls.Add(this.lblMedium);
            this.Controls.Add(this.lblSizeQuestion);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order Alexander Forgeron";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSizeQuestion;
        private System.Windows.Forms.Label lblMedium;
        private System.Windows.Forms.Label lblToppings1;
        private System.Windows.Forms.Label lblToppings5;
        private System.Windows.Forms.Label lblToppings4;
        private System.Windows.Forms.Label lblToppingsQuestion;
        private System.Windows.Forms.Label lblXL;
        private System.Windows.Forms.Label lblLarge;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.NumericUpDown nudToppings;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblToppings2;
        private System.Windows.Forms.Label lblToppings3;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblTotal;
    }
}

