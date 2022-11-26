namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int optiune;
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(233, 244, 177);
            label2.BackColor = Color.FromArgb(233, 244, 177);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            optiune = 0;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            optiune = 1;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            optiune = 2;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}