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
    public partial class musteri_ekle : Form
    {
        public musteri_ekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into musteri (ad_soyad,urun,urun_adet,olcu,rengi,telefon,adres,borc,tarih) values ('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + comboBox2.Text + "','" + textBox4.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "')", baglan);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Müşteri Başarıyla Kayıt Edildi", "Kayıt İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("Kayıt Başarısız Oldu :(", "Başarısız Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musteri_ekle_Load(object sender, EventArgs e)
        {

            baglan.Open();
            OleDbCommand komut = new OleDbCommand("select * from urun",baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            

            while (oku.Read())
            {
                comboBox1.Items.Add(oku["urun_adı"].ToString());

               

            }
            baglan.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
         {
            baglan.Open();
            int toplam = 0;
            int sayi2 = int.Parse(textBox2.Text);
            OleDbCommand komut = new OleDbCommand("select * from urun where urun_adı like '%" + comboBox1.Text + "%'", baglan);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read()) {

                int sayi = Convert.ToInt32(oku["urun_fiyat"]);
                for (int i = 0; i < sayi2; i++)
                {
                    toplam += sayi;
                    textBox3.Text = toplam.ToString();

                }
            }

            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            baglan.Open();
            OleDbCommand komut2 = new OleDbCommand("select * from urun where urun_adı='" + comboBox1.Text + "'", baglan);
            OleDbDataReader oku2 = komut2.ExecuteReader();

            char[] splitChars = { ' ', ',', ':', '\t' };

            while (oku2.Read())
            {
                string kelime = oku2["urun_renk"].ToString();
                string[] array1 = kelime.Split(splitChars);

                string kelime2 = oku2["urun_olcu"].ToString();
                string[] array2 = kelime2.Split(splitChars);

                foreach (string yeni in array1)
                {
                    comboBox2.Items.Add(yeni);
                }

                foreach (string yeni2 in array2)
                {
                    comboBox3.Items.Add(yeni2);
                }


            }
            baglan.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
