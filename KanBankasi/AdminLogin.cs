using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBankasi
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void lblVazgec_Click(object sender, EventArgs e)
        {
            Login log = new Login(); // Normal giriş sayfasını hazırla
            log.Show(); // Göster
            this.Hide(); // Admin sayfasını gizle
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Programı tamamen kapatır
        }

        private void btnAdminGiris_Click(object sender, EventArgs e)
        {
            // Basit bir şifre kontrolü yapıyoruz.
            // Sen istersen "123456" yerine başka bir şey yazabilirsin.
            if (txtAdminSifre.Text == "123456")
            {
                Calisanlar cal = new Calisanlar(); // Çalışanlar sayfasına git
                cal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Admin Şifresi!");
            }
        }
    }
}
    
