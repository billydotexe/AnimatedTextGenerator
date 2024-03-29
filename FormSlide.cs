﻿using AnimatedTextGenerator.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedTextGenerator
{
    public partial class FormSlide : Form
    {
        private HtmlFileSlide html;
        private string res;

        public FormSlide()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            html = new Utility.HtmlFileSlide();
            res = String.Empty;
            InitializeComponent();
        }

        private void InitializeHtml()
        {
            html.Css.PrimaryColor = btnPrimaryColor.BackColor;
            html.Css.SecondaryColor = btnSecondaryColor.BackColor;
            html.Css.Speed = Int32.Parse(txtSpeed.Txt);
            html.Css.Font = btnFont.Text;
            html.Css.BorderSize = Int32.Parse(txtBorder.Txt);
            html.Text = txtText.Txt;
        }

        private void Save()
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "HTML File|*.html";
            savefile.Title = "Save as HTML file";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(res);
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (!(sender is null) && sender is Button)
            {
                Button btn = (Button)sender;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btn.BackColor = colorDialog1.Color;
                }
            }

        }

        private void btnUpDown_Click(object sender, EventArgs e)
        {
            if (!(sender is null) && sender is Button)
            {
                //var textbox = this.Controls[];
                Button btn = (Button)sender;
                string textName = $"txt{btn.Name.Replace("Up", "").Replace("Down", "").Replace("btn", "")}";

                CustomControls.MaterialTextBox text = (CustomControls.MaterialTextBox)this.Controls.Find(textName, true)[0];

                if (btn.Text == "+") text.Txt = (Int32.Parse(text.Txt) + 1).ToString();
                else if (btn.Text == "-" && Int32.Parse(text.Txt) > 1) text.Txt = (Int32.Parse(text.Txt) - 1).ToString();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            btnFont.Font = fontDialog1.Font;
            btnFont.Text = fontDialog1.Font.Name;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            InitializeHtml();
            res = html.Generate();

            Save();
        }

        private void trkTansparencyPrimary_Scroll(object sender, EventArgs e)
        {
            var color = btnPrimaryColor.BackColor;
            var newColor = Color.FromArgb(trkTansparencyPrimary.Value, color.R, color.G, color.B);
            btnPrimaryColor.BackColor = newColor;
        }

        private void trkTansparencySecondary_Scroll(object sender, EventArgs e)
        {
            var color = btnSecondaryColor.BackColor;
            var newColor = Color.FromArgb(trkTansparencySecondary.Value, color.R, color.G, color.B);
            btnSecondaryColor.BackColor = newColor;
        }
    }
}
