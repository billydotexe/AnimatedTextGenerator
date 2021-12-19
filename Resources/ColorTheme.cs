using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimatedTextGenerator.Resources
{
    public static class ColorTheme
    {
        public static Color Primary = Color.FromArgb(0, 180, 95);
        public static Color PrimaryVariant { get; set; }

        public static Color Secondary = Color.FromArgb(25, 130, 115);
        public static Color SecondaryVariant = Color.FromArgb(25, 125, 165);
        public static Color Background = Color.FromArgb(60, 60, 60);
        public static Color Surface = Color.FromArgb(30, 30, 30);
        public static Color Error { get; set; }
        public static Color OnPrimary { get; set; }
        public static Color OnSecondary { get; set; }
        public static Color OnBackground = Color.FromArgb(240, 240, 240);
        public static Color OnSurface { get; set; }
        public static Color OnError { get; set; }
    }

}
