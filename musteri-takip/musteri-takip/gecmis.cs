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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;

        OleDbConnection con2;
        OleDbDataAdapter da2;
        DataSet ds2;
        private void gecmis_Load(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from gecmis where atarih='"+tarih+"'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView1.DataSource = ds.Tables["gecmis"];
            con.Close();

            con2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da2 = new OleDbDataAdapter("Select *from gecmis ", con2);
            ds2 = new DataSet();
            con2.Open();
            da2.Fill(ds2, "gecmis");
            dataGridView2.DataSource = ds2.Tables["gecmis"];
            con2.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gecmis_detay gdetay = new gecmis_detay();
            int i;
            i = dataGridView1.SelectedCells[0].RowIndex;
            gdetay.ad = dataGridView1.Rows[i].Cells[1].Value.ToString();
            gdetay.urun = dataGridView1.Rows[i].Cells[2].Value.ToString();
            gdetay.adet = dataGridView1.Rows[i].Cells[3].Value.ToString();
            gdetay.olcu = dataGridView1.Rows[i].Cells[4].Value.ToString();
            gdetay.rengi = dataGridView1.Rows[i].Cells[5].Value.ToString();
            gdetay.telefon = dataGridView1.Rows[i].Cells[6].Value.ToString();
            gdetay.adres = dataGridView1.Rows[i].Cells[7].Value.ToString();
            gdetay.borc = dataGridView1.Rows[i].Cells[8].Value.ToString();
            gdetay.tarih = dataGridView1.Rows[i].Cells[9].Value.ToString();
            gdetay.id = dataGridView1.Rows[i].Cells[0].Value.ToString();


            gdetay.ShowDialog();

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gecmis_detay gdetay = new gecmis_detay();
            int i;
            i = dataGridView2.SelectedCells[0].RowIndex;
            gdetay.ad = dataGridView2.Rows[i].Cells[1].Value.ToString();
            gdetay.urun = dataGridView2.Rows[i].Cells[2].Value.ToString();
            gdetay.adet = dataGridView2.Rows[i].Cells[3].Value.ToString();
            gdetay.olcu = dataGridView2.Rows[i].Cells[4].Value.ToString();
            gdetay.rengi = dataGridView2.Rows[i].Cells[5].Value.ToString();
            gdetay.telefon = dataGridView2.Rows[i].Cells[6].Value.ToString();
            gdetay.adres = dataGridView2.Rows[i].Cells[7].Value.ToString();
            gdetay.borc = dataGridView2.Rows[i].Cells[8].Value.ToString();
            gdetay.tarih = dataGridView2.Rows[i].Cells[9].Value.ToString();
            gdetay.id = dataGridView2.Rows[i].Cells[0].Value.ToString();


            gdetay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString();

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select * from gecmis where ad_soyad='" + textBox1.Text + "' and atarih='"+tarih+"'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView1.DataSource = ds.Tables["gecmis"];
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from gecmis where atarih='" + tarih + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView1.DataSource = ds.Tables["gecmis"];
            con.Close();


            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from gecmis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView2.DataSource = ds.Tables["gecmis"];
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select * from gecmis where ad_soyad='" + textBox2.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView2.DataSource = ds.Tables["gecmis"];
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from gecmis", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView2.DataSource = ds.Tables["gecmis"];
            con.Close();

            string tarih = DateTime.Now.ToLongDateString();
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt.accdb;Persist Security Info=False;");
            da = new OleDbDataAdapter("Select *from gecmis where atarih='" + tarih + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "gecmis");
            dataGridView1.DataSource = ds.Tables["gecmis"];
            con.Close();

        }
    }
}
