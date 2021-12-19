using System.Globalization;
using AnimatedTextGenerator.Resources;

namespace AnimatedTextGenerator
{
    public partial class FormJump : Form
    {
        Utility.HtmlFile html;
        string res;

        public FormJump()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            html = new Utility.HtmlFile();
            res = String.Empty;

            InitializeComponent();

            btnPrimaryColor.BackColor = Color.Black;
            btnSecondaryColor.BackColor = Color.Black;

            // Create a material theme manager and add the form to manage(this)
            //MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            //// Configure color schema
            //materialSkinManager.ColorScheme = new ColorScheme(
            //    Primary.Green400, Primary.Green500,
            //    Primary.Green500, Accent.LightGreen200,
            //    TextShade.WHITE
            //);
        }

        private void InitializeHtml()
        {
            html.Css.PrimaryColor = btnPrimaryColor.BackColor;
            html.Css.SecondaryColor = btnSecondaryColor.BackColor;
            html.Css.Speed = Int32.Parse(txtSpeed.Txt);
            html.Css.Delay = Int32.Parse(txtDelay.Txt);
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
            if(!(sender is null) && sender is Button)
            {
                Button btn = (Button)sender;
                if(colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    btn.BackColor = colorDialog1.Color;
                }
            }
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            InitializeHtml();
            res = html.Generate();

            Save();

        }

        private void btnUpDown_Click(object sender, EventArgs e)
        {
            if(!(sender is null) && sender is Button)
            {
                //var textbox = this.Controls[];
                Button btn = (Button)sender;
                string textName = $"txt{btn.Name.Replace("Up", "").Replace("Down", "").Replace("btn", "")}";

                CustomControls.MaterialTextBox text = (CustomControls.MaterialTextBox) this.Controls.Find(textName, true)[0];

                if (btn.Text == "+") text.Txt = (Int32.Parse(text.Txt) + 1).ToString();
                else if(btn.Text == "-" && Int32.Parse(text.Txt) > 1) text.Txt = (Int32.Parse(text.Txt) - 1).ToString();
            }
        }
    }
}