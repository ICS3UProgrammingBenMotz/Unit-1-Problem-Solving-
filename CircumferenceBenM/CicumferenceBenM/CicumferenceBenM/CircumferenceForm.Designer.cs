namespace CicumferenceBenM
{
    partial class frmCircumference
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
            this.lblEnterRad = new System.Windows.Forms.Label();
            this.txtEnterRad = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRadIs = new System.Windows.Forms.Label();
            this.lblRadAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterRad
            // 
            this.lblEnterRad.AutoSize = true;
            this.lblEnterRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterRad.Location = new System.Drawing.Point(21, 84);
            this.lblEnterRad.Name = "lblEnterRad";
            this.lblEnterRad.Size = new System.Drawing.Size(329, 24);
            this.lblEnterRad.TabIndex = 0;
            this.lblEnterRad.Text = "Enter The Radius of the Circle (in cm):";
            // 
            // txtEnterRad
            // 
            this.txtEnterRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterRad.Location = new System.Drawing.Point(371, 81);
            this.txtEnterRad.Name = "txtEnterRad";
            this.txtEnterRad.Size = new System.Drawing.Size(100, 29);
            this.txtEnterRad.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(170, 164);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 46);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRadIs
            // 
            this.lblRadIs.AutoSize = true;
            this.lblRadIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadIs.Location = new System.Drawing.Point(45, 305);
            this.lblRadIs.Name = "lblRadIs";
            this.lblRadIs.Size = new System.Drawing.Size(196, 24);
            this.lblRadIs.TabIndex = 3;
            this.lblRadIs.Text = "The Circumference is:";
            // 
            // lblRadAns
            // 
            this.lblRadAns.AutoSize = true;
            this.lblRadAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadAns.Location = new System.Drawing.Point(247, 305);
            this.lblRadAns.Name = "lblRadAns";
            this.lblRadAns.Size = new System.Drawing.Size(66, 24);
            this.lblRadAns.TabIndex = 4;
            this.lblRadAns.Text = "XXXX";
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 429);
            this.Controls.Add(this.lblRadAns);
            this.Controls.Add(this.lblRadIs);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterRad);
            this.Controls.Add(this.lblEnterRad);
            this.Name = "frmCircumference";
            this.Text = "Circumference";
            this.Load += new System.EventHandler(this.frmCircumference_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterRad;
        private System.Windows.Forms.TextBox txtEnterRad;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRadIs;
        private System.Windows.Forms.Label lblRadAns;
    }
}

