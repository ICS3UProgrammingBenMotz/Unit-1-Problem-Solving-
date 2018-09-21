namespace AreaPerimeterBenM
{
    partial class frmAreaPerimeter
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidthQ = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAreaA = new System.Windows.Forms.Label();
            this.lblPerimeterA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(28, 61);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(109, 25);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length(m)";
            // 
            // lblWidthQ
            // 
            this.lblWidthQ.AutoSize = true;
            this.lblWidthQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthQ.Location = new System.Drawing.Point(28, 131);
            this.lblWidthQ.Name = "lblWidthQ";
            this.lblWidthQ.Size = new System.Drawing.Size(98, 25);
            this.lblWidthQ.TabIndex = 1;
            this.lblWidthQ.Text = "Width(m)";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(143, 67);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(67, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(143, 137);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(67, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(14, 189);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(112, 24);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "The Area is:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(14, 247);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(153, 24);
            this.lblPerimeter.TabIndex = 5;
            this.lblPerimeter.Text = "The Perimeter is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(258, 93);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(95, 42);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Press Me to Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAreaA
            // 
            this.lblAreaA.AutoSize = true;
            this.lblAreaA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaA.Location = new System.Drawing.Point(132, 189);
            this.lblAreaA.Name = "lblAreaA";
            this.lblAreaA.Size = new System.Drawing.Size(108, 24);
            this.lblAreaA.TabIndex = 7;
            this.lblAreaA.Text = "XXXXXXX";
            // 
            // lblPerimeterA
            // 
            this.lblPerimeterA.AutoSize = true;
            this.lblPerimeterA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeterA.Location = new System.Drawing.Point(173, 247);
            this.lblPerimeterA.Name = "lblPerimeterA";
            this.lblPerimeterA.Size = new System.Drawing.Size(108, 24);
            this.lblPerimeterA.TabIndex = 8;
            this.lblPerimeterA.Text = "XXXXXXX";
            this.lblPerimeterA.Click += new System.EventHandler(this.lblPerimeterA_Click);
            // 
            // frmAreaPerimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 357);
            this.Controls.Add(this.lblPerimeterA);
            this.Controls.Add(this.lblAreaA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblWidthQ);
            this.Controls.Add(this.lblLength);
            this.Name = "frmAreaPerimeter";
            this.Text = "Area and Perimeter";
            this.Load += new System.EventHandler(this.frmAreaPerimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidthQ;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAreaA;
        private System.Windows.Forms.Label lblPerimeterA;
    }
}

