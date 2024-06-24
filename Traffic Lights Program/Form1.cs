namespace Traffic_Lights_Program
{
    public partial class Form1 : Form
    {
        private Traffic_Light _trafficLight;
        public Form1()
        {
            InitializeComponent();
            _trafficLight = new Traffic_Light(20, 20, 0);
        }

        private void pb_canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _trafficLight.Display(g);
        }

        private void tmr_changeLight_Tick(object sender, EventArgs e)
        {
            _trafficLight.ChangeLights();
            pb_canvas.Invalidate();
        }
    }
}