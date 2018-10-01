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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(403, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 461);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblnumberpizza);
            this.Controls.Add(this.lbldiameterpizza);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldiameterpizza;
        private System.Windows.Forms.Label lblnumberpizza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

