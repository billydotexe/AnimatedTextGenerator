using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Utility
{
    internal class CssFileSlide : CssFile
    {
        private string _base = "{4}p {{font-size: 80px;color: {0};-webkit-text-stroke: {2}px {1};width: 100%;overflow: hidden;transform: translateX(-100%);animation: my-animation {3}s linear infinite;}}@keyframes my-animation {{from {{transform: translateX(-100%);}}to {{transform: translateX(100%);}}}}";
        
        public string Generate()
        {
            return String.Format(_base, GetColor(PrimaryColor), GetColor(SecondaryColor), BorderSize, Speed, GetFont());
        }
    }
}
