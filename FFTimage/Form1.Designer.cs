namespace FFTimage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uploadImageButton = new System.Windows.Forms.Button();
            this.uploadedPictureBox = new System.Windows.Forms.PictureBox();
            this.fftPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uploadedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uploadImageButton
            // 
            this.uploadImageButton.Location = new System.Drawing.Point(321, 600);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(424, 61);
            this.uploadImageButton.TabIndex = 0;
            this.uploadImageButton.Text = "Upload Image";
            this.uploadImageButton.UseVisualStyleBackColor = true;
            this.uploadImageButton.Click += new System.EventHandler(this.uploadImageButton_Click);
            // 
            // uploadedPictureBox
            // 
            this.uploadedPictureBox.Location = new System.Drawing.Point(12, 55);
            this.uploadedPictureBox.Name = "uploadedPictureBox";
            this.uploadedPictureBox.Size = new System.Drawing.Size(512, 512);
            this.uploadedPictureBox.TabIndex = 1;
            this.uploadedPictureBox.TabStop = false;
            // 
            // fftPictureBox
            // 
            this.fftPictureBox.Location = new System.Drawing.Point(531, 55);
            this.fftPictureBox.Name = "fftPictureBox";
            this.fftPictureBox.Size = new System.Drawing.Size(512, 512);
            this.fftPictureBox.TabIndex = 2;
            this.fftPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(752, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "FFT Image";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fftPictureBox);
            this.Controls.Add(this.uploadedPictureBox);
            this.Controls.Add(this.uploadImageButton);
            this.Name = "Form1";
            this.Text = "fftImage Coverter";
            ((System.ComponentModel.ISupportInitialize)(this.uploadedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fftPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button uploadImageButton;
        private System.Windows.Forms.PictureBox uploadedPictureBox;
        private System.Windows.Forms.PictureBox fftPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

