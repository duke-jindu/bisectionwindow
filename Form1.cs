namespace bisectionwindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, tolerance, midPoint, roots;
            x1 = Convert.ToDouble(textBox1.Text);
            x2 = Convert.ToDouble(textBox2.Text);
            tolerance = Convert.ToDouble(textBox3.Text);
            midPoint = (x1 + x2) / 2;
            textBox5.Text = midPoint.ToString("n");
            roots = Math.Pow(2, midPoint) - 8 * midPoint;
            textBox4.Text = roots.ToString("n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}