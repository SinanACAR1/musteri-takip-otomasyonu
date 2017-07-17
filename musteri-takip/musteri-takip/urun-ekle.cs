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
  
    public partial class urun_ekle : Form
    {
      
        public urun_ekle()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
        OleDbCommand komut = new OleDbCommand();

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            komut = new OleDbCommand("insert into urun (urun_adı,urun_fiyat,urun_renk,urun_olcu) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Başarıyla Tamamlandı.","Kayıt",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
