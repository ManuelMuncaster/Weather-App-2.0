namespace Weather_App_2._0
{
    partial class Current
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
            this.exitButton = new System.Windows.Forms.Button();
            this.forecastButton = new System.Windows.Forms.Button();
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
            this.exitButton.BackColor = System.Drawing.Color.Gray;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Prestige Elite Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(306, 3);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 26);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // forecastButton
            // 
            this.forecastButton.BackColor = System.Drawing.Color.Gray;
            this.forecastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forecastButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.forecastButton.FlatAppearance.BorderSize = 2;
            this.forecastButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.forecastButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.forecastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastButton.Font = new System.Drawing.Font("Prestige Elite Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastButton.ForeColor = System.Drawing.Color.White;
            this.forecastButton.Location = new System.Drawing.Point(0, 349);
            this.forecastButton.Name = "forecastButton";
            this.forecastButton.Size = new System.Drawing.Size(408, 49);
            this.forecastButton.TabIndex = 25;
            this.forecastButton.Text = "3 Day Forecast";
            this.forecastButton.UseVisualStyleBackColor = false;
            this.forecastButton.Click += new System.EventHandler(this.forecastButton_Click);
            // 
            // loctaionLabel
            // 
            this.loctaionLabel.AutoSize = true;
            this.loctaionLabel.BackColor = System.Drawing.Color.Transparent;
            this.loctaionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loctaionLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loctaionLabel.ForeColor = System.Drawing.Color.Black;
            this.loctaionLabel.Location = new System.Drawing.Point(53, 3);
            this.loctaionLabel.Name = "loctaionLabel";
            this.loctaionLabel.Size = new System.Drawing.Size(98, 28);
            this.loctaionLabel.TabIndex = 23;
            this.loctaionLabel.Text = "Location";
            // 
            // currentconditionLabel
            // 
            this.currentconditionLabel.AutoSize = true;
            this.currentconditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentconditionLabel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentconditionLabel.ForeColor = System.Drawing.Color.Black;
            this.currentconditionLabel.Location = new System.Drawing.Point(74, 143);
            this.currentconditionLabel.Name = "currentconditionLabel";
            this.currentconditionLabel.Size = new System.Drawing.Size(77, 22);
            this.currentconditionLabel.TabIndex = 22;
            this.currentconditionLabel.Text = "Condition";
            // 
            // currenttempLabel
            // 
            this.currenttempLabel.AutoSize = true;
            this.currenttempLabel.BackColor = System.Drawing.Color.Transparent;
            this.currenttempLabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currenttempLabel.ForeColor = System.Drawing.Color.Black;
            this.currenttempLabel.Location = new System.Drawing.Point(51, 205);
            this.currenttempLabel.Name = "currenttempLabel";
            this.currenttempLabel.Size = new System.Drawing.Size(33, 44);
            this.currenttempLabel.TabIndex = 21;
            this.currenttempLabel.Text = "°";
            // 
            // conditionPicturebox
            // 
            this.conditionPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.conditionPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.conditionPicturebox.Location = new System.Drawing.Point(33, 44);
            this.conditionPicturebox.Name = "conditionPicturebox";
            this.conditionPicturebox.Size = new System.Drawing.Size(202, 96);
            this.conditionPicturebox.TabIndex = 20;
            this.conditionPicturebox.TabStop = false;
            // 
            // currentdateLabel
            // 
            this.currentdateLabel.AutoSize = true;
            this.currentdateLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentdateLabel.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentdateLabel.ForeColor = System.Drawing.Color.Black;
            this.currentdateLabel.Location = new System.Drawing.Point(3, 252);
            this.currentdateLabel.Name = "currentdateLabel";
            this.currentdateLabel.Size = new System.Drawing.Size(40, 20);
            this.currentdateLabel.TabIndex = 19;
            this.currentdateLabel.Text = "Date";
            // 
            // currentdayLabel
            // 
            this.currentdayLabel.AutoSize = true;
            this.currentdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentdayLabel.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentdayLabel.ForeColor = System.Drawing.Color.Black;
            this.currentdayLabel.Location = new System.Drawing.Point(4, 177);
            this.currentdayLabel.Name = "currentdayLabel";
            this.currentdayLabel.Size = new System.Drawing.Size(52, 28);
            this.currentdayLabel.TabIndex = 18;
            this.currentdayLabel.Text = "Day";
            // 
            // Current
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Weather_App_2._0.Properties.Resources.Background;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.forecastButton);
            this.Controls.Add(this.loctaionLabel);
            this.Controls.Add(this.currentconditionLabel);
            this.Controls.Add(this.currenttempLabel);
            this.Controls.Add(this.conditionPicturebox);
            this.Controls.Add(this.currentdateLabel);
            this.Controls.Add(this.currentdayLabel);
            this.Name = "Current";
            this.Size = new System.Drawing.Size(408, 398);
            ((System.ComponentModel.ISupportInitialize)(this.conditionPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button forecastButton;
        private System.Windows.Forms.Label loctaionLabel;
        private System.Windows.Forms.Label currentconditionLabel;
        private System.Windows.Forms.Label currenttempLabel;
        private System.Windows.Forms.PictureBox conditionPicturebox;
        private System.Windows.Forms.Label currentdateLabel;
        private System.Windows.Forms.Label currentdayLabel;
    }
}
