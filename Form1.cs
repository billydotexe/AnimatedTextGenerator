using MaterialSkin;
using System.Globalization;
using MaterialSkin.Controls;

namespace AnimatedTextGenerator
{
    public partial class Form1 : MaterialForm
    {
        Utility.HtmlFile html;
        string res;

        public Form1()
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            html = new Utility.HtmlFile();
            res = String.Empty;

            InitializeComponent();

            btnPrimaryColor.BackColor = Color.Black;
            btnSecondaryColor.BackColor = Color.Black;

            // Create a material theme manager and add the form to manage(this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green400, Primary.Green500,
                Primary.Green500, Accent.LightGreen200,
                TextShade.WHITE
            );
        }

        private void InitializeHtml()
        {
            html.Css.PrimaryColor = btnPrimaryColor.BackColor;
            html.Css.SecondaryColor = btnSecondaryColor.BackColor;
            html.Css.Speed = Int32.Parse(txtSpeed.Text);
            html.Css.Delay = Int32.Parse(txtDelay.Text);
            html.Text = txtText.Text;
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
                Button btn = sender as Button;
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
                Button btn = sender as Button;
                string textName = $"txt{btn.Name.Replace("Up", "").Replace("Down", "").Replace("btn", "")}";

                MaterialSkin.Controls.MaterialSingleLineTextField text = (MaterialSkin.Controls.MaterialSingleLineTextField) this.Controls.Find(textName, true)[0];

                if (btn.Text == "+") text.Text = (Int32.Parse(text.Text) + 1).ToString();
                else if(btn.Text == "-" && Int32.Parse(text.Text) > 1) text.Text = (Int32.Parse(text.Text) - 1).ToString();
            }
        }
    }
}