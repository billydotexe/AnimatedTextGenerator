using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class HtmlFile
    {
        private string _base = "<html><head><style>{0}</style></head><p>{1}</p></html>";

        public CssFile Css;
        public string Text { get; set; }

        public HtmlFile()
        {
            Css = new CssFile();
            Text = String.Empty;
        }
        
        public HtmlFile(CssFile Css)
        {
            this.Css = Css;
            Text = String.Empty;
        }

        public string Generate()
        {
            string css = Css.Generate();
            return String.Format(_base, css, GetText(Text));
        }

        private string GetText(string text)
        {
            string res = String.Empty;
            foreach(char c in text)
            {
                res += $"<span>{c}</span>";
            }
            return res;
        }
    }
}
