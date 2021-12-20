namespace AnimatedTextGenerator
{
    partial class FormSlide
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
            this.btnFont = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trkTansparencySecondary = new System.Windows.Forms.TrackBar();
            this.trkTansparencyPrimary = new System.Windows.Forms.TrackBar();
            this.txtSpeed = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.txtText = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.btnDownSpeed = new System.Windows.Forms.Button();
            this.btnUpSpeed = new System.Windows.Forms.Button();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.lblPrimaryColor = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSecondaryColor = new System.Windows.Forms.Button();
            this.btnPrimaryColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtBorder = new AnimatedTextGenerator.CustomControls.MaterialTextBox();
            this.btnDownBorder = new System.Windows.Forms.Button();
            this.btnUpBorder = new System.Windows.Forms.Button();
            this.lblBorder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkTansparencySecondary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTansparencyPrimary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(146, 274);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(91, 23);
            this.btnFont.TabIndex = 55;
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Font:";
            // 
            // trkTansparencySecondary
            // 
            this.trkTansparencySecondary.Location = new System.Drawing.Point(276, 130);
            this.trkTansparencySecondary.Maximum = 255;
            this.trkTansparencySecondary.Name = "trkTansparencySecondary";
            this.trkTansparencySecondary.Size = new System.Drawing.Size(104, 45);
            this.trkTansparencySecondary.TabIndex = 53;
            this.trkTansparencySecondary.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkTansparencySecondary.Value = 255;
            this.trkTansparencySecondary.Scroll += new System.EventHandler(this.trkTansparencySecondary_Scroll);
            // 
            // trkTansparencyPrimary
            // 
            this.trkTansparencyPrimary.Location = new System.Drawing.Point(276, 86);
            this.trkTansparencyPrimary.Maximum = 255;
            this.trkTansparencyPrimary.Name = "trkTansparencyPrimary";
            this.trkTansparencyPrimary.Size = new System.Drawing.Size(104, 45);
            this.trkTansparencyPrimary.TabIndex = 52;
            this.trkTansparencyPrimary.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkTansparencyPrimary.Value = 255;
            this.trkTansparencyPrimary.Scroll += new System.EventHandler(this.trkTansparencyPrimary_Scroll);
            // 
            // txtSpeed
            // 
            this.txtSpeed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtSpeed.BorderSize = 1;
            this.txtSpeed.Enabled = false;
            this.txtSpeed.Location = new System.Drawing.Point(199, 229);
            this.txtSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtSpeed.Size = new System.Drawing.Size(27, 23);
            this.txtSpeed.TabIndex = 50;
            this.txtSpeed.Txt = "1";
            // 
            // txtText
            // 
            this.txtText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtText.BorderSize = 1;
            this.txtText.Location = new System.Drawing.Point(151, 26);
            this.txtText.Margin = new System.Windows.Forms.Padding(0);
            this.txtText.Name = "txtText";
            this.txtText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtText.Size = new System.Drawing.Size(250, 23);
            this.txtText.TabIndex = 49;
            this.txtText.Txt = "";
            // 
            // btnDownSpeed
            // 
            this.btnDownSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownSpeed.FlatAppearance.BorderSize = 0;
            this.btnDownSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownSpeed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDownSpeed.Location = new System.Drawing.Point(156, 216);
            this.btnDownSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownSpeed.Name = "btnDownSpeed";
            this.btnDownSpeed.Size = new System.Drawing.Size(36, 36);
            this.btnDownSpeed.TabIndex = 47;
            this.btnDownSpeed.Text = "-";
            this.btnDownSpeed.UseVisualStyleBackColor = true;
            this.btnDownSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnUpSpeed
            // 
            this.btnUpSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpSpeed.FlatAppearance.BorderSize = 0;
            this.btnUpSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpSpeed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpSpeed.Location = new System.Drawing.Point(233, 216);
            this.btnUpSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpSpeed.Name = "btnUpSpeed";
            this.btnUpSpeed.Size = new System.Drawing.Size(36, 36);
            this.btnUpSpeed.TabIndex = 39;
            this.btnUpSpeed.Text = "+";
            this.btnUpSpeed.UseVisualStyleBackColor = true;
            this.btnUpSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSpeed.Location = new System.Drawing.Point(26, 225);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(54, 18);
            this.lblSpeed.TabIndex = 44;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSecondaryColor.Location = new System.Drawing.Point(26, 131);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(124, 18);
            this.lblSecondaryColor.TabIndex = 43;
            this.lblSecondaryColor.Text = "Secondary Color:";
            // 
            // lblPrimaryColor
            // 
            this.lblPrimaryColor.AutoSize = true;
            this.lblPrimaryColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPrimaryColor.Location = new System.Drawing.Point(26, 87);
            this.lblPrimaryColor.Name = "lblPrimaryColor";
            this.lblPrimaryColor.Size = new System.Drawing.Size(104, 18);
            this.lblPrimaryColor.TabIndex = 42;
            this.lblPrimaryColor.Text = "Primary Color:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblText.Location = new System.Drawing.Point(26, 37);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 18);
            this.lblText.TabIndex = 41;
            this.lblText.Text = "Text:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Location = new System.Drawing.Point(340, 307);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 42);
            this.btnGenerate.TabIndex = 40;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSecondaryColor
            // 
            this.btnSecondaryColor.BackColor = System.Drawing.Color.Black;
            this.btnSecondaryColor.Location = new System.Drawing.Point(167, 130);
            this.btnSecondaryColor.Name = "btnSecondaryColor";
            this.btnSecondaryColor.Size = new System.Drawing.Size(75, 23);
            this.btnSecondaryColor.TabIndex = 38;
            this.btnSecondaryColor.UseVisualStyleBackColor = false;
            this.btnSecondaryColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnPrimaryColor
            // 
            this.btnPrimaryColor.BackColor = System.Drawing.Color.Black;
            this.btnPrimaryColor.Location = new System.Drawing.Point(167, 86);
            this.btnPrimaryColor.Name = "btnPrimaryColor";
            this.btnPrimaryColor.Size = new System.Drawing.Size(75, 23);
            this.btnPrimaryColor.TabIndex = 37;
            this.btnPrimaryColor.UseVisualStyleBackColor = false;
            this.btnPrimaryColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtBorder
            // 
            this.txtBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtBorder.BorderSize = 1;
            this.txtBorder.Enabled = false;
            this.txtBorder.Location = new System.Drawing.Point(199, 184);
            this.txtBorder.Margin = new System.Windows.Forms.Padding(0);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.txtBorder.Size = new System.Drawing.Size(27, 23);
            this.txtBorder.TabIndex = 59;
            this.txtBorder.Txt = "1";
            // 
            // btnDownBorder
            // 
            this.btnDownBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownBorder.FlatAppearance.BorderSize = 0;
            this.btnDownBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownBorder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownBorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDownBorder.Location = new System.Drawing.Point(156, 171);
            this.btnDownBorder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownBorder.Name = "btnDownBorder";
            this.btnDownBorder.Size = new System.Drawing.Size(36, 36);
            this.btnDownBorder.TabIndex = 58;
            this.btnDownBorder.Text = "-";
            this.btnDownBorder.UseVisualStyleBackColor = true;
            this.btnDownBorder.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // btnUpBorder
            // 
            this.btnUpBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpBorder.FlatAppearance.BorderSize = 0;
            this.btnUpBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpBorder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpBorder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpBorder.Location = new System.Drawing.Point(233, 171);
            this.btnUpBorder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpBorder.Name = "btnUpBorder";
            this.btnUpBorder.Size = new System.Drawing.Size(36, 36);
            this.btnUpBorder.TabIndex = 56;
            this.btnUpBorder.Text = "+";
            this.btnUpBorder.UseVisualStyleBackColor = true;
            this.btnUpBorder.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // lblBorder
            // 
            this.lblBorder.AutoSize = true;
            this.lblBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblBorder.Location = new System.Drawing.Point(26, 180);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(65, 18);
            this.lblBorder.TabIndex = 57;
            this.lblBorder.Text = "Borders:";
            // 
            // FormSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBorder);
            this.Controls.Add(this.btnDownBorder);
            this.Controls.Add(this.btnUpBorder);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkTansparencySecondary);
            this.Controls.Add(this.trkTansparencyPrimary);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnDownSpeed);
            this.Controls.Add(this.btnUpSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblSecondaryColor);
            this.Controls.Add(this.lblPrimaryColor);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSecondaryColor);
            this.Controls.Add(this.btnPrimaryColor);
            this.Name = "FormSlide";
            this.Text = "FormSlide";
            ((System.ComponentModel.ISupportInitialize)(this.trkTansparencySecondary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkTansparencyPrimary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFont;
        private FontDialog fontDialog1;
        private Label label1;
        private TrackBar trkTansparencySecondary;
        private TrackBar trkTansparencyPrimary;
        private CustomControls.MaterialTextBox txtSpeed;
        private CustomControls.MaterialTextBox txtText;
        private Button btnDownSpeed;
        private Button btnUpSpeed;
        private Label lblSpeed;
        private Label lblSecondaryColor;
        private Label lblPrimaryColor;
        private Label lblText;
        private Button btnGenerate;
        private Button btnSecondaryColor;
        private Button btnPrimaryColor;
        private ColorDialog colorDialog1;
        private CustomControls.MaterialTextBox txtBorder;
        private Button btnDownBorder;
        private Button btnUpBorder;
        private Label lblBorder;
    }
}