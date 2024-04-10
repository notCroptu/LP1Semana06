using System;

namespace BetterColorSpheres
{
    class Color
    {
        public byte red { get; set; }
        public byte green { get; set; }
        public byte blue { get; set; }
        public byte alpha { get; set; }
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }
        public byte GetGrey()
        {
            return (byte) ((red + green + blue) /3);
        }
    }
}
