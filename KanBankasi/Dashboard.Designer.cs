namespace KanBankasi
{
    partial class Dashboard
    {
        
        private System.ComponentModel.IContainer components = null;

        
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDonorListesi = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnKanTransfer = new System.Windows.Forms.Button();
            this.btnKanStok = new System.Windows.Forms.Button();
            this.btnHastaListesi = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.btnKanBagis = new System.Windows.Forms.Button();
            this.btnDonor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTransferSayisi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblKullaniciSayisi = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblToplamStok = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 54);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kan Bankası Yönetim Sistemi - Kontrol Paneli";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDonorListesi);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnKanTransfer);
            this.panel1.Controls.Add(this.btnKanStok);
            this.panel1.Controls.Add(this.btnHastaListesi);
            this.panel1.Controls.Add(this.btnHasta);
            this.panel1.Controls.Add(this.btnKanBagis);
            this.panel1.Controls.Add(this.btnDonor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 600);
            this.panel1.TabIndex = 2;
            // 
            // btnDonorListesi
            // 
            this.btnDonorListesi.FlatAppearance.BorderSize = 0;
            this.btnDonorListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonorListesi.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonorListesi.ForeColor = System.Drawing.Color.White;
            this.btnDonorListesi.Location = new System.Drawing.Point(24, 121);
            this.btnDonorListesi.Name = "btnDonorListesi";
            this.btnDonorListesi.Size = new System.Drawing.Size(149, 37);
            this.btnDonorListesi.TabIndex = 8;
            this.btnDonorListesi.Text = "Donor Listesi";
            this.btnDonorListesi.UseVisualStyleBackColor = true;
            this.btnDonorListesi.Click += new System.EventHandler(this.btnDonorListesi_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.Color.White;
            this.btnCikis.Location = new System.Drawing.Point(24, 551);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(149, 37);
            this.btnCikis.TabIndex = 7;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(24, 508);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(149, 37);
            this.btnDashboard.TabIndex = 6;
            this.btnDashboard.Text = "Kontrol Paneli";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnKanTransfer
            // 
            this.btnKanTransfer.FlatAppearance.BorderSize = 0;
            this.btnKanTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanTransfer.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanTransfer.ForeColor = System.Drawing.Color.White;
            this.btnKanTransfer.Location = new System.Drawing.Point(24, 293);
            this.btnKanTransfer.Name = "btnKanTransfer";
            this.btnKanTransfer.Size = new System.Drawing.Size(149, 37);
            this.btnKanTransfer.TabIndex = 5;
            this.btnKanTransfer.Text = "Kan Transferi";
            this.btnKanTransfer.UseVisualStyleBackColor = true;
            this.btnKanTransfer.Click += new System.EventHandler(this.btnKanTransfer_Click);
            // 
            // btnKanStok
            // 
            this.btnKanStok.FlatAppearance.BorderSize = 0;
            this.btnKanStok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanStok.Font = new System.Drawing.Font("Mongolian Baiti", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanStok.ForeColor = System.Drawing.Color.White;
            this.btnKanStok.Location = new System.Drawing.Point(24, 250);
            this.btnKanStok.Name = "btnKanStok";
            this.btnKanStok.Size = new System.Drawing.Size(149, 37);
            this.btnKanStok.TabIndex = 4;
            this.btnKanStok.Text = "Kan Stoğu";
            this.btnKanStok.UseVisualStyleBackColor = true;
            this.btnKanStok.Click += new System.EventHandler(this.btnKanStok_Click);
            // 
            // btnHastaListesi
            // 
            this.btnHastaListesi.FlatAppearance.BorderSize = 0;
            this.btnHastaListesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHastaListesi.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHastaListesi.ForeColor = System.Drawing.Color.White;
            this.btnHastaListesi.Location = new System.Drawing.Point(24, 207);
            this.btnHastaListesi.Name = "btnHastaListesi";
            this.btnHastaListesi.Size = new System.Drawing.Size(149, 37);
            this.btnHastaListesi.TabIndex = 3;
            this.btnHastaListesi.Text = "Hasta Listesi";
            this.btnHastaListesi.UseVisualStyleBackColor = true;
            this.btnHastaListesi.Click += new System.EventHandler(this.btnHastaListesi_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.FlatAppearance.BorderSize = 0;
            this.btnHasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHasta.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHasta.ForeColor = System.Drawing.Color.White;
            this.btnHasta.Location = new System.Drawing.Point(24, 164);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(149, 37);
            this.btnHasta.TabIndex = 2;
            this.btnHasta.Text = "Hasta";
            this.btnHasta.UseVisualStyleBackColor = true;
            this.btnHasta.Click += new System.EventHandler(this.btnHasta_Click);
            // 
            // btnKanBagis
            // 
            this.btnKanBagis.FlatAppearance.BorderSize = 0;
            this.btnKanBagis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanBagis.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanBagis.ForeColor = System.Drawing.Color.White;
            this.btnKanBagis.Location = new System.Drawing.Point(24, 78);
            this.btnKanBagis.Name = "btnKanBagis";
            this.btnKanBagis.Size = new System.Drawing.Size(149, 37);
            this.btnKanBagis.TabIndex = 1;
            this.btnKanBagis.Text = "Kan Bağışı";
            this.btnKanBagis.UseVisualStyleBackColor = true;
            this.btnKanBagis.Click += new System.EventHandler(this.btnKanBagis_Click);
            // 
            // btnDonor
            // 
            this.btnDonor.FlatAppearance.BorderSize = 0;
            this.btnDonor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonor.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonor.ForeColor = System.Drawing.Color.White;
            this.btnDonor.Location = new System.Drawing.Point(24, 35);
            this.btnDonor.Name = "btnDonor";
            this.btnDonor.Size = new System.Drawing.Size(149, 37);
            this.btnDonor.TabIndex = 0;
            this.btnDonor.Text = "Donor";
            this.btnDonor.UseVisualStyleBackColor = true;
            this.btnDonor.Click += new System.EventHandler(this.btnDonor_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(278, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 411);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 48);
            this.label3.TabIndex = 1;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Donor Sayısı";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel4.Controls.Add(this.lblTransferSayisi);
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(441, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(157, 411);
            this.panel4.TabIndex = 5;
            // 
            // lblTransferSayisi
            // 
            this.lblTransferSayisi.AutoSize = true;
            this.lblTransferSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransferSayisi.Location = new System.Drawing.Point(59, 204);
            this.lblTransferSayisi.Name = "lblTransferSayisi";
            this.lblTransferSayisi.Size = new System.Drawing.Size(44, 48);
            this.lblTransferSayisi.TabIndex = 1;
            this.lblTransferSayisi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Transfer Sayısı";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SandyBrown;
            this.panel5.Controls.Add(this.lblKullaniciSayisi);
            this.panel5.Controls.Add(this.label6);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(604, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(157, 411);
            this.panel5.TabIndex = 6;
            // 
            // lblKullaniciSayisi
            // 
            this.lblKullaniciSayisi.AutoSize = true;
            this.lblKullaniciSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciSayisi.Location = new System.Drawing.Point(59, 204);
            this.lblKullaniciSayisi.Name = "lblKullaniciSayisi";
            this.lblKullaniciSayisi.Size = new System.Drawing.Size(44, 48);
            this.lblKullaniciSayisi.TabIndex = 1;
            this.lblKullaniciSayisi.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(23, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kullanıcılar";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.IndianRed;
            this.panel6.Controls.Add(this.lblToplamStok);
            this.panel6.Controls.Add(this.label7);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(767, 177);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 411);
            this.panel6.TabIndex = 7;
            // 
            // lblToplamStok
            // 
            this.lblToplamStok.AutoSize = true;
            this.lblToplamStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamStok.Location = new System.Drawing.Point(59, 204);
            this.lblToplamStok.Name = "lblToplamStok";
            this.lblToplamStok.Size = new System.Drawing.Size(44, 48);
            this.lblToplamStok.TabIndex = 1;
            this.lblToplamStok.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(20, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 48);
            this.label7.TabIndex = 0;
            this.label7.Text = "Toplam Kan\r\nÜnitesi\r\n";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "|";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(468, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Her Şey İçin Teşekkürler";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDonorListesi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnKanTransfer;
        private System.Windows.Forms.Button btnKanStok;
        private System.Windows.Forms.Button btnHastaListesi;
        private System.Windows.Forms.Button btnHasta;
        private System.Windows.Forms.Button btnKanBagis;
        private System.Windows.Forms.Button btnDonor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTransferSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblKullaniciSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblToplamStok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
    }
}