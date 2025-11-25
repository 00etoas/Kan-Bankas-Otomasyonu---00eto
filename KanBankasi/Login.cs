using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KanBankasi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        // Eğer butona çift tıkladıysan bu kod oluşmuştur, içi boş kalsın şimdilik
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifreyi Giriniz.");
            }
            else
            {
                try
                {
                    baglanti.Open(); // Kapıyı çal
                    // Veritabanında bu kullanıcı var mı diye soruyoruz
                    string sorgu = "select count(*) from CalisanTbl where CalAdSoyad='" + txtKullanici.Text + "' and CalSifre='" + txtSifre.Text + "'";

                    SqlDataAdapter sda = new SqlDataAdapter(sorgu, baglanti);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    sda.Fill(dt);

                    // Eğer sonuç 1 ise (yani böyle biri varsa)
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Anasayfa ana = new Anasayfa(); // Anasayfayı hazırla
                        ana.Show(); // Göster
                        this.Hide(); // Giriş ekranını gizle
                    }
                    else
                    {
                        MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre!");
                    }
                    baglanti.Close(); // Kapıyı kapat
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı Hatası: " + ex.Message);
                    baglanti.Close();
                }
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            AdminLogin adm = new AdminLogin(); // Admin sayfasını hazırla
            adm.Show(); // Göster
            this.Hide(); // Mevcut sayfayı gizle
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programı tamamen kapatır
        }
    }
}