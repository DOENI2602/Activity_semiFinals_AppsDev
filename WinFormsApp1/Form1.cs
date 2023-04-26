namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string input1_text
        {
            set
            {
                input_textBox1.Text = value;
            }
        }
        public string input2_text
        {
            set
            {
                input_textBox2.Text = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_panel1_Click(object sender, EventArgs e)
        {
            panel_Control11.Show();
            panel_Control11.BringToFront();
            panel_Control21.Hide();

        }

        private void button_panel2_Click(object sender, EventArgs e)
        {
            panel_Control21.Show();
            panel_Control21.BringToFront();
            panel_Control11.Hide();
        }
    }
}