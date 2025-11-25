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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        private void VerileriSay()
        {
            try
            {
                baglanti.Open();

                // 1. Donor Sayısını Çek 
                SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from DonorTbl", baglanti);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                label3.Text = dt1.Rows[0][0].ToString();

                // 2. Transfer Sayısını Çek 
                SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from TransferTbl", baglanti);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                lblTransferSayisi.Text = dt2.Rows[0][0].ToString();

                // 3. Personel Sayısını Çek
                SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from CalisanTbl", baglanti);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                lblKullaniciSayisi.Text = dt3.Rows[0][0].ToString();

                // 4. Toplam Stok Sayısını Çek (SUM - Hepsini Topla)
                // Not: Eğer stok boşsa hata vermesin diye ISNULL kullandık.
                SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from KanStokTbl where KStok > 0", baglanti);
                // VEYA toplam ünite sayısı istiyorsan: "select SUM(KStok) from KanStokTbl"
                // Biz şimdilik "Kaç grupta stok var" veya "Toplam Ünite" mantığını kullanalım. 
                // Aşağıdaki kod TOPLAM ÜNİTE sayısını verir:
                SqlDataAdapter sdaSum = new SqlDataAdapter("select SUM(KStok) from KanStokTbl", baglanti);
                DataTable dt4 = new DataTable();
                sdaSum.Fill(dt4);

                // Eğer veritabanı boşsa hata vermesin
                if (dt4.Rows[0][0].ToString() != "")
                {
                    lblToplamStok.Text = dt4.Rows[0][0].ToString();
                }
                else
                {
                    lblToplamStok.Text = "0";
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                baglanti.Close();
            }
        }

        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            VerileriSay();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnDonor_Click(object sender, EventArgs e)
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

        private void btnDonorListesi_Click(object sender, EventArgs e)
        {
            DonorListesi dl = new DonorListesi();
            dl.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            Hasta hst = new Hasta();
            hst.Show();
            this.Hide();
        }

        private void btnHastaListesi_Click(object sender, EventArgs e)
        {
            HastaListesi hl = new HastaListesi();
            hl.Show();
            this.Hide();
        }

        private void btnKanStok_Click(object sender, EventArgs e)
        {
            KanStok ks = new KanStok();
            ks.Show();
            this.Hide();
        }

        private void btnKanTransfer_Click(object sender, EventArgs e)
        {
            KanTransferi kt = new KanTransferi();
            kt.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
            this.Hide();
        }
    }
}