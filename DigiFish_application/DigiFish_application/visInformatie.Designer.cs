﻿namespace DigiFish_application
{
    partial class visInformatie
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
            this.lvVisInformatie = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvVisInformatie
            // 
            this.lvVisInformatie.HideSelection = false;
            this.lvVisInformatie.Location = new System.Drawing.Point(13, 13);
            this.lvVisInformatie.Name = "lvVisInformatie";
            this.lvVisInformatie.Size = new System.Drawing.Size(294, 325);
            this.lvVisInformatie.TabIndex = 0;
            this.lvVisInformatie.UseCompatibleStateImageBehavior = false;
            // 
            // visInformatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 350);
            this.Controls.Add(this.lvVisInformatie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "visInformatie";
            this.Text = "visInformatie";
            this.Load += new System.EventHandler(this.visInformatie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvVisInformatie;
    }
}