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
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.maxOutput = new System.Windows.Forms.Label();
            this.currentTempOutput = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pre = new System.Windows.Forms.Label();
            this.prec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(225, 75);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(81, 18);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "Stratford";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(167, 202);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(33, 16);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(236, 256);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(45, 25);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(171, 265);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(29, 16);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(69, 133);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(131, 16);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current Temperature";
            // 
            // date1
            // 
            this.date1.BackColor = System.Drawing.Color.Transparent;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(224, 38);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(83, 28);
            this.date1.TabIndex = 40;
            this.date1.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Maroon;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(250, 375);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(101, 32);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "Forecast";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "label1";
            // 
            // tabLabel
            // 
            this.tabLabel.AutoSize = true;
            this.tabLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.tabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabLabel.Location = new System.Drawing.Point(-2, 375);
            this.tabLabel.Name = "tabLabel";
            this.tabLabel.Size = new System.Drawing.Size(246, 25);
            this.tabLabel.TabIndex = 43;
            this.tabLabel.Text = "Today\'s Weather (Open)";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(357, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(87, 32);
            this.exitButton.TabIndex = 44;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(236, 193);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(45, 25);
            this.maxOutput.TabIndex = 45;
            // 
            // currentTempOutput
            // 
            this.currentTempOutput.BackColor = System.Drawing.Color.White;
            this.currentTempOutput.Location = new System.Drawing.Point(236, 124);
            this.currentTempOutput.Name = "currentTempOutput";
            this.currentTempOutput.Size = new System.Drawing.Size(45, 25);
            this.currentTempOutput.TabIndex = 46;
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.Yellow;
            this.weatherLabel.Location = new System.Drawing.Point(389, 312);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(55, 16);
            this.weatherLabel.TabIndex = 47;
            this.weatherLabel.Text = "weather";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(332, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 136);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // pre
            // 
            this.pre.BackColor = System.Drawing.Color.White;
            this.pre.Location = new System.Drawing.Point(236, 312);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(45, 25);
            this.pre.TabIndex = 49;
            // 
            // prec
            // 
            this.prec.AutoSize = true;
            this.prec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prec.ForeColor = System.Drawing.Color.White;
            this.prec.Location = new System.Drawing.Point(136, 321);
            this.prec.Name = "prec";
            this.prec.Size = new System.Drawing.Size(81, 16);
            this.prec.TabIndex = 50;
            this.prec.Text = "precipitation\r\n";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.prec);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.currentTempOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tabLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(529, 400);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tabLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label currentTempOutput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label pre;
        private System.Windows.Forms.Label prec;
    }
}
