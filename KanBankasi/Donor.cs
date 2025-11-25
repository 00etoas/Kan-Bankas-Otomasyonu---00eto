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
    public partial class Donor : Form
    {
        public Donor()
        {
            InitializeComponent();
        }

        // SQL Bağlantısı 
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. Boş alan kontrolü
            if (txtAdSoyad.Text == "" || txtYas.Text == "" || txtTelefon.Text == "" || cmbCinsiyet.SelectedIndex == -1 || cmbKanGrubu.SelectedIndex == -1 || txtAdres.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!");
            }
            else
            {
                try
                {
                    // 2. Veritabanına Ekleme İşlemi
                    baglanti.Open();

                    // SQL Sorgusu: Insert into (Tablo) values (Değerler)
                    string query = "insert into DonorTbl values('" + txtAdSoyad.Text + "', " + txtYas.Text + ", '" + cmbCinsiyet.SelectedItem.ToString() + "', '" + txtTelefon.Text + "', '" + cmbKanGrubu.SelectedItem.ToString() + "', '" + txtAdres.Text + "')";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery(); // Sorguyu çalıştır

                    MessageBox.Show("Donor Başarıyla Kaydedildi!");

                    baglanti.Close();

                    // 3. Kayıttan sonra kutuları temizleyelim
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        // Kutuları temizleme metodu
        private void Reset()
        {
            txtAdSoyad.Text = "";
            txtYas.Text = "";
            txtTelefon.Text = "";
            cmbCinsiyet.SelectedIndex = -1;
            cmbKanGrubu.SelectedIndex = -1;
            txtAdres.Text = "";
        }

        private void btnDonorListesi_Click(object sender, EventArgs e)
        {
            DonorListesi dl = new DonorListesi();
            dl.Show();
            this.Hide();
        }

        private void btnKanBagis_Click(object sender, EventArgs e)
        {
            KanBagis kb = new KanBagis();
            kb.Show();
            this.Hide();
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

        private void Donor_Load(object sender, EventArgs e)
        {

        }
    }
}