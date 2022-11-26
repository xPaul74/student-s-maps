namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int optiune;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            optiune = listBox1.SelectedIndex;
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(233, 244, 177);
            label2.BackColor = Color.FromArgb(233, 244, 177);
            listBox1.BackColor = Color.FromArgb(233, 244, 177);
            
        }
    }
}