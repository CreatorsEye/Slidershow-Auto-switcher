﻿namespace GC_Panel
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
            this.sliderShow1 = new GC_Panel.SliderShow();
            this.SuspendLayout();
            // 
            // sliderShow1
            // 
            this.sliderShow1.Location = new System.Drawing.Point(23, 62);
            this.sliderShow1.Name = "sliderShow1";
            this.sliderShow1.Size = new System.Drawing.Size(573, 253);
            this.sliderShow1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 379);
            this.Controls.Add(this.sliderShow1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SliderShow sliderShow1;
    }
}

