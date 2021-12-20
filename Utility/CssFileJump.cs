using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class CssFileJump : CssFile
    {
        public int Delay { get; set; }
        public int Repeats { get; set; }

        private string _base = "{4}span {{position: relative;padding: 0;}}p {{font-size: 80px;color: {0};-webkit-text-stroke: {2}px {1};}}{3}@keyframes jump {{0% {{top: 0px;}}50% {{top: 30px;}}100% {{top: 0px;}}}}";
        private string _cssDelay = "span:nth-child({0}n) {{animation: jump {1}s infinite;-webkit-animation: jump {1}s infinite;animation-delay: {2}s;}}";

        private string GetDelay()
        {
            string delay = String.Empty;

            for(int i = 0; i < Delay; i++)
            {
                delay += String.Format(_cssDelay, i+1, Speed, ((float)i)/10);
            }
            return delay;
        }

        public string Generate()
        {
            return String.Format(_base, GetColor(PrimaryColor), GetColor(SecondaryColor), BorderSize, GetDelay(), GetFont());
        }
    }
}
