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
    public partial class KanBagis : Form
    {
        public KanBagis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");
        private void KanBagis_Load(object sender, EventArgs e)
        {
            DonorGetir();
            StokGetir();
        }
        private void DonorGetir()
        {
            baglanti.Open();
            string query = "select * from DonorTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void StokGetir()
        {
            baglanti.Open();
            string query = "select * from KanStokTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            StokDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void DonorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnBagis_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtKanGrup.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Donor Seçiniz.");
            }
            else
            {
                try
                {
                    baglanti.Open();

                    // TRIM EKLENDİ: Kutudaki boşlukları temizler, net eşleşme sağlar.
                    string grup = txtKanGrup.Text.Trim();

                    // Güncelleme Sorgusu
                    string query = "update KanStokTbl set KStok = KStok + 1 where KGrup = '" + grup + "'";

                    SqlCommand komut = new SqlCommand(query, baglanti);

                    // ExecuteNonQuery kaç satırın etkilendiğini sayı olarak döndürür.
                    int sonuc = komut.ExecuteNonQuery();

                    baglanti.Close();

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Bağış Başarılı! Stok Arttırıldı.");
                        StokGetir(); // Tabloyu yenile
                        DonorGetir();
                        Reset(); // Kutuları temizle
                    }
                    else
                    {
                        // Eğer buraya düşerse sorun kan grubu eşleşmemesidir.
                        MessageBox.Show("Hata: Stok tablosunda '" + grup + "' kan grubu bulunamadı! Yazım hatası olabilir.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }
        private void Reset()
        {
            txtAdSoyad.Text = "";
            txtKanGrup.Text = "";
        }

        private void btnKanBagis_Click(object sender, EventArgs e)
        {
            KanBagis kb = new KanBagis();
            kb.Show();
            this.Hide();
        }

        private void StokDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void DonorDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DonorDGV.Rows[e.RowIndex];

                // Rakam yerine direkt veritabanındaki sütun adını yazıyoruz
                // Not: Eğer SQL'de adları DAdSoyad ve DKGrup ise böyle çalışır
                txtAdSoyad.Text = row.Cells["DAdSoyad"].Value.ToString();
                txtKanGrup.Text = row.Cells["DKGrup"].Value.ToString();
            }
        }

        private void btnDonor_Click(object sender, EventArgs e)
        {
            Donor dnr = new Donor();
            dnr.Show();
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
