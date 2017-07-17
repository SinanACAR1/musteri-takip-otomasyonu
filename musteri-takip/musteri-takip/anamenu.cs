using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musteri_takip
{
    public partial class anamenu : Form
    {
        public anamenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri_ekle musterikaydet = new musteri_ekle();
            musterikaydet.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musteri_listesi liste = new musteri_listesi();
            liste.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urun_ekle ekle = new urun_ekle();
            ekle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gecmis gecmis = new gecmis();
            gecmis.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sil sil = new sil();
            sil.Show();
        }
    }
}
