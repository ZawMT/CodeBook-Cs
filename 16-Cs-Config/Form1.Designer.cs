﻿
namespace _16_Cs_Config
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
            this.btnTestConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestConfig
            // 
            this.btnTestConfig.Location = new System.Drawing.Point(624, 113);
            this.btnTestConfig.Name = "btnTestConfig";
            this.btnTestConfig.Size = new System.Drawing.Size(195, 36);
            this.btnTestConfig.TabIndex = 0;
            this.btnTestConfig.Text = "Test config";
            this.btnTestConfig.UseVisualStyleBackColor = true;
            this.btnTestConfig.Click += new System.EventHandler(this.btnTestConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 163);
            this.Controls.Add(this.btnTestConfig);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestConfig;
    }
}
