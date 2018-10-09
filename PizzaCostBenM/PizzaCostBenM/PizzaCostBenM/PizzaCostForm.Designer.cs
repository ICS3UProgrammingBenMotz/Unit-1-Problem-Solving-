namespace PizzaCostBenM
{
    partial class frmPizzaCost
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
            this.lbldiameterpizza = new System.Windows.Forms.Label();
            this.lblnumberpizza = new System.Windows.Forms.Label();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.nudNumberOfZa = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblYourSubIs = new System.Windows.Forms.Label();
            this.lblYourHstIs = new System.Windows.Forms.Label();
            this.lblYourTotIs = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblHst = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfZa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbldiameterpizza
            // 
            this.lbldiameterpizza.AutoSize = true;
            this.lbldiameterpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiameterpizza.Location = new System.Drawing.Point(55, 54);
            this.lbldiameterpizza.Name = "lbldiameterpizza";
            this.lbldiameterpizza.Size = new System.Drawing.Size(312, 20);
            this.lbldiameterpizza.TabIndex = 0;
            this.lbldiameterpizza.Text = "What is the diameter of the pizza? (Inches)";
            // 
            // lblnumberpizza
            // 
            this.lblnumberpizza.AutoSize = true;
            this.lblnumberpizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberpizza.Location = new System.Drawing.Point(55, 102);
            this.lblnumberpizza.Name = "lblnumberpizza";
            this.lblnumberpizza.Size = new System.Drawing.Size(224, 20);
            this.lblnumberpizza.TabIndex = 1;
            this.lblnumberpizza.Text = "How many pizzas did you buy?";
            // 
            // nudDiameter
            // 
            this.nudDiameter.Location = new System.Drawing.Point(403, 54);
            this.nudDiameter.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDiameter.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(120, 20);
            this.nudDiameter.TabIndex = 2;
            this.nudDiameter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudDiameter.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // nudNumberOfZa
            // 
            this.nudNumberOfZa.Location = new System.Drawing.Point(403, 105);
            this.nudNumberOfZa.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumberOfZa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfZa.Name = "nudNumberOfZa";
            this.nudNumberOfZa.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfZa.TabIndex = 3;
            this.nudNumberOfZa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(244, 190);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(134, 51);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblYourSubIs
            // 
            this.lblYourSubIs.AutoSize = true;
            this.lblYourSubIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourSubIs.Location = new System.Drawing.Point(68, 292);
            this.lblYourSubIs.Name = "lblYourSubIs";
            this.lblYourSubIs.Size = new System.Drawing.Size(126, 20);
            this.lblYourSubIs.TabIndex = 5;
            this.lblYourSubIs.Text = "Your Subtotal is:";
            // 
            // lblYourHstIs
            // 
            this.lblYourHstIs.AutoSize = true;
            this.lblYourHstIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourHstIs.Location = new System.Drawing.Point(68, 334);
            this.lblYourHstIs.Name = "lblYourHstIs";
            this.lblYourHstIs.Size = new System.Drawing.Size(91, 20);
            this.lblYourHstIs.TabIndex = 6;
            this.lblYourHstIs.Text = "The HST is:";
            // 
            // lblYourTotIs
            // 
            this.lblYourTotIs.AutoSize = true;
            this.lblYourTotIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourTotIs.Location = new System.Drawing.Point(68, 381);
            this.lblYourTotIs.Name = "lblYourTotIs";
            this.lblYourTotIs.Size = new System.Drawing.Size(101, 20);
            this.lblYourTotIs.TabIndex = 7;
            this.lblYourTotIs.Text = "Your Total is:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(200, 292);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(42, 20);
            this.lblSubtotal.TabIndex = 8;
            this.lblSubtotal.Text = "XXX";
            // 
            // lblHst
            // 
            this.lblHst.AutoSize = true;
            this.lblHst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHst.Location = new System.Drawing.Point(165, 334);
            this.lblHst.Name = "lblHst";
            this.lblHst.Size = new System.Drawing.Size(42, 20);
            this.lblHst.TabIndex = 9;
            this.lblHst.Text = "XXX";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(177, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "XXX";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 461);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHst);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblYourTotIs);
            this.Controls.Add(this.lblYourHstIs);
            this.Controls.Add(this.lblYourSubIs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudNumberOfZa);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.lblnumberpizza);
            this.Controls.Add(this.lbldiameterpizza);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            this.Load += new System.EventHandler(this.frmPizzaCost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfZa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldiameterpizza;
        private System.Windows.Forms.Label lblnumberpizza;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.NumericUpDown nudNumberOfZa;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblYourSubIs;
        private System.Windows.Forms.Label lblYourHstIs;
        private System.Windows.Forms.Label lblYourTotIs;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblHst;
        private System.Windows.Forms.Label lblTotal;
    }
}

