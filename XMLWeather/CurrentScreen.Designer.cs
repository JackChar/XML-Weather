namespace XMLWeather
{
    partial class CurrentScreen
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
            this.cityOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day1Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.day3Label = new System.Windows.Forms.Label();
            this.day2Label = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(22, 63);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(137, 23);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(71, 284);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(28, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "Max";
            this.maxLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(71, 261);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(25, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "Min";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("DejaVu Sans Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(70, 236);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(191, 22);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("DejaVu Sans Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // day1Label
            // 
            this.day1Label.BackColor = System.Drawing.Color.Transparent;
            this.day1Label.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Label.ForeColor = System.Drawing.Color.White;
            this.day1Label.Location = new System.Drawing.Point(3, 306);
            this.day1Label.Name = "day1Label";
            this.day1Label.Size = new System.Drawing.Size(86, 28);
            this.day1Label.TabIndex = 41;
            this.day1Label.Text = "1-Day";
            this.day1Label.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // day3Label
            // 
            this.day3Label.BackColor = System.Drawing.Color.Transparent;
            this.day3Label.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day3Label.ForeColor = System.Drawing.Color.White;
            this.day3Label.Location = new System.Drawing.Point(178, 306);
            this.day3Label.Name = "day3Label";
            this.day3Label.Size = new System.Drawing.Size(83, 28);
            this.day3Label.TabIndex = 43;
            this.day3Label.Text = "3-Day";
            this.day3Label.Click += new System.EventHandler(this.day3Label_Click);
            // 
            // day2Label
            // 
            this.day2Label.BackColor = System.Drawing.Color.Transparent;
            this.day2Label.Font = new System.Drawing.Font("DejaVu Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day2Label.ForeColor = System.Drawing.Color.White;
            this.day2Label.Location = new System.Drawing.Point(89, 306);
            this.day2Label.Name = "day2Label";
            this.day2Label.Size = new System.Drawing.Size(83, 28);
            this.day2Label.TabIndex = 44;
            this.day2Label.Text = "2-Day";
            this.day2Label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(135, 260);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(32, 14);
            this.minOutput.TabIndex = 45;
            this.minOutput.Text = "Min";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.Font = new System.Drawing.Font("DejaVu Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(135, 284);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(32, 14);
            this.maxOutput.TabIndex = 46;
            this.maxOutput.Text = "Min";
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.White;
            this.dateOutput.Location = new System.Drawing.Point(154, 67);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(107, 53);
            this.dateOutput.TabIndex = 47;
            this.dateOutput.Text = "Date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(6, 325);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 83;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(92, 325);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(178, 325);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 85;
            this.pictureBox4.TabStop = false;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.day2Label);
            this.Controls.Add(this.day3Label);
            this.Controls.Add(this.day1Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label day1Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label day3Label;
        private System.Windows.Forms.Label day2Label;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
