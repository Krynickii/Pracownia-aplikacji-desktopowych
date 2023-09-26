namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = richTextBox1.TextLength.ToString();
            if (richTextBox1.Text.Any(char.IsLetter))
            {
                textBox2.Text = "TAK";
            }
            else
            {
                textBox2.Text = "NIE";
            }
            if (richTextBox1.Text.Any(char.IsDigit))
            {
                textBox3.Text = "TAK";
            }
            else
            {
                textBox3.Text = "NIE";
            }
            if (richTextBox1.Text.Any(char.IsSymbol))
            {
                textBox4.Text = "TAK";
            }
            else
            {
                textBox4.Text = "NIE";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}