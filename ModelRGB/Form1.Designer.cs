
namespace ModelRGB
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.pictureRed = new System.Windows.Forms.PictureBox();
            this.pictureGreen = new System.Windows.Forms.PictureBox();
            this.pictureBlue = new System.Windows.Forms.PictureBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginal.Location = new System.Drawing.Point(11, 23);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(250, 212);
            this.pictureOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // pictureRed
            // 
            this.pictureRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureRed.Location = new System.Drawing.Point(295, 23);
            this.pictureRed.Name = "pictureRed";
            this.pictureRed.Size = new System.Drawing.Size(250, 212);
            this.pictureRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRed.TabIndex = 1;
            this.pictureRed.TabStop = false;
            // 
            // pictureGreen
            // 
            this.pictureGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureGreen.Location = new System.Drawing.Point(551, 23);
            this.pictureGreen.Name = "pictureGreen";
            this.pictureGreen.Size = new System.Drawing.Size(250, 212);
            this.pictureGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGreen.TabIndex = 2;
            this.pictureGreen.TabStop = false;
            // 
            // pictureBlue
            // 
            this.pictureBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBlue.Location = new System.Drawing.Point(807, 23);
            this.pictureBlue.Name = "pictureBlue";
            this.pictureBlue.Size = new System.Drawing.Size(250, 212);
            this.pictureBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBlue.TabIndex = 3;
            this.pictureBlue.TabStop = false;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(11, 250);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(336, 250);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 5;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 281);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.pictureBlue);
            this.Controls.Add(this.pictureGreen);
            this.Controls.Add(this.pictureRed);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "Form1";
            this.Text = "Rizki Ali Akbar Pasaribu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.PictureBox pictureRed;
        private System.Windows.Forms.PictureBox pictureGreen;
        private System.Windows.Forms.PictureBox pictureBlue;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonConvert;
    }
}

