namespace Snail2
{
    public partial class Form1 : Form
    {
        static Random Random = new Random();
   
        public Form1()
        {
            InitializeComponent();
            

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snail.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(snail.Left<this.Width-snail.Width)
            {
                
                snail.Left+=Random.Next(speed.Value);
                //snail.SetBounds(snail.Left+speed.Value,snail.Top,snail.Width,snail.Height);
                
            }
            
        }
    }
}
