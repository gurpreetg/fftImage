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
            this.originalLabel = new System.Windows.Forms.Label();
            this.transformedLabel = new System.Windows.Forms.Label();
            this.FFTRadioButton = new System.Windows.Forms.RadioButton();
            this.BFTRadioButton = new System.Windows.Forms.RadioButton();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.uploadImageButton.Location = new System.Drawing.Point(25, 644);
            this.uploadImageButton.Name = "uploadImageButton";
            this.uploadImageButton.Size = new System.Drawing.Size(422, 94);
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
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Location = new System.Drawing.Point(209, 32);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(99, 17);
            this.originalLabel.TabIndex = 3;
            this.originalLabel.Text = "Original Image";
            // 
            // transformedLabel
            // 
            this.transformedLabel.AutoSize = true;
            this.transformedLabel.Location = new System.Drawing.Point(752, 35);
            this.transformedLabel.Name = "transformedLabel";
            this.transformedLabel.Size = new System.Drawing.Size(75, 17);
            this.transformedLabel.TabIndex = 4;
            this.transformedLabel.Text = "FFT Image";
            // 
            // FFTRadioButton
            // 
            this.FFTRadioButton.AutoSize = true;
            this.FFTRadioButton.Location = new System.Drawing.Point(514, 668);
            this.FFTRadioButton.Name = "FFTRadioButton";
            this.FFTRadioButton.Size = new System.Drawing.Size(198, 21);
            this.FFTRadioButton.TabIndex = 5;
            this.FFTRadioButton.TabStop = true;
            this.FFTRadioButton.Text = "Forward Fourier Transform";
            this.FFTRadioButton.UseVisualStyleBackColor = true;
            // 
            // BFTRadioButton
            // 
            this.BFTRadioButton.AutoSize = true;
            this.BFTRadioButton.Location = new System.Drawing.Point(514, 691);
            this.BFTRadioButton.Name = "BFTRadioButton";
            this.BFTRadioButton.Size = new System.Drawing.Size(200, 21);
            this.BFTRadioButton.TabIndex = 6;
            this.BFTRadioButton.TabStop = true;
            this.BFTRadioButton.Text = "BackwardFourierTransform";
            this.BFTRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(697, 573);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(159, 23);
            this.saveImageButton.TabIndex = 7;
            this.saveImageButton.Text = "Save Image";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 753);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.BFTRadioButton);
            this.Controls.Add(this.FFTRadioButton);
            this.Controls.Add(this.transformedLabel);
            this.Controls.Add(this.originalLabel);
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
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Label transformedLabel;
        private System.Windows.Forms.RadioButton FFTRadioButton;
        private System.Windows.Forms.RadioButton BFTRadioButton;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

