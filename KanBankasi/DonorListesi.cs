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

namespace KanBankasi
{
    public partial class DonorListesi : Form
    {
        public DonorListesi()
        {
            InitializeComponent();
        }

        // Bağlantı Adresi
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        // 1. Verileri Veritabanından Çeken Özel Metot
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from DonorTbl"; // Tüm donorları seç
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0]; // Tabloyu verilerle doldur
            baglanti.Close();
        }

        // 2. Sayfa Yüklenirken (Load) Çalışacak Kod
        private void DonorListesi_Load(object sender, EventArgs e)
        {
            uyeler(); // Sayfa açılır açılmaz listeyi getir
        }

        // 3. Arama Yapma Kodu (Text Changed)
        // Tasarım ekranına dön, txtAra kutusuna tıkla -> Events (Şimşek) -> TextChanged olayına çift tıkla
        // Sonra bu kodu oraya yapıştır:
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            // '%değer%' yapısı, içinde o harf geçenleri bulur
            string query = "select * from DonorTbl where DAdSoyad like '%" + txtAra.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            Donor dnr = new Donor();
            dnr.Show();
            this.Hide();
        }

        private void btnDonor_Click_1(object sender, EventArgs e)
        {
            Donor dnr = new Donor();
            dnr.Show();
            this.Hide();
        }

        private void btnKanBagis_Click(object sender, EventArgs e)
        {
            KanBagis kb = new KanBagis();
            kb.Show();
            this.Hide();
        }

        private void btnKanTransfer_Click(object sender, EventArgs e)
        {
            KanTransferi kt = new KanTransferi();
            kt.Show();
            this.Hide();
        }

        private void btnKanStok_Click(object sender, EventArgs e)
        {
            KanStok ks = new KanStok();
            ks.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }

        private void btnHastaListesi_Click(object sender, EventArgs e)
        {
            HastaListesi hl = new HastaListesi();
            hl.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void btnDonorListesi_Click(object sender, EventArgs e)
        {
            DonorListesi dl = new DonorListesi();
            dl.Show();
            this.Hide();
        }
    }
}