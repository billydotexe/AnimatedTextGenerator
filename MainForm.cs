using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedTextGenerator
{
    public partial class MainForm : Form
    {

        Form? activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeForm(Form form, object sender)
        {
            if(activeForm == null || form.GetType() != activeForm.GetType())
            {
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = form;
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                this.panelMain.Controls.Add(form);
                this.panelMain.Tag = form;
                form.BringToFront();
                form.Show();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeForm(new FormJump(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeForm(new FormSlide(), sender);
        }
    }
}
