using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class HtmlFileJump : HtmlFile
    {
        private string _base = "<html><head><style>{0}</style></head><p>{1}</p></html>";

        public CssFileJump Css;

        public HtmlFileJump()
        {
            Css = new CssFileJump();
            Text = String.Empty;
        }
        
        public HtmlFileJump(CssFileJump Css)
        {
            this.Css = Css;
            Text = String.Empty;
        }

        private string GetText(string? text)
        {
            string res = String.Empty;
            if(!string.IsNullOrEmpty(text))
            {
                foreach(char c in text)
                {
                    res += $"<span>{c}</span>";
                }
            }
            return res;
        }

        public string Generate()
        {
            string css = Css.Generate();
            return String.Format(_base, css, GetText(Text));
        }
    }
}
