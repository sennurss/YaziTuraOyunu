using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaziTura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonTemizle.Enabled = false;
        }

        private void buttonOyna_Click(object sender, EventArgs e)
        {
            Random yaziturauretici = new Random();
            int yazitura = Convert.ToInt32(yaziturauretici.Next(0, 2));
            switch (yazitura)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\asus\Desktop\CSharp\Odevler\YaziTura\Yazi.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    labelSonuc.Text = "Yazı";
                    break;

                case 1:
                    pictureBox1.Image = Image.FromFile(@"C:\Users\asus\Desktop\CSharp\Odevler\YaziTura\Tura.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    labelSonuc.Text = "Tura";
                    break;


            }

            buttonOyna.Enabled = false;
            buttonTemizle.Enabled = true;
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            buttonOyna.Enabled = true;
            buttonTemizle.Enabled = false;
        }
    }
}
