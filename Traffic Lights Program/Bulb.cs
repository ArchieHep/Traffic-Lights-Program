using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Lights_Program
{
    internal class Bulb
    {
        private Color _colour;
        private bool _isOn;
        private Rectangle _pos;
        public Bulb(Color colour, bool isOn, int x, int y)
        {
            _colour = colour;
            _isOn = isOn;
            _pos = new Rectangle(x, y, 50, 50);
        }
        public bool IsOn
        {
            get { return _isOn; }
            set { _isOn = value; }
        }
        public void Display (Graphics g)
        {
            SolidBrush brush;
            if (_isOn)
                brush = new SolidBrush(_colour);
            else
                brush = new SolidBrush(Color.Gray);
            g.FillEllipse(brush, _pos);
        }
    }

}
