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
    public partial class gecmis_detay : Form
    {
        public gecmis_detay()
        {
            InitializeComponent();
        }
        public string ad, urun, adet, olcu, rengi, telefon, adres, borc, tarih, id;
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglan;
            komut.CommandText = "delete * from gecmis  where musteri_id=" + textBox1.Text + "";
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri Başarıyla Silindi\n Verileri Göstere Tıklayarak Yeni Verileri Görebilirsin.","Silme Mesajı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void gecmis_detay_Load(object sender, EventArgs e)
        {

            label1.Text = ad;
            label2.Text = urun;
            label3.Text = adet;
            label4.Text = olcu;
            label5.Text = rengi;
            label6.Text = telefon;
            label7.Text = adres;
            label8.Text = borc;
            label9.Text = tarih;
            textBox1.Text = id;
        }
    }
}
