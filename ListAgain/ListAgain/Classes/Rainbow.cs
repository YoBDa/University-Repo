using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ListAgain.Classes
{
    class Rainbow : IEnumerator<Color>
    {
        private int r = 255;
        private int g = 0;
        private int b = 0;


        Color IEnumerator<Color>.Current => (Color)Current;

        public object Current => Color.FromArgb(r, g, b);

        public bool MoveNext()
        {
            if (r > 200 && g < 200 && b == 0)
                g += 51;

            if (g > 200 && r > 50 && b == 0)
                r -= 51;

            if (g > 200 && b < 200 && r == 0)
                b += 51;

            if (b > 200 && g > 50 && r == 0)
                g -= 51;

            if (b > 200 && r < 200 && g == 0)
                r += 51;

            if (r > 200 && b > 50 && g == 0)
                b -= 51;
            return true;

        }

        public void Reset()
        {
            r = 255;
            g = 0;
            b = 0;
        }

        public void Dispose()
        {
            
        }
    }
}
