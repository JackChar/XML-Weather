namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("DejaVu Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(103, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(147, 28);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "7 Day";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Today";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(76, 71);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(44, 19);
            this.date1.TabIndex = 60;
            this.date1.Text = "Date";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 63;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // max1
            // 
            this.max1.AutoSize = true;
            this.max1.Font = new System.Drawing.Font("DejaVu Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(113, 334);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(166, 19);
            this.max1.TabIndex = 64;
            this.max1.Text = " Min Temperature";
            // 
            // min1
            // 
            this.min1.AutoSize = true;
            this.min1.Font = new System.Drawing.Font("DejaVu Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.ForeColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(116, 364);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(166, 19);
            this.min1.TabIndex = 65;
            this.min1.Text = " Min Temperature";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XMLWeather.Properties.Resources.sun;
            this.pictureBox1.InitialImage = global::XMLWeather.Properties.Resources.sun;
            this.pictureBox1.Location = new System.Drawing.Point(29, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = " Min ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "Max";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
