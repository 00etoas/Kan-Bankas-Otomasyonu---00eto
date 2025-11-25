namespace KanBankasi
{
    partial class AdminLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminSifre = new System.Windows.Forms.TextBox();
            this.btnAdminGiris = new System.Windows.Forms.Button();
            this.lblVazgec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kan Bankası Yönetim Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(370, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin Şifresi";
            // 
            // txtAdminSifre
            // 
            this.txtAdminSifre.Location = new System.Drawing.Point(345, 203);
            this.txtAdminSifre.Multiline = true;
            this.txtAdminSifre.Name = "txtAdminSifre";
            this.txtAdminSifre.PasswordChar = '*';
            this.txtAdminSifre.Size = new System.Drawing.Size(193, 26);
            this.txtAdminSifre.TabIndex = 5;
            // 
            // btnAdminGiris
            // 
            this.btnAdminGiris.BackColor = System.Drawing.Color.Crimson;
            this.btnAdminGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGiris.ForeColor = System.Drawing.Color.Black;
            this.btnAdminGiris.Location = new System.Drawing.Point(333, 235);
            this.btnAdminGiris.Name = "btnAdminGiris";
            this.btnAdminGiris.Size = new System.Drawing.Size(227, 50);
            this.btnAdminGiris.TabIndex = 7;
            this.btnAdminGiris.Text = "Giriş Yap";
            this.btnAdminGiris.UseVisualStyleBackColor = false;
            this.btnAdminGiris.Click += new System.EventHandler(this.btnAdminGiris_Click);
            // 
            // lblVazgec
            // 
            this.lblVazgec.AutoSize = true;
            this.lblVazgec.Location = new System.Drawing.Point(350, 288);
            this.lblVazgec.Name = "lblVazgec";
            this.lblVazgec.Size = new System.Drawing.Size(188, 16);
            this.lblVazgec.TabIndex = 8;
            this.lblVazgec.Text = "Vazgeç / Kullanıcı Girişine Dön";
            this.lblVazgec.Click += new System.EventHandler(this.lblVazgec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(818, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KanBankasi.Properties.Resources.blood;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVazgec);
            this.Controls.Add(this.btnAdminGiris);
            this.Controls.Add(this.txtAdminSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminSifre;
        private System.Windows.Forms.Button btnAdminGiris;
        private System.Windows.Forms.Label lblVazgec;
        private System.Windows.Forms.Label label4;
    }
}