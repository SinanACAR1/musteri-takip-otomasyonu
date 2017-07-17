using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace musteri_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from admin where kullaniciadi='"+textBox1.Text+ "' AND sifre='"+textBox2.Text+"'",baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                anamenu anamenu = new anamenu();
                anamenu.Show();
                baglanti.Close();
                this.Hide();

            }else if(textBox1.Text == "" || textBox2.Text == "")
            {
                label3.Text = "Lütfen Alanları Boş Bırakmayınız";

            }
            else
            {
                label3.Text = "Kullanıcı Adınız Veya Şifeniz Yanlış";
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
