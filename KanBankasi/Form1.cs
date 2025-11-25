using System;
using System.Windows.Forms;

namespace KanBankasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Timer Kodu
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 2; // bu çubuğu dolduruyo + dedik çünkü 2 yi arttırırsan hızlanır

            if (progressBar1.Value >= 100) // 100 olunca
            {
                timer1.Stop();
                Login log = new Login(); // Login sayfasına git
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // sayacı baslatıyo
        }
    }
}