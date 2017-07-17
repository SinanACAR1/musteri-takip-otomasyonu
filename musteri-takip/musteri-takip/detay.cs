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
    public partial class detay : Form
    {
        public detay()
        {
            InitializeComponent();
        }
        public string ad, urun,adet,olcu,rengi,telefon,adres,borc,tarih,id;
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("insert into gecmis (ad_soyad,urun,urun_adet,olcu,rengi,telefon,adres,borc,atarih,vtarih) values ('" + label1.Text + "','" + label2.Text + "','" + label3.Text + "','" + label4.Text + "','" + label5.Text + "','" + label6.Text + "','" + label7.Text + "','" + label8.Text + "','" + label9.Text + "','"+label21.Text+"')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();

            baglan.Open();
            OleDbCommand komut2 = new OleDbCommand();
            komut2.Connection = baglan;
            komut2.CommandText = "delete * from musteri  where id="+textBox1.Text+"";
            komut2.ExecuteNonQuery();
            baglan.Close();

            MessageBox.Show("Silme İşlemi Başarıyla Tamamlandı.\n Tabloyu Verileri Göstere Tıkladığınız da Veri Gidicektir.","Silme Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void detay_Load(object sender, EventArgs e)
        {
            label21.Text = DateTime.Now.ToLongDateString();
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
