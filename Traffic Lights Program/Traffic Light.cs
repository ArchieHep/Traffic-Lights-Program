using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Lights_Program
{
    internal class Traffic_Light
    {
        private Bulb _red, _amber, _green;
        private Rectangle _pos;
        private int _state;

        public Traffic_Light(int x, int y, int state)
        {
            _red = new Bulb(Color.Red, false, x + 10, y + 10);
            _amber = new Bulb(Color.Orange, false, x + 10, y + 70);
            _green = new Bulb(Color.Green, false, x + 10, y + 130);
            _pos = new Rectangle(x, y, 70, 190);
            _state = state;

        }

        public void ChangeLights()
        {
            switch (_state)
            {
                case 0:
                    _red.IsOn = true;
                    _amber.IsOn = false;
                    _green.IsOn = false;
                    _state = 1;
                    break;

                case 1:
                    _red.IsOn = true;
                    _amber.IsOn = true;
                    _green.IsOn = false;
                    _state = 2;
                    break;

                case 2:
                    _red.IsOn = false;
                    _amber.IsOn = false;
                    _green.IsOn = true;
                    _state = 3;
                    break;

                case 3:
                    _red.IsOn = false;
                    _amber.IsOn = true;
                    _green.IsOn = false;
                    _state = 0;
                    break;

            }


        }
        public void Display(Graphics g)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, _pos);
            _red.Display(g);
            _amber.Display(g);
            _green.Display(g);

        }

    }
}
