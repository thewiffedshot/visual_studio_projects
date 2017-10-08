namespace Function_Plotter
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridWidthTextBox = new System.Windows.Forms.TextBox();
            this.gridHeightTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.functionTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.scaleSlider = new System.Windows.Forms.TrackBar();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grid Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grid Height:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scale:";
            // 
            // gridWidthTextBox
            // 
            this.gridWidthTextBox.Location = new System.Drawing.Point(106, 9);
            this.gridWidthTextBox.Name = "gridWidthTextBox";
            this.gridWidthTextBox.Size = new System.Drawing.Size(166, 20);
            this.gridWidthTextBox.TabIndex = 3;
            // 
            // gridHeightTextBox
            // 
            this.gridHeightTextBox.Location = new System.Drawing.Point(112, 41);
            this.gridHeightTextBox.Name = "gridHeightTextBox";
            this.gridHeightTextBox.Size = new System.Drawing.Size(160, 20);
            this.gridHeightTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "y = ";
            // 
            // functionTextBox
            // 
            this.functionTextBox.Location = new System.Drawing.Point(43, 113);
            this.functionTextBox.Name = "functionTextBox";
            this.functionTextBox.Size = new System.Drawing.Size(229, 20);
            this.functionTextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\SovietDoggo\\Pictures\\wallpaper.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(16, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // scaleSlider
            // 
            this.scaleSlider.LargeChange = 10;
            this.scaleSlider.Location = new System.Drawing.Point(71, 68);
            this.scaleSlider.Maximum = 10000;
            this.scaleSlider.Minimum = 1;
            this.scaleSlider.Name = "scaleSlider";
            this.scaleSlider.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.scaleSlider.Size = new System.Drawing.Size(201, 45);
            this.scaleSlider.TabIndex = 9;
            this.scaleSlider.TickFrequency = 0;
            this.scaleSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleSlider.Value = 1;
            this.scaleSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.scaleLabel.Location = new System.Drawing.Point(13, 88);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(22, 17);
            this.scaleLabel.TabIndex = 10;
            this.scaleLabel.Text = "1x";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(16, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.scaleSlider);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.functionTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridHeightTextBox);
            this.Controls.Add(this.gridWidthTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Function_Plotter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox gridWidthTextBox;
        public System.Windows.Forms.TextBox gridHeightTextBox;
        public System.Windows.Forms.TextBox functionTextBox;
        public System.Windows.Forms.TrackBar scaleSlider;
    }
}

