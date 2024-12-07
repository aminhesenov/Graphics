namespace Graphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = this.CreateGraphics();

            SolidBrush sb = new SolidBrush(Color.Orange);

            //Pen
            Pen p=new Pen(sb);
            gr.DrawArc(p, new Rectangle(10, 10, 200, 200), 0, 360);

            //Ellipse
            //gr.FillEllipse(sb, new Rectangle(10, 10, 200, 100));

            //Rectangle
            //gr.FillRectangle(sb, new Rectangle(10,10,200,200));

            //Region
            //Rectangle rt = new Rectangle(10, 10, 200, 200);
            //Region rg= new Region(rt);
            //gr.FillRegion(sb, rg);

            //Pie



        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i += 10;
            Graphics gr = this.CreateGraphics();

            SolidBrush sb = new SolidBrush(Color.OrangeRed);
           
            gr.FillPie(sb, new Rectangle(10, 10, 200, 200), 0, i);
            
        }
    }
}
