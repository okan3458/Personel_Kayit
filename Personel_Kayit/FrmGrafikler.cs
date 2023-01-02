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
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-T6RO5C4;Initial Catalog=PersonelVeriTabani;Integrated Security=True");

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //grafik1
            baglanti.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count (*) From Tbl_Personel Group By PerSehir",baglanti);
            SqlDataReader reader1 = komutg1.ExecuteReader();
            while (reader1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(reader1[0], reader1[1]);
            }

            baglanti.Close();

            //grafik2
            baglanti.Open();
            SqlCommand komutg2 = new SqlCommand("Select PerMeslek,Avg(PerMaaş) From Tbl_Personel Group By PerMeslek", baglanti);
            SqlDataReader reader2 = komutg2.ExecuteReader();
            while (reader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(reader2[0], reader2[1]);
            }

            baglanti.Close();

        }
    }
}
