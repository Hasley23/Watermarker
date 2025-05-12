namespace watermarker
{
    partial class Watermarker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watermarker));
            this.SourceImg_label = new System.Windows.Forms.Label();
            this.OutputImg_label = new System.Windows.Forms.Label();
            this.WatermarkImg_label = new System.Windows.Forms.Label();
            this.SourceImg_pictureBox = new System.Windows.Forms.PictureBox();
            this.WatermarkImg_pictureBox = new System.Windows.Forms.PictureBox();
            this.LoadImg_button = new System.Windows.Forms.Button();
            this.LoadWatermarkImg_button = new System.Windows.Forms.Button();
            this.WatermarkIt_button = new System.Windows.Forms.Button();
            this.DestinationImg_pictureBox = new System.Windows.Forms.PictureBox();
            this.DestinationImg_label = new System.Windows.Forms.Label();
            this.SaveImg_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkImg_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationImg_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImg_label
            // 
            this.SourceImg_label.AutoSize = true;
            this.SourceImg_label.Location = new System.Drawing.Point(12, 9);
            this.SourceImg_label.Name = "SourceImg_label";
            this.SourceImg_label.Size = new System.Drawing.Size(76, 13);
            this.SourceImg_label.TabIndex = 0;
            this.SourceImg_label.Text = "Source Image:";
            // 
            // OutputImg_label
            // 
            this.OutputImg_label.AutoSize = true;
            this.OutputImg_label.Location = new System.Drawing.Point(349, 189);
            this.OutputImg_label.Name = "OutputImg_label";
            this.OutputImg_label.Size = new System.Drawing.Size(0, 13);
            this.OutputImg_label.TabIndex = 1;
            // 
            // WatermarkImg_label
            // 
            this.WatermarkImg_label.AutoSize = true;
            this.WatermarkImg_label.Location = new System.Drawing.Point(316, 10);
            this.WatermarkImg_label.Name = "WatermarkImg_label";
            this.WatermarkImg_label.Size = new System.Drawing.Size(94, 13);
            this.WatermarkImg_label.TabIndex = 2;
            this.WatermarkImg_label.Text = "Watermark Image:";
            // 
            // SourceImg_pictureBox
            // 
            this.SourceImg_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SourceImg_pictureBox.Image")));
            this.SourceImg_pictureBox.Location = new System.Drawing.Point(13, 26);
            this.SourceImg_pictureBox.Name = "SourceImg_pictureBox";
            this.SourceImg_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.SourceImg_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SourceImg_pictureBox.TabIndex = 3;
            this.SourceImg_pictureBox.TabStop = false;
            // 
            // WatermarkImg_pictureBox
            // 
            this.WatermarkImg_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WatermarkImg_pictureBox.Image")));
            this.WatermarkImg_pictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("WatermarkImg_pictureBox.InitialImage")));
            this.WatermarkImg_pictureBox.Location = new System.Drawing.Point(319, 26);
            this.WatermarkImg_pictureBox.Name = "WatermarkImg_pictureBox";
            this.WatermarkImg_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.WatermarkImg_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WatermarkImg_pictureBox.TabIndex = 4;
            this.WatermarkImg_pictureBox.TabStop = false;
            // 
            // LoadImg_button
            // 
            this.LoadImg_button.Location = new System.Drawing.Point(13, 355);
            this.LoadImg_button.Margin = new System.Windows.Forms.Padding(0);
            this.LoadImg_button.Name = "LoadImg_button";
            this.LoadImg_button.Size = new System.Drawing.Size(300, 23);
            this.LoadImg_button.TabIndex = 5;
            this.LoadImg_button.Text = "Load Image";
            this.LoadImg_button.UseVisualStyleBackColor = true;
            this.LoadImg_button.Click += new System.EventHandler(this.LoadImg_button_Click);
            // 
            // LoadWatermarkImg_button
            // 
            this.LoadWatermarkImg_button.Location = new System.Drawing.Point(320, 356);
            this.LoadWatermarkImg_button.Margin = new System.Windows.Forms.Padding(0);
            this.LoadWatermarkImg_button.Name = "LoadWatermarkImg_button";
            this.LoadWatermarkImg_button.Size = new System.Drawing.Size(300, 23);
            this.LoadWatermarkImg_button.TabIndex = 6;
            this.LoadWatermarkImg_button.Text = "Load Watermark Image";
            this.LoadWatermarkImg_button.UseVisualStyleBackColor = true;
            this.LoadWatermarkImg_button.Click += new System.EventHandler(this.LoadWatermarkImg_button_Click);
            // 
            // WatermarkIt_button
            // 
            this.WatermarkIt_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F);
            this.WatermarkIt_button.Location = new System.Drawing.Point(13, 384);
            this.WatermarkIt_button.Margin = new System.Windows.Forms.Padding(0);
            this.WatermarkIt_button.Name = "WatermarkIt_button";
            this.WatermarkIt_button.Size = new System.Drawing.Size(913, 46);
            this.WatermarkIt_button.TabIndex = 7;
            this.WatermarkIt_button.Text = "Watermark it!";
            this.WatermarkIt_button.UseVisualStyleBackColor = true;
            this.WatermarkIt_button.Click += new System.EventHandler(this.WatermarkIt_button_Click);
            // 
            // DestinationImg_pictureBox
            // 
            this.DestinationImg_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DestinationImg_pictureBox.Image")));
            this.DestinationImg_pictureBox.Location = new System.Drawing.Point(625, 26);
            this.DestinationImg_pictureBox.Name = "DestinationImg_pictureBox";
            this.DestinationImg_pictureBox.Size = new System.Drawing.Size(300, 300);
            this.DestinationImg_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DestinationImg_pictureBox.TabIndex = 8;
            this.DestinationImg_pictureBox.TabStop = false;
            // 
            // DestinationImg_label
            // 
            this.DestinationImg_label.AutoSize = true;
            this.DestinationImg_label.Location = new System.Drawing.Point(622, 10);
            this.DestinationImg_label.Name = "DestinationImg_label";
            this.DestinationImg_label.Size = new System.Drawing.Size(95, 13);
            this.DestinationImg_label.TabIndex = 9;
            this.DestinationImg_label.Text = "Destination Image:";
            // 
            // SaveImg_button
            // 
            this.SaveImg_button.Location = new System.Drawing.Point(626, 354);
            this.SaveImg_button.Margin = new System.Windows.Forms.Padding(0);
            this.SaveImg_button.Name = "SaveImg_button";
            this.SaveImg_button.Size = new System.Drawing.Size(300, 23);
            this.SaveImg_button.TabIndex = 10;
            this.SaveImg_button.Text = "Save Image";
            this.SaveImg_button.UseVisualStyleBackColor = true;
            this.SaveImg_button.Click += new System.EventHandler(this.SaveImg_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Watermark angle:";
            // 
            // numericUpDown
            // 
            this.numericUpDown.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown.Location = new System.Drawing.Point(119, 330);
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown.TabIndex = 12;
            this.numericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // Watermarker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(937, 441);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveImg_button);
            this.Controls.Add(this.DestinationImg_label);
            this.Controls.Add(this.DestinationImg_pictureBox);
            this.Controls.Add(this.WatermarkIt_button);
            this.Controls.Add(this.LoadWatermarkImg_button);
            this.Controls.Add(this.LoadImg_button);
            this.Controls.Add(this.WatermarkImg_pictureBox);
            this.Controls.Add(this.SourceImg_pictureBox);
            this.Controls.Add(this.WatermarkImg_label);
            this.Controls.Add(this.OutputImg_label);
            this.Controls.Add(this.SourceImg_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Watermarker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UkeZebrano\'s Watermarker (v. 1.1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SourceImg_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkImg_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationImg_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceImg_label;
        private System.Windows.Forms.Label OutputImg_label;
        private System.Windows.Forms.Label WatermarkImg_label;
        private System.Windows.Forms.PictureBox SourceImg_pictureBox;
        private System.Windows.Forms.PictureBox WatermarkImg_pictureBox;
        private System.Windows.Forms.Button LoadImg_button;
        private System.Windows.Forms.Button LoadWatermarkImg_button;
        private System.Windows.Forms.Button WatermarkIt_button;
        private System.Windows.Forms.PictureBox DestinationImg_pictureBox;
        private System.Windows.Forms.Label DestinationImg_label;
        private System.Windows.Forms.Button SaveImg_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown;
    }
}

