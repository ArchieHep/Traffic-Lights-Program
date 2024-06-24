namespace Traffic_Lights_Program
{
    public partial class Form1 : Form
    {
        private Bulb _bulb;
        public Form1()
        {
            InitializeComponent();
            _bulb = new Bulb(Color.Red, true, 20, 20);
        }

        private void pb_canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            _bulb.Display(g);
        }

        private void tmr_changeLight_Tick(object sender, EventArgs e)
        {
            _bulb.IsOn = !_bulb.IsOn;
            pb_canvas.Invalidate();
        }
    }
}