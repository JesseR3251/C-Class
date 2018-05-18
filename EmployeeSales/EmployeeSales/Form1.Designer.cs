namespace EmployeeSales
{
    partial class frm_EmpSales
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
            this.lblEmpName = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtSaleAmt = new System.Windows.Forms.TextBox();
            this.lblSaleAmt = new System.Windows.Forms.Label();
            this.btnCalcPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEmpName
            // 
            this.lblEmpName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(12, 45);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(190, 23);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Enter Employee Name: ";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(208, 42);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(207, 26);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSaleAmt
            // 
            this.txtSaleAmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleAmt.Location = new System.Drawing.Point(271, 88);
            this.txtSaleAmt.Name = "txtSaleAmt";
            this.txtSaleAmt.Size = new System.Drawing.Size(150, 26);
            this.txtSaleAmt.TabIndex = 3;
            this.txtSaleAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaleAmt
            // 
            this.lblSaleAmt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleAmt.Location = new System.Drawing.Point(12, 91);
            this.lblSaleAmt.Name = "lblSaleAmt";
            this.lblSaleAmt.Size = new System.Drawing.Size(253, 23);
            this.lblSaleAmt.TabIndex = 2;
            this.lblSaleAmt.Text = "Enter Employee Sales Amount:";
            // 
            // btnCalcPay
            // 
            this.btnCalcPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPay.Location = new System.Drawing.Point(16, 146);
            this.btnCalcPay.Name = "btnCalcPay";
            this.btnCalcPay.Size = new System.Drawing.Size(186, 52);
            this.btnCalcPay.TabIndex = 4;
            this.btnCalcPay.Text = "Calculate Pay";
            this.btnCalcPay.UseVisualStyleBackColor = true;
            this.btnCalcPay.Click += new System.EventHandler(this.btnCalcPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(229, 146);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(222, 52);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(12, 222);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(95, 23);
            this.lblGrossPay.TabIndex = 6;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblDeductions
            // 
            this.lblDeductions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.Location = new System.Drawing.Point(12, 259);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(109, 23);
            this.lblDeductions.TabIndex = 7;
            this.lblDeductions.Text = "Deductions:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(12, 299);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(79, 23);
            this.lblNetPay.TabIndex = 8;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(151, 219);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(105, 26);
            this.txtGrossPay.TabIndex = 9;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeductions
            // 
            this.txtDeductions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeductions.Location = new System.Drawing.Point(151, 256);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(105, 26);
            this.txtDeductions.TabIndex = 10;
            this.txtDeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.Location = new System.Drawing.Point(151, 296);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.Size = new System.Drawing.Size(105, 26);
            this.txtNetPay.TabIndex = 11;
            this.txtNetPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_EmpSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblDeductions);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcPay);
            this.Controls.Add(this.txtSaleAmt);
            this.Controls.Add(this.lblSaleAmt);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.lblEmpName);
            this.Name = "frm_EmpSales";
            this.Text = "Employee Pay Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtSaleAmt;
        private System.Windows.Forms.Label lblSaleAmt;
        private System.Windows.Forms.Button btnCalcPay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.TextBox txtNetPay;
    }
}

