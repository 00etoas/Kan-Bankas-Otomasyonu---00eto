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
    public partial class Calisanlar : Form
    {
        public Calisanlar()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        
        private void CalisanGetir()
        {
            baglanti.Open();
            string query = "select * from CalisanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            var ds = new DataSet();
            sda.Fill(ds);
            CalisanDGV.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Calisanlar_Load(object sender, EventArgs e)
        {
            CalisanGetir(); 
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girdiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "insert into CalisanTbl values('" + txtAdSoyad.Text + "', '" + txtSifre.Text + "')";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Başarıyla Eklendi!");
                    baglanti.Close();

                    CalisanGetir(); 
                    Reset(); // Kutuları temizlemek için yazdım
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        // Seçilen Satırın ID'sini tutmak için değişken (Silme ve Düzenleme için şart)
        int key = 0;

        // 3. LİSTEDEN SEÇME (CellClick Olayı - Tasarımdan Bağlamayı Unutma!!!!!!!!!!!)
        private void CalisanDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAdSoyad.Text = CalisanDGV.SelectedRows[0].Cells[1].Value.ToString();
                txtSifre.Text = CalisanDGV.SelectedRows[0].Cells[2].Value.ToString();

                if (txtAdSoyad.Text == "")
                {
                    key = 0;
                }
                else
                {
                    // 0. Hücre CalNum (ID) sütunudur.
                    key = Convert.ToInt32(CalisanDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        // silme işlemi 
        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Silinecek Personeli Seçiniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "delete from CalisanTbl where CalNum=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Silindi!");
                    baglanti.Close();

                    CalisanGetir();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }
            }
        }

        // düzenleme laaa
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (key == 0 || txtAdSoyad.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Düzenlenecek Personeli Seçiniz ve Bilgileri Giriniz!");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    string query = "update CalisanTbl set CalAdSoyad='" + txtAdSoyad.Text + "', CalSifre='" + txtSifre.Text + "' where CalNum=" + key + ";";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Personel Güncellendi!");
                    baglanti.Close();

                    CalisanGetir();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    baglanti.Close();
                }
            }
        }

        // Temizleme buda
        private void Reset()
        {
            txtAdSoyad.Text = "";
            txtSifre.Text = "";
            key = 0;
        }

        // Çıkış butonu 
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

        