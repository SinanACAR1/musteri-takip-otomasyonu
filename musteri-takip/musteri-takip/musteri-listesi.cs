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
    public partial class musteri_listesi : Form
    {
        public musteri_listesi()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        private void musteri_listesi_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            detay detay = new detay();
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            detay.ad = dataGridView1.Rows[i].Cells[1].Value.ToString();
            detay.urun = dataGridView1.Rows[i].Cells[2].Value.ToString();
            detay.adet = dataGridView1.Rows[i].Cells[3].Value.ToString();
            detay.olcu = dataGridView1.Rows[i].Cells[4].Value.ToString();
            detay.rengi = dataGridView1.Rows[i].Cells[5].Value.ToString();
            detay.telefon = dataGridView1.Rows[i].Cells[6].Value.ToString();
            detay.adres = dataGridView1.Rows[i].Cells[7].Value.ToString();
            detay.borc = dataGridView1.Rows[i].Cells[8].Value.ToString();
            detay.tarih = dataGridView1.Rows[i].Cells[9].Value.ToString();
            detay.id = dataGridView1.Rows[i].Cells[0].Value.ToString();





            detay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from musteri", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from musteri where ad_soyad='"+textBox1.Text+"'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteri");
            dataGridView1.DataSource = ds.Tables["musteri"];
            con.Close();
        }
    }
}
