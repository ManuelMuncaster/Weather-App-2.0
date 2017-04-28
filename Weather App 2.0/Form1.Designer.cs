namespace Weather_App_2._0
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
            this.exitButton = new System.Windows.Forms.Button();
            this.forecastButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.loctaionLabel = new System.Windows.Forms.Label();
            this.currentconditionLabel = new System.Windows.Forms.Label();
            this.currenttempLabel = new System.Windows.Forms.Label();
            this.conditionPicturebox = new System.Windows.Forms.PictureBox();
            this.currentdateLabel = new System.Windows.Forms.Label();
            this.currentdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(314, 357);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 36);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // forecastButton
            // 
            this.forecastButton.Location = new System.Drawing.Point(-2, 357);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(321, 36);
            this.forecastButton.TabIndex = 16;
            this.forecastButton.Text = "3 Day Forecast";
            this.forecastButton.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(326, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(69, 23);
            this.refreshButton.TabIndex = 15;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // loctaionLabel
            // 
            this.loctaionLabel.AutoSize = true;
            this.loctaionLabel.Location = new System.Drawing.Point(11, 25);
            this.loctaionLabel.Name = "loctaionLabel";
            this.loctaionLabel.Size = new System.Drawing.Size(48, 13);
            this.loctaionLabel.TabIndex = 14;
            this.loctaionLabel.Text = "Location";
            // 
            // currentconditionLabel
            // 
            this.currentconditionLabel.AutoSize = true;
            this.currentconditionLabel.Location = new System.Drawing.Point(8, 127);
            this.currentconditionLabel.Name = "currentconditionLabel";
            this.currentconditionLabel.Size = new System.Drawing.Size(51, 13);
            this.currentconditionLabel.TabIndex = 13;
            this.currentconditionLabel.Text = "Condition";
            // 
            // currenttempLabel
            // 
            this.currenttempLabel.AutoSize = true;
            this.currenttempLabel.Location = new System.Drawing.Point(11, 91);
            this.currenttempLabel.Name = "currenttempLabel";
            this.currenttempLabel.Size = new System.Drawing.Size(11, 13);
            this.currenttempLabel.TabIndex = 12;
            this.currenttempLabel.Text = "°";
            // 
            // conditionPicturebox
            // 
            this.conditionPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.conditionPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionPicturebox.Location = new System.Drawing.Point(106, 6);
            this.conditionPicturebox.Name = "conditionPicturebox";
            this.conditionPicturebox.Size = new System.Drawing.Size(178, 134);
            this.conditionPicturebox.TabIndex = 11;
            this.conditionPicturebox.TabStop = false;
            // 
            // currentdateLabel
            // 
            this.currentdateLabel.AutoSize = true;
            this.currentdateLabel.Location = new System.Drawing.Point(8, 181);
            this.currentdateLabel.Name = "currentdateLabel";
            this.currentdateLabel.Size = new System.Drawing.Size(30, 13);
            this.currentdateLabel.TabIndex = 10;
            this.currentdateLabel.Text = "Date";
            // 
            // currentdayLabel
            // 
            this.currentdayLabel.AutoSize = true;
            this.currentdayLabel.Location = new System.Drawing.Point(11, 58);
            this.currentdayLabel.Name = "currentdayLabel";
            this.currentdayLabel.Size = new System.Drawing.Size(26, 13);
            this.currentdayLabel.TabIndex = 9;
            this.currentdayLabel.Text = "Day";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_App_2._0.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(408, 398);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.forecastButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loctaionLabel);
            this.Controls.Add(this.currentconditionLabel);
            this.Controls.Add(this.currenttempLabel);
            this.Controls.Add(this.conditionPicturebox);
            this.Controls.Add(this.currentdateLabel);
            this.Controls.Add(this.currentdayLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.conditionPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button forecastButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label loctaionLabel;
        private System.Windows.Forms.Label currentconditionLabel;
        private System.Windows.Forms.Label currenttempLabel;
        private System.Windows.Forms.PictureBox conditionPicturebox;
        private System.Windows.Forms.Label currentdateLabel;
        private System.Windows.Forms.Label currentdayLabel;
    }
}

