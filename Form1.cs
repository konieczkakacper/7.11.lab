using System.ComponentModel;

namespace makeitgreen_kk
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            dlg.Filter = "Image |*.png;*.jpg";
            dlg.FileOk += Dlg_FileOk;
            textBox1.Text = dlg.FileName;
        }

        private void Dlg_FileOk(object sender, CancelEventArgs e)
        {
            OpenFileDialog o = sender as OpenFileDialog;
            pictureBox1.Load(o.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(textBox1.Text);
        }
    }
}