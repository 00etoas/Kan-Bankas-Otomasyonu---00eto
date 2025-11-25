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
    public partial class KanTransferi : Form
    {
        public KanTransferi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        // 1. Verileri Getirme (Hasta ve Stok)
        private void HastaGetir()
        {
            baglanti.Open();
            string query = "select * from HastaTbl"; // Hastaları çekiyoruz
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            HastaDGV.DataSource = ds.Tables[0];
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

        private void KanTransferi_Load(object sender, EventArgs e)
        {
            HastaGetir();
            StokGetir();
        }

        // 2. Tablodan Hasta Seçme (CellClick Olayı)
        // Tasarımda HastaDGV'ye tıkla -> Şimşek -> CellClick'e bağlamayı UNUTMA!
        private void HastaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.HastaDGV.Rows[e.RowIndex];
                txtAdSoyad.Text = row.Cells[1].Value.ToString(); // Hasta Adı
                txtKanGrup.Text = row.Cells[5].Value.ToString(); // Kan Grubu
            }
        }

        // 3. TRANSFER BUTONU 
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Hasta Seçiniz.");
            }
            else
            {
                try
                {
                    // ÖNCE STOK KONTROLÜ YAPMALIYIZ
                    // Stok 0 ise işlem yapamayız
                    // Bunun için küçük bir SQL sorgusu ile o grubun stoğunu soruyoruz
                    baglanti.Open();
                    string grup = txtKanGrup.Text.Trim();

                    // Sadece o kan grubunun stoğunu getir
                    SqlDataAdapter sda = new SqlDataAdapter("select KStok from KanStokTbl where KGrup='" + grup + "'", baglanti);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    // Eğer veritabanında o grup varsa
                    if (dt.Rows.Count > 0)
                    {
                        int mevcutStok = Convert.ToInt32(dt.Rows[0][0]); // Stoğu sayıya çevir

                        if (mevcutStok > 0)
                        {
                            // stok var işlem başlasın

                            // 1. Stoğu Azalt (Update)
                            string query1 = "update KanStokTbl set KStok = KStok - 1 where KGrup='" + grup + "'";
                            SqlCommand komut1 = new SqlCommand(query1, baglanti);
                            komut1.ExecuteNonQuery();

                            // 2. Transfer Geçmişine Kaydet (Insert)
                            // En başta TransferTbl oluşturmuştuk, oraya log düşek.
                            string query2 = "insert into TransferTbl values('" + txtAdSoyad.Text + "', '" + grup + "', GETDATE())"; // GETDATE() o anki tarihi atar
                            SqlCommand komut2 = new SqlCommand(query2, baglanti);
                            komut2.ExecuteNonQuery();

                            MessageBox.Show("Transfer Başarılı! Hasta İçin Kan Temin Edildi.");
                        }
                        else
                        {
                            MessageBox.Show("Yetersiz Stok! Bu gruptan kan kalmadı.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hata: Kan Grubu Bulunamadı.");
                    }

                    baglanti.Close();

                    // Tabloları Yenile
                    HastaGetir();
                    StokGetir();
                    txtAdSoyad.Text = "";
                    txtKanGrup.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        private void btnKanTransfer_Click(object sender, EventArgs e)
        {
            KanTransferi kt = new KanTransferi();
            kt.Show();
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
    }
}
