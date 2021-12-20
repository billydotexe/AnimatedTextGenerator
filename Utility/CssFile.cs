using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class CssFile
    {

        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }
        public int TextSize { get; set; }
        public int BorderSize { get; set; }
        public string? Font { get; set; }
        public int Speed { get; set; }

        protected string GetColor(Color color)
        {
            int r, g, b, a;
            r = color.R;
            g = color.G;
            b = color.B;
            a = color.A;
            return string.Format("rgba({0}, {1}, {2}, {3})", r, g, b, ((float)a) / 255);
        }

        protected string GetFont()
        {
            string font = String.Empty;
            if (!String.IsNullOrEmpty(Font))
            {
                font = $"p {{font-family: '{Font}';}} ";
            }
            return font;
        }
    }
}
