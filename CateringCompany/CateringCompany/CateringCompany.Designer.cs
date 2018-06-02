namespace CateringCompany
{
    partial class frmCateringCompany
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCateringCompany));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.txtGuests = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDinnerOptions = new System.Windows.Forms.GroupBox();
            this.grpDrinkOptions = new System.Windows.Forms.GroupBox();
            this.rdoPrimeRib = new System.Windows.Forms.RadioButton();
            this.rdoChicken = new System.Windows.Forms.RadioButton();
            this.rdoPasta = new System.Windows.Forms.RadioButton();
            this.chkOpenBar = new System.Windows.Forms.CheckBox();
            this.chkWineDinner = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tooltipCatering = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDinnerOptions.SuspendLayout();
            this.grpDrinkOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CateringCompany.Properties.Resources.catering_company_logo;
            this.pictureBox1.Location = new System.Drawing.Point(32, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblGuests
            // 
            this.lblGuests.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.lblGuests.Location = new System.Drawing.Point(295, 90);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(114, 41);
            this.lblGuests.TabIndex = 1;
            this.lblGuests.Text = "Guests:";
            // 
            // txtGuests
            // 
            this.txtGuests.BackColor = System.Drawing.Color.White;
            this.txtGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGuests.Font = new System.Drawing.Font("Calibri", 14F);
            this.txtGuests.Location = new System.Drawing.Point(408, 90);
            this.txtGuests.MaxLength = 4;
            this.txtGuests.Multiline = true;
            this.txtGuests.Name = "txtGuests";
            this.txtGuests.Size = new System.Drawing.Size(74, 38);
            this.txtGuests.TabIndex = 2;
            this.txtGuests.Text = "10";
            this.txtGuests.WordWrap = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Black", 13F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(489, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpDinnerOptions
            // 
            this.grpDinnerOptions.Controls.Add(this.rdoPasta);
            this.grpDinnerOptions.Controls.Add(this.rdoChicken);
            this.grpDinnerOptions.Controls.Add(this.rdoPrimeRib);
            this.grpDinnerOptions.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDinnerOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.grpDinnerOptions.Location = new System.Drawing.Point(45, 163);
            this.grpDinnerOptions.Name = "grpDinnerOptions";
            this.grpDinnerOptions.Size = new System.Drawing.Size(247, 173);
            this.grpDinnerOptions.TabIndex = 4;
            this.grpDinnerOptions.TabStop = false;
            this.grpDinnerOptions.Text = "Dinner Options";
            // 
            // grpDrinkOptions
            // 
            this.grpDrinkOptions.Controls.Add(this.chkWineDinner);
            this.grpDrinkOptions.Controls.Add(this.chkOpenBar);
            this.grpDrinkOptions.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrinkOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.grpDrinkOptions.Location = new System.Drawing.Point(316, 163);
            this.grpDrinkOptions.Name = "grpDrinkOptions";
            this.grpDrinkOptions.Size = new System.Drawing.Size(247, 122);
            this.grpDrinkOptions.TabIndex = 5;
            this.grpDrinkOptions.TabStop = false;
            this.grpDrinkOptions.Text = "Drink Options";
            // 
            // rdoPrimeRib
            // 
            this.rdoPrimeRib.AutoSize = true;
            this.rdoPrimeRib.Checked = true;
            this.rdoPrimeRib.Font = new System.Drawing.Font("Calibri", 16F);
            this.rdoPrimeRib.ForeColor = System.Drawing.Color.Black;
            this.rdoPrimeRib.Location = new System.Drawing.Point(7, 42);
            this.rdoPrimeRib.Name = "rdoPrimeRib";
            this.rdoPrimeRib.Size = new System.Drawing.Size(197, 31);
            this.rdoPrimeRib.TabIndex = 0;
            this.rdoPrimeRib.TabStop = true;
            this.rdoPrimeRib.Text = "Prime Rib ($25.95)";
            this.tooltipCatering.SetToolTip(this.rdoPrimeRib, "Delicious prime rib served with a side of vegetables and mashed potatoes.");
            this.rdoPrimeRib.UseVisualStyleBackColor = true;
            this.rdoPrimeRib.CheckedChanged += new System.EventHandler(this.rdoPrimeRib_CheckedChanged);
            // 
            // rdoChicken
            // 
            this.rdoChicken.AutoSize = true;
            this.rdoChicken.Font = new System.Drawing.Font("Calibri", 16F);
            this.rdoChicken.ForeColor = System.Drawing.Color.Black;
            this.rdoChicken.Location = new System.Drawing.Point(7, 79);
            this.rdoChicken.Name = "rdoChicken";
            this.rdoChicken.Size = new System.Drawing.Size(180, 31);
            this.rdoChicken.TabIndex = 1;
            this.rdoChicken.Text = "Chicken ($18.95)";
            this.tooltipCatering.SetToolTip(this.rdoChicken, "Perfectly cooked chicken marsala.");
            this.rdoChicken.UseVisualStyleBackColor = true;
            this.rdoChicken.CheckedChanged += new System.EventHandler(this.rdoChicken_CheckedChanged);
            // 
            // rdoPasta
            // 
            this.rdoPasta.AutoSize = true;
            this.rdoPasta.Font = new System.Drawing.Font("Calibri", 16F);
            this.rdoPasta.ForeColor = System.Drawing.Color.Black;
            this.rdoPasta.Location = new System.Drawing.Point(7, 116);
            this.rdoPasta.Name = "rdoPasta";
            this.rdoPasta.Size = new System.Drawing.Size(159, 31);
            this.rdoPasta.TabIndex = 2;
            this.rdoPasta.Text = "Pasta ($12.95)";
            this.tooltipCatering.SetToolTip(this.rdoPasta, "Pasta cooked to your liking with your choice of alfredo or red sauce.");
            this.rdoPasta.UseVisualStyleBackColor = true;
            this.rdoPasta.CheckedChanged += new System.EventHandler(this.rdoPasta_CheckedChanged);
            // 
            // chkOpenBar
            // 
            this.chkOpenBar.AutoSize = true;
            this.chkOpenBar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpenBar.ForeColor = System.Drawing.Color.Black;
            this.chkOpenBar.Location = new System.Drawing.Point(6, 42);
            this.chkOpenBar.Name = "chkOpenBar";
            this.chkOpenBar.Size = new System.Drawing.Size(160, 30);
            this.chkOpenBar.TabIndex = 0;
            this.chkOpenBar.Text = "Open Bar ($25)";
            this.tooltipCatering.SetToolTip(this.chkOpenBar, "Open bar package for the entire night.");
            this.chkOpenBar.UseVisualStyleBackColor = true;
            this.chkOpenBar.CheckedChanged += new System.EventHandler(this.chkOpenBar_CheckedChanged);
            // 
            // chkWineDinner
            // 
            this.chkWineDinner.AutoSize = true;
            this.chkWineDinner.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWineDinner.ForeColor = System.Drawing.Color.Black;
            this.chkWineDinner.Location = new System.Drawing.Point(6, 80);
            this.chkWineDinner.Name = "chkWineDinner";
            this.chkWineDinner.Size = new System.Drawing.Size(224, 30);
            this.chkWineDinner.TabIndex = 1;
            this.chkWineDinner.Text = "Wine With Dinner ($8)";
            this.tooltipCatering.SetToolTip(this.chkWineDinner, "Red or white wine served with dinner.");
            this.chkWineDinner.UseVisualStyleBackColor = true;
            this.chkWineDinner.CheckedChanged += new System.EventHandler(this.chkWineDinner_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial Black", 13F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.btnClear.Location = new System.Drawing.Point(316, 301);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.tooltipCatering.SetToolTip(this.btnClear, "Clear all options.");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(209)))), ((int)(((byte)(142)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Black", 13F);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(87)))), ((int)(((byte)(35)))));
            this.btnCalculate.Location = new System.Drawing.Point(444, 301);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(119, 35);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.tooltipCatering.SetToolTip(this.btnCalculate, "Calculate costs.");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalText
            // 
            this.lblTotalText.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.lblTotalText.Location = new System.Drawing.Point(370, 352);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(87, 41);
            this.lblTotalText.TabIndex = 8;
            this.lblTotalText.Text = "Total:";
            this.lblTotalText.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(85)))), ((int)(((byte)(151)))));
            this.lblTotal.Location = new System.Drawing.Point(451, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 41);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "$0";
            this.lblTotal.Visible = false;
            // 
            // frmCateringCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(631, 417);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpDrinkOptions);
            this.Controls.Add(this.grpDinnerOptions);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGuests);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCateringCompany";
            this.Text = "The Catering Company";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDinnerOptions.ResumeLayout(false);
            this.grpDinnerOptions.PerformLayout();
            this.grpDrinkOptions.ResumeLayout(false);
            this.grpDrinkOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TextBox txtGuests;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDinnerOptions;
        private System.Windows.Forms.RadioButton rdoPasta;
        private System.Windows.Forms.RadioButton rdoChicken;
        private System.Windows.Forms.RadioButton rdoPrimeRib;
        private System.Windows.Forms.GroupBox grpDrinkOptions;
        private System.Windows.Forms.CheckBox chkWineDinner;
        private System.Windows.Forms.CheckBox chkOpenBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolTip tooltipCatering;
    }
}

