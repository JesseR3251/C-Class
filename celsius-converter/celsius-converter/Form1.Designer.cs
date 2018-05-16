namespace celsius_converter
{
    partial class frmCelsiusConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCelsiusConverter));
            this.lblEnterCelcius = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.lstPictures = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterCelcius
            // 
            this.lblEnterCelcius.BackColor = System.Drawing.Color.White;
            this.lblEnterCelcius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnterCelcius.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCelcius.Location = new System.Drawing.Point(31, 77);
            this.lblEnterCelcius.Name = "lblEnterCelcius";
            this.lblEnterCelcius.Size = new System.Drawing.Size(226, 26);
            this.lblEnterCelcius.TabIndex = 0;
            this.lblEnterCelcius.Text = "Enter the Celcius Temperature:";
            this.lblEnterCelcius.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCelcius
            // 
            this.txtCelcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelcius.Location = new System.Drawing.Point(285, 77);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(69, 26);
            this.txtCelcius.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(127, 162);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(130, 39);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // picWeather
            // 
            this.picWeather.BackgroundImage = global::celsius_converter.Properties.Resources.sunny;
            this.picWeather.Location = new System.Drawing.Point(323, 220);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(100, 100);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWeather.TabIndex = 3;
            this.picWeather.TabStop = false;
            this.picWeather.Click += new System.EventHandler(this.picWeather_Click);
            // 
            // lstPictures
            // 
            this.lstPictures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstPictures.ImageStream")));
            this.lstPictures.TransparentColor = System.Drawing.Color.Transparent;
            this.lstPictures.Images.SetKeyName(0, "cold.jpg");
            this.lstPictures.Images.SetKeyName(1, "snowy.gif");
            this.lstPictures.Images.SetKeyName(2, "sunny.gif");
            // 
            // frmCelsiusConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::celsius_converter.Properties.Resources.clouds;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.lblEnterCelcius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCelsiusConverter";
            this.Text = "Celsius Converter";
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterCelcius;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.ImageList lstPictures;
    }
}

