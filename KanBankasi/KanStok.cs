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
    public partial class KanStok : Form
    {
        public KanStok()
        {
            InitializeComponent();
        }

        // Bağlantı 
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=KanBankasiDB;Integrated Security=True");

        
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

        
        private void KanStok_Load(object sender, EventArgs e)
        {
            StokGetir();
        }

        private void btnKanStok_Click(object sender, EventArgs e)
        {
            KanStok ks = new KanStok();
            ks.Show();
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

        private void btnKanTransfer_Click(object sender, EventArgs e)
        {
            KanTransferi kt = new KanTransferi();
            kt.Show();
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
