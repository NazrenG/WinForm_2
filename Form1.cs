namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void button1_MouseHover(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            int x = Random.Shared.Next(0, (width-button1.Size.Width));
            int y = Random.Shared.Next(0, (height - button1.Size.Height-20));
            button1.Location = new Point(x, y);
        }
    }
}