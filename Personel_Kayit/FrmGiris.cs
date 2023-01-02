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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T6RO5C4;Initial Catalog=PersonelVeriTabani;Integrated Security=True");


        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yonetici where KullaniciAd=@p1 and Sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtKullaniciSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }

            baglanti.Close();
        }
    }
}
