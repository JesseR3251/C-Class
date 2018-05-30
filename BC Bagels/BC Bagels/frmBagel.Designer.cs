namespace BC_Bagels
{
    partial class frmBagel
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
            this.picBCLogo = new System.Windows.Forms.PictureBox();
            this.lblBCBagel = new System.Windows.Forms.Label();
            this.lblOrderText = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.grpMenuItems = new System.Windows.Forms.GroupBox();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.chkSalad = new System.Windows.Forms.CheckBox();
            this.chkBagel = new System.Windows.Forms.CheckBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkCreamCheese = new System.Windows.Forms.CheckBox();
            this.chkLox = new System.Windows.Forms.CheckBox();
            this.grpSalad = new System.Windows.Forms.GroupBox();
            this.rdoChef = new System.Windows.Forms.RadioButton();
            this.rdoSpinach = new System.Windows.Forms.RadioButton();
            this.grpSoda = new System.Windows.Forms.GroupBox();
            this.rdoRegularSoda = new System.Windows.Forms.RadioButton();
            this.rdoDietSoda = new System.Windows.Forms.RadioButton();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBCLogo)).BeginInit();
            this.grpMenuItems.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpSalad.SuspendLayout();
            this.grpSoda.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBCLogo
            // 
            this.picBCLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBCLogo.Image = global::BC_Bagels.Properties.Resources.bc_logo;
            this.picBCLogo.Location = new System.Drawing.Point(31, 27);
            this.picBCLogo.Name = "picBCLogo";
            this.picBCLogo.Size = new System.Drawing.Size(86, 82);
            this.picBCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBCLogo.TabIndex = 0;
            this.picBCLogo.TabStop = false;
            this.picBCLogo.Click += new System.EventHandler(this.picBCLogo_Click);
            // 
            // lblBCBagel
            // 
            this.lblBCBagel.Font = new System.Drawing.Font("Rockwell", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBCBagel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBCBagel.Location = new System.Drawing.Point(125, 27);
            this.lblBCBagel.Name = "lblBCBagel";
            this.lblBCBagel.Size = new System.Drawing.Size(492, 82);
            this.lblBCBagel.TabIndex = 1;
            this.lblBCBagel.Text = "BC BAGELS";
            this.lblBCBagel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderText
            // 
            this.lblOrderText.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOrderText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOrderText.Location = new System.Drawing.Point(28, 135);
            this.lblOrderText.Name = "lblOrderText";
            this.lblOrderText.Size = new System.Drawing.Size(169, 28);
            this.lblOrderText.TabIndex = 2;
            this.lblOrderText.Text = "Order Number: ";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.BackColor = System.Drawing.Color.White;
            this.lblOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderNumber.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(203, 137);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(98, 26);
            this.lblOrderNumber.TabIndex = 3;
            this.lblOrderNumber.Click += new System.EventHandler(this.lblOrderNumber_Click);
            // 
            // grpMenuItems
            // 
            this.grpMenuItems.Controls.Add(this.chkSoda);
            this.grpMenuItems.Controls.Add(this.chkSalad);
            this.grpMenuItems.Controls.Add(this.chkBagel);
            this.grpMenuItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenuItems.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpMenuItems.Location = new System.Drawing.Point(33, 185);
            this.grpMenuItems.Name = "grpMenuItems";
            this.grpMenuItems.Size = new System.Drawing.Size(233, 291);
            this.grpMenuItems.TabIndex = 4;
            this.grpMenuItems.TabStop = false;
            this.grpMenuItems.Text = "Menu Items";
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoda.Location = new System.Drawing.Point(7, 212);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(99, 23);
            this.chkSoda.TabIndex = 2;
            this.chkSoda.Text = "Soda $1.50";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // chkSalad
            // 
            this.chkSalad.AutoSize = true;
            this.chkSalad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSalad.Location = new System.Drawing.Point(7, 126);
            this.chkSalad.Name = "chkSalad";
            this.chkSalad.Size = new System.Drawing.Size(103, 23);
            this.chkSalad.TabIndex = 1;
            this.chkSalad.Text = "Salad $5.75";
            this.chkSalad.UseVisualStyleBackColor = true;
            this.chkSalad.CheckedChanged += new System.EventHandler(this.chkSalad_CheckedChanged);
            // 
            // chkBagel
            // 
            this.chkBagel.AutoSize = true;
            this.chkBagel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBagel.Location = new System.Drawing.Point(7, 39);
            this.chkBagel.Name = "chkBagel";
            this.chkBagel.Size = new System.Drawing.Size(105, 23);
            this.chkBagel.TabIndex = 0;
            this.chkBagel.Text = "Bagel $1.25";
            this.toolTip1.SetToolTip(this.chkBagel, "A finely crafted bagel from the world reknown bagel chefs at BC");
            this.chkBagel.UseVisualStyleBackColor = true;
            this.chkBagel.CheckedChanged += new System.EventHandler(this.chkBagel_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkCreamCheese);
            this.grpToppings.Controls.Add(this.chkLox);
            this.grpToppings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpToppings.Location = new System.Drawing.Point(297, 185);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(233, 92);
            this.grpToppings.TabIndex = 5;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            this.grpToppings.Visible = false;
            // 
            // chkCreamCheese
            // 
            this.chkCreamCheese.AutoSize = true;
            this.chkCreamCheese.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCreamCheese.Location = new System.Drawing.Point(7, 55);
            this.chkCreamCheese.Name = "chkCreamCheese";
            this.chkCreamCheese.Size = new System.Drawing.Size(162, 23);
            this.chkCreamCheese.TabIndex = 2;
            this.chkCreamCheese.Text = "Cream Cheese $1.50";
            this.chkCreamCheese.UseVisualStyleBackColor = true;
            this.chkCreamCheese.CheckedChanged += new System.EventHandler(this.chkCreamCheese_CheckedChanged);
            // 
            // chkLox
            // 
            this.chkLox.AutoSize = true;
            this.chkLox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLox.Location = new System.Drawing.Point(7, 25);
            this.chkLox.Name = "chkLox";
            this.chkLox.Size = new System.Drawing.Size(90, 23);
            this.chkLox.TabIndex = 1;
            this.chkLox.Text = "Lox $3.50";
            this.chkLox.UseVisualStyleBackColor = true;
            this.chkLox.CheckedChanged += new System.EventHandler(this.chkLox_CheckedChanged);
            // 
            // grpSalad
            // 
            this.grpSalad.Controls.Add(this.rdoChef);
            this.grpSalad.Controls.Add(this.rdoSpinach);
            this.grpSalad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSalad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpSalad.Location = new System.Drawing.Point(297, 284);
            this.grpSalad.Name = "grpSalad";
            this.grpSalad.Size = new System.Drawing.Size(233, 92);
            this.grpSalad.TabIndex = 6;
            this.grpSalad.TabStop = false;
            this.grpSalad.Text = "Salad";
            this.grpSalad.Visible = false;
            // 
            // rdoChef
            // 
            this.rdoChef.AutoSize = true;
            this.rdoChef.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChef.Location = new System.Drawing.Point(8, 57);
            this.rdoChef.Name = "rdoChef";
            this.rdoChef.Size = new System.Drawing.Size(128, 23);
            this.rdoChef.TabIndex = 1;
            this.rdoChef.TabStop = true;
            this.rdoChef.Text = "Chef (Add $.50)";
            this.rdoChef.UseVisualStyleBackColor = true;
            this.rdoChef.CheckedChanged += new System.EventHandler(this.rdoChef_CheckedChanged);
            // 
            // rdoSpinach
            // 
            this.rdoSpinach.AutoSize = true;
            this.rdoSpinach.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSpinach.Location = new System.Drawing.Point(8, 27);
            this.rdoSpinach.Name = "rdoSpinach";
            this.rdoSpinach.Size = new System.Drawing.Size(148, 23);
            this.rdoSpinach.TabIndex = 0;
            this.rdoSpinach.TabStop = true;
            this.rdoSpinach.Text = "Spinach (Add $.25)";
            this.rdoSpinach.UseVisualStyleBackColor = true;
            this.rdoSpinach.CheckedChanged += new System.EventHandler(this.rdoSpinach_CheckedChanged);
            // 
            // grpSoda
            // 
            this.grpSoda.Controls.Add(this.rdoRegularSoda);
            this.grpSoda.Controls.Add(this.rdoDietSoda);
            this.grpSoda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoda.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.grpSoda.Location = new System.Drawing.Point(297, 383);
            this.grpSoda.Name = "grpSoda";
            this.grpSoda.Size = new System.Drawing.Size(233, 92);
            this.grpSoda.TabIndex = 7;
            this.grpSoda.TabStop = false;
            this.grpSoda.Text = "Soda";
            this.grpSoda.Visible = false;
            // 
            // rdoRegularSoda
            // 
            this.rdoRegularSoda.AutoSize = true;
            this.rdoRegularSoda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegularSoda.Location = new System.Drawing.Point(8, 55);
            this.rdoRegularSoda.Name = "rdoRegularSoda";
            this.rdoRegularSoda.Size = new System.Drawing.Size(112, 23);
            this.rdoRegularSoda.TabIndex = 2;
            this.rdoRegularSoda.TabStop = true;
            this.rdoRegularSoda.Text = "Regular Soda";
            this.rdoRegularSoda.UseVisualStyleBackColor = true;
            // 
            // rdoDietSoda
            // 
            this.rdoDietSoda.AutoSize = true;
            this.rdoDietSoda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDietSoda.Location = new System.Drawing.Point(8, 25);
            this.rdoDietSoda.Name = "rdoDietSoda";
            this.rdoDietSoda.Size = new System.Drawing.Size(89, 23);
            this.rdoDietSoda.TabIndex = 1;
            this.rdoDietSoda.TabStop = true;
            this.rdoDietSoda.Text = "Diet Soda";
            this.rdoDietSoda.UseVisualStyleBackColor = true;
            // 
            // lblTotalText
            // 
            this.lblTotalText.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(581, 261);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(117, 27);
            this.lblTotalText.TabIndex = 8;
            this.lblTotalText.Text = "Total: ";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblTotal.Location = new System.Drawing.Point(585, 302);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(116, 38);
            this.lblTotal.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(126, 43);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(371, 495);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 43);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBagel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(824, 552);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.grpSoda);
            this.Controls.Add(this.grpSalad);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpMenuItems);
            this.Controls.Add(this.lblOrderNumber);
            this.Controls.Add(this.lblOrderText);
            this.Controls.Add(this.lblBCBagel);
            this.Controls.Add(this.picBCLogo);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBagel";
            this.Text = "BC Bagels";
            ((System.ComponentModel.ISupportInitialize)(this.picBCLogo)).EndInit();
            this.grpMenuItems.ResumeLayout(false);
            this.grpMenuItems.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpSalad.ResumeLayout(false);
            this.grpSalad.PerformLayout();
            this.grpSoda.ResumeLayout(false);
            this.grpSoda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBCLogo;
        private System.Windows.Forms.Label lblBCBagel;
        private System.Windows.Forms.Label lblOrderText;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.GroupBox grpMenuItems;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.GroupBox grpSalad;
        private System.Windows.Forms.GroupBox grpSoda;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.CheckBox chkSalad;
        private System.Windows.Forms.CheckBox chkBagel;
        private System.Windows.Forms.CheckBox chkCreamCheese;
        private System.Windows.Forms.CheckBox chkLox;
        private System.Windows.Forms.RadioButton rdoChef;
        private System.Windows.Forms.RadioButton rdoSpinach;
        private System.Windows.Forms.RadioButton rdoRegularSoda;
        private System.Windows.Forms.RadioButton rdoDietSoda;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

