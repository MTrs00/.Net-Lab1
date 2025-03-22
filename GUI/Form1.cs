using zad1;

namespace GUI
{
    public partial class Form1 : Form
    {

        int seed, number;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out seed);


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out number);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Problem problem = new Problem(number, seed);
            Result result = new Result();

            result = problem.Solve(50);

            textBox3.Text = problem.ToString();
            textBox4.Text = result.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
