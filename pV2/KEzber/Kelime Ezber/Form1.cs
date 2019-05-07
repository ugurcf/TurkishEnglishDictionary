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


namespace Kelime_Ezber
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-ONB0MHF9;Initial Catalog=KelimeHavuzu; Integrated Security=True;");
        public void verilerigoster(string veriler)
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ileriGezinme(Button button)
        {
            if (button == btnİstatistikler)
            {

            }
        }

        private void Ortala(Panel a)
        {
            a.Location = new Point(
            this.ClientSize.Width / 2 - a.Size.Width / 2,
            this.ClientSize.Height / 2 - a.Size.Height / 2);
            a.Anchor = AnchorStyles.None;
        }



        private void btnKelimeHavuzu_Click(object sender, EventArgs e)
        {
            verilerigoster("Select * from khavuzu");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into  khavuzu (TurkceKelime,IngilizceKelime,KelimeninTuru,KelimeDurumu) values (@turkcesi,@ingilizcesi,@turu,@durumu)", baglanti);
            komut.Parameters.AddWithValue("@turkcesi", txtKelimeTürkçe.Text);
            komut.Parameters.AddWithValue("@ingilizcesi", txtKelimeİngilizce.Text);
            komut.Parameters.AddWithValue("@turu", cmbKelimeTürü.Text);
            komut.Parameters.AddWithValue("@durumu", cmbKelimeDurum.Text);
            komut.ExecuteNonQuery();
            verilerigoster("Select * from khavuzu");
            baglanti.Close();
;        }

        private void btnAyarDevam_Click(object sender, EventArgs e)
        {
         
        }

        private void btnKullanıcıDeğiştir_Click(object sender, EventArgs e)
        {
            txtAyarTekrarŞifre.Visible = false;
            lblTekrar.Visible = false;
        }

        private void pnKelimeEkleme_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
