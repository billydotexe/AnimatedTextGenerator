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
        public int Delay { get; set; }
        public int Repeats { get; set; }

        private string _base = "{3}span {{position: relative;padding: 0;}}p {{font-size: 80px;color: {0};-webkit-text-stroke: 2px {1};}}{2}@keyframes jump {{0% {{top: 0px;}}50% {{top: 30px;}}100% {{top: 0px;}}}}";
        private string _cssDelay = "span:nth-child({0}n) {{animation: jump {1}s infinite;-webkit-animation: jump {1}s infinite;animation-delay: {2}s;}}";

        private string GetColor(Color color)
        {
            int r, g, b, a;
            r = color.R;
            g = color.G;
            b = color.B;
            a = color.A;
            return string.Format("rgba({0}, {1}, {2}, {3})", r, g, b, ((float)a)/255);
        }

        private string GetDelay()
        {
            string delay = String.Empty;

            for(int i = 0; i < Delay; i++)
            {
                delay += String.Format(_cssDelay, i+1, Speed, ((float)i)/10);
            }
            return delay;
        }

        private string GetFont()
        {
            string font = String.Empty;
            if (!String.IsNullOrEmpty(Font))
            {
                font = $"p {{font-family: '{Font}';}} ";
            }
            return font;
        }

    public string Generate()
        {
            return String.Format(_base, GetColor(PrimaryColor), GetColor(SecondaryColor), GetDelay(), GetFont());
        }
    }
}
