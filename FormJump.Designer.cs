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
            this.lblText = new MaterialSkin.Controls.MaterialLabel();
            this.txtText = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblPrimaryColor = new MaterialSkin.Controls.MaterialLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnPrimaryColor = new System.Windows.Forms.Button();
            this.btnSecondaryColor = new System.Windows.Forms.Button();
            this.lblSecondaryColor = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpSpeed = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtSpeed = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnDownSpeed = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnDownDelay = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtDelay = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnUpDelay = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Depth = 0;
            this.lblText.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblText.Location = new System.Drawing.Point(29, 99);
            this.lblText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(42, 19);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Text:";
            // 
            // txtText
            // 
            this.txtText.Depth = 0;
            this.txtText.Hint = "";
            this.txtText.Location = new System.Drawing.Point(170, 95);
            this.txtText.MaxLength = 32767;
            this.txtText.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.Size = new System.Drawing.Size(320, 23);
            this.txtText.TabIndex = 3;
            this.txtText.TabStop = false;
            this.txtText.UseSystemPasswordChar = false;
            // 
            // lblPrimaryColor
            // 
            this.lblPrimaryColor.AutoSize = true;
            this.lblPrimaryColor.Depth = 0;
            this.lblPrimaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPrimaryColor.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPrimaryColor.Location = new System.Drawing.Point(29, 149);
            this.lblPrimaryColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrimaryColor.Name = "lblPrimaryColor";
            this.lblPrimaryColor.Size = new System.Drawing.Size(105, 19);
            this.lblPrimaryColor.TabIndex = 4;
            this.lblPrimaryColor.Text = "Primary Color:";
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
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Depth = 0;
            this.lblSecondaryColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSecondaryColor.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSecondaryColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSecondaryColor.Location = new System.Drawing.Point(29, 194);
            this.lblSecondaryColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(124, 19);
            this.lblSecondaryColor.TabIndex = 6;
            this.lblSecondaryColor.Text = "Secondary Color:";
            // 
            // btnUpSpeed
            // 
            this.btnUpSpeed.AutoSize = true;
            this.btnUpSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpSpeed.Depth = 0;
            this.btnUpSpeed.Icon = null;
            this.btnUpSpeed.Location = new System.Drawing.Point(236, 250);
            this.btnUpSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpSpeed.Name = "btnUpSpeed";
            this.btnUpSpeed.Primary = false;
            this.btnUpSpeed.Size = new System.Drawing.Size(29, 36);
            this.btnUpSpeed.TabIndex = 9;
            this.btnUpSpeed.Text = "+";
            this.btnUpSpeed.UseVisualStyleBackColor = true;
            this.btnUpSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Depth = 0;
            this.txtSpeed.Enabled = false;
            this.txtSpeed.Hint = "";
            this.txtSpeed.Location = new System.Drawing.Point(202, 258);
            this.txtSpeed.MaxLength = 32767;
            this.txtSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.PasswordChar = '\0';
            this.txtSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSpeed.SelectedText = "";
            this.txtSpeed.SelectionLength = 0;
            this.txtSpeed.SelectionStart = 0;
            this.txtSpeed.Size = new System.Drawing.Size(27, 23);
            this.txtSpeed.TabIndex = 10;
            this.txtSpeed.TabStop = false;
            this.txtSpeed.Text = "1";
            this.txtSpeed.UseSystemPasswordChar = false;
            // 
            // btnDownSpeed
            // 
            this.btnDownSpeed.AutoSize = true;
            this.btnDownSpeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownSpeed.Depth = 0;
            this.btnDownSpeed.Icon = null;
            this.btnDownSpeed.Location = new System.Drawing.Point(170, 250);
            this.btnDownSpeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownSpeed.Name = "btnDownSpeed";
            this.btnDownSpeed.Primary = false;
            this.btnDownSpeed.Size = new System.Drawing.Size(25, 36);
            this.btnDownSpeed.TabIndex = 11;
            this.btnDownSpeed.Text = "-";
            this.btnDownSpeed.UseVisualStyleBackColor = true;
            this.btnDownSpeed.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(29, 258);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Speed:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(29, 316);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 16;
            this.materialLabel2.Text = "Delay:";
            // 
            // btnDownDelay
            // 
            this.btnDownDelay.AutoSize = true;
            this.btnDownDelay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDownDelay.Depth = 0;
            this.btnDownDelay.Icon = null;
            this.btnDownDelay.Location = new System.Drawing.Point(170, 308);
            this.btnDownDelay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDownDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownDelay.Name = "btnDownDelay";
            this.btnDownDelay.Primary = false;
            this.btnDownDelay.Size = new System.Drawing.Size(25, 36);
            this.btnDownDelay.TabIndex = 15;
            this.btnDownDelay.Text = "-";
            this.btnDownDelay.UseVisualStyleBackColor = true;
            this.btnDownDelay.Click += new System.EventHandler(this.btnUpDown_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.Depth = 0;
            this.txtDelay.Enabled = false;
            this.txtDelay.Hint = "";
            this.txtDelay.Location = new System.Drawing.Point(202, 316);
            this.txtDelay.MaxLength = 32767;
            this.txtDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.PasswordChar = '\0';
            this.txtDelay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDelay.SelectedText = "";
            this.txtDelay.SelectionLength = 0;
            this.txtDelay.SelectionStart = 0;
            this.txtDelay.Size = new System.Drawing.Size(27, 23);
            this.txtDelay.TabIndex = 14;
            this.txtDelay.TabStop = false;
            this.txtDelay.Text = "1";
            this.txtDelay.UseSystemPasswordChar = false;
            // 
            // btnUpDelay
            // 
            this.btnUpDelay.AutoSize = true;
            this.btnUpDelay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpDelay.Depth = 0;
            this.btnUpDelay.Icon = null;
            this.btnUpDelay.Location = new System.Drawing.Point(236, 308);
            this.btnUpDelay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpDelay.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpDelay.Name = "btnUpDelay";
            this.btnUpDelay.Primary = false;
            this.btnUpDelay.Size = new System.Drawing.Size(29, 36);
            this.btnUpDelay.TabIndex = 13;
            this.btnUpDelay.Text = "+";
            this.btnUpDelay.UseVisualStyleBackColor = true;
            this.btnUpDelay.Click += new System.EventHandler(this.btnUpDown_Click);
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
            // FormJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnDownDelay);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.btnUpDelay);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btnDownSpeed);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnUpSpeed);
            this.Controls.Add(this.btnSecondaryColor);
            this.Controls.Add(this.lblSecondaryColor);
            this.Controls.Add(this.btnPrimaryColor);
            this.Controls.Add(this.lblPrimaryColor);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Name = "FormJump";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblText;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtText;
        private MaterialSkin.Controls.MaterialLabel lblPrimaryColor;
        private ColorDialog colorDialog1;
        private Button btnPrimaryColor;
        private Button btnSecondaryColor;
        private MaterialSkin.Controls.MaterialLabel lblSecondaryColor;
        private MaterialSkin.Controls.MaterialFlatButton btnUpSpeed;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSpeed;
        private MaterialSkin.Controls.MaterialFlatButton btnDownSpeed;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnDownDelay;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDelay;
        private MaterialSkin.Controls.MaterialFlatButton btnUpDelay;
        private Button btnGenerate;
    }
}