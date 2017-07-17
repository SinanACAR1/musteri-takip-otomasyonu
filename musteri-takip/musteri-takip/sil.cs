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
    public partial class sil : Form
    {
        public sil()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;

        private void sil_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from urun ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            baglan.Open();
            OleDbCommand komut = new OleDbCommand("delete * from urun where urun_adı='"+textBox1.Text+"'",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Veri Başarıyla Silindi\n Verileri Göstere Tıklayarak Yeni Verileri Görebilirsin.", "Silme Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from urun ", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "urun");
            dataGridView1.DataSource = ds.Tables["urun"];
            con.Close();
        }
    }
}
