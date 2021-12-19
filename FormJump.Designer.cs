﻿using AnimatedTextGenerator.Resources;

namespace AnimatedTextGenerator
{
    partial class FormJump
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPrimaryColor = new System.Windows.Forms.Button();
            this.btnSecondaryColor = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblPrimaryColor = new System.Windows.Forms.Label();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.btnUpSpeed = new System.Windows.Forms.Button();
            this.btnUpDelay = new System.Windows.Forms.Button();
            this.btnDownSpeed = new System.Windows.Forms.Button();
            this.btnDownDelay = new System.Windows.Forms.Button();
            this.txtText = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.txtSpeed = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.txtDelay = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnPrimaryColor
            // 
            this.btnPrimaryColor.Location = new System.Drawing.Point(170, 149);
            this.btnPrimaryColor.Name = "btnPrimaryColor";
            this.btnPrimaryColor.Size = new System.Drawing.Size(75, 23);
            this.btnPrimaryColor.TabIndex = 5;
            this.btnPrimaryColor.UseVisualStyleBackColor = true;
            this.btnPrimaryColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSecondaryColor
            // 
            this.btnSecondaryColor.Location = new System.Drawing.Point(170, 193);
            this.btnSecondaryColor.Name = "btnSecondaryColor";
            this.btnSecondaryColor.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryColor.TabIndex = 7;
            this.btnSecondaryColor.UseVisualStyleBackColor = true;
            this.btnSecondaryColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(348, 381);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 42);
            this.btnGenerate.TabIndex = 17;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblText.Location = new System.Drawing.Point(29, 100);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 18);
            this.lblText.TabIndex = 18;
            this.lblText.Text = "Text:";
            // 
            // lblPrimaryColor
            // 
            this.lblPrimaryColor.AutoSize = true;
            this.lblPrimaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPrimaryColor.Location = new System.Drawing.Point(29, 150);
            this.lblPrimaryColor.Name = "lblPrimaryColor";
            this.lblPrimaryColor.Size = new System.Drawing.Size(104, 18);
            this.lblPrimaryColor.TabIndex = 19;
            this.lblPrimaryColor.Text = "Primary Color:";
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSecondaryColor.Location = new System.Drawing.Point(29, 194);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(124, 18);
            this.lblSecondaryColor.TabIndex = 20;
            this.lblSecondaryColor.Text = "Secondary Color:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSpeed.Location = new System.Drawing.Point(34, 244);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(54, 18);
            this.lblSpeed.TabIndex = 21;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDelay.Location = new System.Drawing.Point(34, 298);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(49, 18);
            this.lblDelay.TabIndex = 22;
            this.lblDelay.Text = "Delay:";
            // 
            // btnUpSpeed
            // 
            this.btnUpSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpSpeed.FlatAppearance.BorderSize = 0;
            this.btnUpSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpSpeed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpSpeed.Location = new System.Drawing.Point(236, 235);
            this.btnUpSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpSpeed.Name = "btnUpSpeed";
            this.btnUpSpeed.Size = new System.Drawing.Size(36, 36);
            this.btnUpSpeed.TabIndex = 9;
            this.btnUpSpeed.Text = "+";
            this.btnUpSpeed.UseVisualStyleBackColor = true;
            this.btnUpSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnUpDelay
            // 
            this.btnUpDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpDelay.FlatAppearance.BorderSize = 0;
            this.btnUpDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpDelay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpDelay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpDelay.Location = new System.Drawing.Point(236, 290);
            this.btnUpDelay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpDelay.Name = "btnUpDelay";
            this.btnUpDelay.Size = new System.Drawing.Size(36, 36);
            this.btnUpDelay.TabIndex = 24;
            this.btnUpDelay.Text = "+";
            this.btnUpDelay.UseVisualStyleBackColor = true;
            this.btnUpDelay.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnDownSpeed
            // 
            this.btnDownSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownSpeed.FlatAppearance.BorderSize = 0;
            this.btnDownSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownSpeed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDownSpeed.Location = new System.Drawing.Point(159, 235);
            this.btnDownSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownSpeed.Name = "btnDownSpeed";
            this.btnDownSpeed.Size = new System.Drawing.Size(36, 36);
            this.btnDownSpeed.TabIndex = 25;
            this.btnDownSpeed.Text = "-";
            this.btnDownSpeed.UseVisualStyleBackColor = true;
            this.btnDownSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnDownDelay
            // 
            this.btnDownDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownDelay.FlatAppearance.BorderSize = 0;
            this.btnDownDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownDelay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownDelay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDownDelay.Location = new System.Drawing.Point(159, 290);
            this.btnDownDelay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownDelay.Name = "btnDownDelay";
            this.btnDownDelay.Size = new System.Drawing.Size(36, 36);
            this.btnDownDelay.TabIndex = 26;
            this.btnDownDelay.Text = "-";
            this.btnDownDelay.UseVisualStyleBackColor = true;
            this.btnDownDelay.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // txtText
            // 
            this.txtText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtText.BorderSize = 1;
            this.txtText.Location = new System.Drawing.Point(159, 100);
            this.txtText.Margin = new System.Windows.Forms.Padding(0);
            this.txtText.Name = "txtText";
            this.txtText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtText.Size = new System.Drawing.Size(250, 23);
            this.txtText.TabIndex = 27;
            this.txtText.Txt = "";
            // 
            // txtSpeed
            // 
            this.txtSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSpeed.BorderSize = 1;
            this.txtSpeed.Enabled = false;
            this.txtSpeed.Location = new System.Drawing.Point(202, 248);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtSpeed.Size = new System.Drawing.Size(27, 23);
            this.txtSpeed.TabIndex = 28;
            this.txtSpeed.Txt = "1";
            // 
            // txtDelay
            // 
            this.txtDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDelay.BorderSize = 1;
            this.txtDelay.Enabled = false;
            this.txtDelay.Location = new System.Drawing.Point(202, 298);
            this.txtDelay.Margin = new System.Windows.Forms.Padding(0);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtDelay.Size = new System.Drawing.Size(27, 23);
            this.txtDelay.TabIndex = 31;
            this.txtDelay.Txt = "1";
            // 
            // FormJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnDownDelay);
            this.Controls.Add(this.btnDownSpeed);
            this.Controls.Add(this.btnUpDelay);
            this.Controls.Add(this.btnUpSpeed);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSecondaryColor);
            this.Controls.Add(this.lblPrimaryColor);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSecondaryColor);
            this.Controls.Add(this.btnPrimaryColor);
            this.Name = "FormJump";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ColorDialog colorDialog1;
        private Button btnPrimaryColor;
        private Button btnSecondaryColor;
        private Button btnGenerate;
        private Label lblText;
        private Label lblPrimaryColor;
        private Label lblSecondaryColor;
        private Label lblSpeed;
        private Label lblDelay;
        private Button btnUpSpeed;
        private Button btnUpDelay;
        private Button btnDownSpeed;
        private Button btnDownDelay;
        private CustomControls.MaterialTextBox txtText;
        private AnimatedTextGenerator.CustomControls.MaterialTextBox txtSpeed;
        private CustomControls.MaterialTextBox txtDelay;
    }
}