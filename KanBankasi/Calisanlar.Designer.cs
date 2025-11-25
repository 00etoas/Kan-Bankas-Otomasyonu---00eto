namespace KanBankasi
{
    partial class Calisanlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.CalisanDGV = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 54);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Yönetimi";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 153);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(140, 30);
            this.txtAdSoyad.TabIndex = 16;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(125, 198);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(140, 30);
            this.txtSifre.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Adı Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Şifre";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Bradley Hand ITC", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(15, 271);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(141, 43);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // CalisanDGV
            // 
            this.CalisanDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalisanDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalisanDGV.Location = new System.Drawing.Point(13, 320);
            this.CalisanDGV.Name = "CalisanDGV";
            this.CalisanDGV.RowHeadersWidth = 51;
            this.CalisanDGV.RowTemplate.Height = 24;
            this.CalisanDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CalisanDGV.Size = new System.Drawing.Size(507, 421);
            this.CalisanDGV.TabIndex = 21;
            this.CalisanDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CalisanDGV_CellClick);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.MediumPurple;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Bradley Hand ITC", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.White;
            this.btnDuzenle.Location = new System.Drawing.Point(197, 271);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(141, 43);
            this.btnDuzenle.TabIndex = 22;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Bradley Hand ITC", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(376, 271);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 43);
            this.btnSil.TabIndex = 23;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(462, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Çıkış";
            this.label4.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // Calisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(532, 753);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.CalisanDGV);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calisanlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calisanlar";
            this.Load += new System.EventHandler(this.Calisanlar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalisanDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView CalisanDGV;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label4;
    }
}