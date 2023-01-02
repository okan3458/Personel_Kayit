using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T6RO5C4;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        void Temizle()
        {
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtMeslek.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            Txtid.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            TxtAd.Focus();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = ("False");
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmGrafikler frmGrafikler = new FrmGrafikler();
            frmGrafikler.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelVeriTabaniDataSet.Tbl_Personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_PersonelTableAdapter.Fill(this.personelVeriTabaniDataSet.Tbl_Personel);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaaş,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "True";
            }

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
        

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("delete from Tbl_Personel Where Perid=@k1", baglanti);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutgucncelle = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaaş=@a4,PerDurum=@a5,PerMeslek=@a6 where Perid=@a7",baglanti);
            komutgucncelle.Parameters.AddWithValue("@a1", TxtAd.Text);
            komutgucncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutgucncelle.Parameters.AddWithValue("@a3", cmbSehir.Text);
            komutgucncelle.Parameters.AddWithValue("@a4", mskMaas.Text);
            komutgucncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutgucncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutgucncelle.Parameters.AddWithValue("@a7",Txtid.Text);
            komutgucncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");
        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }
    }
}
