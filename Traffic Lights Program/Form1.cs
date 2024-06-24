namespace Traffic_Lights_Program
{
    public partial class Form1 : Form
    {
        private Traffic_Light _trafficLight, _trafficLight2;
        public Form1()
        {
            InitializeComponent();
            _trafficLight = new Traffic_Light(20, 20, 0);
            _trafficLight2 = new Traffic_Light(100, 20, 2);
        }

        private void pb_canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _trafficLight.Display(g);
            _trafficLight2.Display(g);

        }

        private void tmr_changeLight_Tick(object sender, EventArgs e)
        {
            _trafficLight.ChangeLights();
            _trafficLight2.ChangeLights();
            pb_canvas.Invalidate();
        }
    }
}