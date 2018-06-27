namespace lists_and_validation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listSimpsons = new System.Windows.Forms.ListBox();
            this.cmbNames = new System.Windows.Forms.ComboBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picCharacter = new System.Windows.Forms.PictureBox();
            this.imgCharacterList = new System.Windows.Forms.ImageList(this.components);
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblZip = new System.Windows.Forms.Label();
            this.txtZipNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // listSimpsons
            // 
            this.listSimpsons.FormattingEnabled = true;
            this.listSimpsons.Items.AddRange(new object[] {
            "Lisa",
            "Maggie",
            "Marge",
            "Krusty",
            "Grandpa",
            "Millhouse",
            "Homer",
            "Burns"});
            this.listSimpsons.Location = new System.Drawing.Point(12, 12);
            this.listSimpsons.Name = "listSimpsons";
            this.listSimpsons.Size = new System.Drawing.Size(181, 290);
            this.listSimpsons.TabIndex = 0;
            this.listSimpsons.SelectedIndexChanged += new System.EventHandler(this.listSimpsons_SelectedIndexChanged);
            // 
            // cmbNames
            // 
            this.cmbNames.FormattingEnabled = true;
            this.cmbNames.Location = new System.Drawing.Point(199, 14);
            this.cmbNames.Name = "cmbNames";
            this.cmbNames.Size = new System.Drawing.Size(121, 21);
            this.cmbNames.TabIndex = 1;
            this.cmbNames.SelectionChangeCommitted += new System.EventHandler(this.cmbNames_SelectionChangeCommitted);
            this.cmbNames.Validating += new System.ComponentModel.CancelEventHandler(this.cmbNames_Validating);
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(336, 12);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(110, 23);
            this.btnPopulate.TabIndex = 2;
            this.btnPopulate.Text = "Populate Numbers";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(336, 55);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove a Name";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(336, 103);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(110, 23);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Name";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(336, 149);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(110, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "Sort Names";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(336, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picCharacter
            // 
            this.picCharacter.Location = new System.Drawing.Point(12, 312);
            this.picCharacter.Name = "picCharacter";
            this.picCharacter.Size = new System.Drawing.Size(130, 100);
            this.picCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCharacter.TabIndex = 7;
            this.picCharacter.TabStop = false;
            // 
            // imgCharacterList
            // 
            this.imgCharacterList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCharacterList.ImageStream")));
            this.imgCharacterList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCharacterList.Images.SetKeyName(0, "burns.jpg");
            this.imgCharacterList.Images.SetKeyName(1, "homer.jpg");
            this.imgCharacterList.Images.SetKeyName(2, "krusty.jpg");
            this.imgCharacterList.Images.SetKeyName(3, "lisa.jpg");
            this.imgCharacterList.Images.SetKeyName(4, "maggie.jpg");
            this.imgCharacterList.Images.SetKeyName(5, "marge.jpg");
            this.imgCharacterList.Images.SetKeyName(6, "millhouse.jpg");
            this.imgCharacterList.Images.SetKeyName(7, "grandpa.jpg");
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 425);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 13);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Enter Phone Number:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(127, 422);
            this.txtPhoneNum.MaxLength = 12;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(146, 20);
            this.txtPhoneNum.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtPhoneNum, "XXX-XXX-XXXX");
            this.txtPhoneNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNum_Validating);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(305, 422);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(81, 13);
            this.lblZip.TabIndex = 10;
            this.lblZip.Text = "Enter Zip Code:";
            // 
            // txtZipNum
            // 
            this.txtZipNum.Location = new System.Drawing.Point(392, 422);
            this.txtZipNum.MaxLength = 12;
            this.txtZipNum.Name = "txtZipNum";
            this.txtZipNum.Size = new System.Drawing.Size(146, 20);
            this.txtZipNum.TabIndex = 11;
            this.toolTip1.SetToolTip(this.txtZipNum, "XXXXX OR XXXXX-XXXX");
            this.txtZipNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtZipNum_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 477);
            this.Controls.Add(this.txtZipNum);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.picCharacter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.cmbNames);
            this.Controls.Add(this.listSimpsons);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSimpsons;
        private System.Windows.Forms.ComboBox cmbNames;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox picCharacter;
        private System.Windows.Forms.ImageList imgCharacterList;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtZipNum;
    }
}

