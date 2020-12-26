using System;
using System.Windows.Forms;

namespace EBSİmageYazıYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        OpenFileDialog op;
        private void button1_Click(object sender, EventArgs e)
        {
            EbsFacebookProfilİmageCreater.create(pictureBox1,txtx,txty,txtad,txtsoyad,"",256,256);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK) 
            {
                pictureBox1.ImageLocation = op.FileName.ToString();
            }
        }
    }
}
