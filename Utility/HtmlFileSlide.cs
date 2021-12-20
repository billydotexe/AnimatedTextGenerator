using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class HtmlFileSlide : HtmlFile
    {
        private string _base = "<html><head><style>{0}</style></head><body><p>{1}<p></body></html>";
        public CssFileSlide Css;
        
        public HtmlFileSlide()
        {
            Css = new CssFileSlide();
            Text = string.Empty;
        }

        public HtmlFileSlide(CssFileSlide Css)
        {
            this.Css = Css;
            Text = string.Empty;
        }

        public string Generate()
        {
            string css = Css.Generate();
            return String.Format(_base, css, Text);
        }

    }
}
