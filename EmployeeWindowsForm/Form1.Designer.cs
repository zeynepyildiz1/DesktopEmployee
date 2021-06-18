
namespace EmployeeWindowsForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SicilNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.CikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CepTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EvTel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.TextBox();
            this.Departman = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cinsiyet = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SDepartman = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SicilNo
            // 
            this.SicilNo.Location = new System.Drawing.Point(153, 32);
            this.SicilNo.Name = "SicilNo";
            this.SicilNo.Size = new System.Drawing.Size(125, 27);
            this.SicilNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sicil Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adı";
            // 
            // Ad
            // 
            this.Ad.Location = new System.Drawing.Point(395, 30);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(125, 27);
            this.Ad.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Soyadı";
            // 
            // Soyad
            // 
            this.Soyad.Location = new System.Drawing.Point(654, 32);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(125, 27);
            this.Soyad.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giriş Tarihi";
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.Location = new System.Drawing.Point(153, 99);
            this.GirisTarihi.Name = "GirisTarihi";
            this.GirisTarihi.Size = new System.Drawing.Size(250, 27);
            this.GirisTarihi.TabIndex = 7;
            // 
            // CikisTarihi
            // 
            this.CikisTarihi.Location = new System.Drawing.Point(567, 99);
            this.CikisTarihi.Name = "CikisTarihi";
            this.CikisTarihi.Size = new System.Drawing.Size(250, 27);
            this.CikisTarihi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Çıkış Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cep Telefonu";
            // 
            // CepTel
            // 
            this.CepTel.Location = new System.Drawing.Point(643, 161);
            this.CepTel.Name = "CepTel";
            this.CepTel.Size = new System.Drawing.Size(125, 27);
            this.CepTel.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ev Telefonu";
            // 
            // EvTel
            // 
            this.EvTel.Location = new System.Drawing.Point(384, 159);
            this.EvTel.Name = "EvTel";
            this.EvTel.Size = new System.Drawing.Size(125, 27);
            this.EvTel.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mail";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(153, 165);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(125, 27);
            this.Mail.TabIndex = 10;
            // 
            // Departman
            // 
            this.Departman.FormattingEnabled = true;
            this.Departman.Location = new System.Drawing.Point(153, 221);
            this.Departman.Name = "Departman";
            this.Departman.Size = new System.Drawing.Size(250, 28);
            this.Departman.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Departman";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cinsiyet";
            // 
            // Cinsiyet
            // 
            this.Cinsiyet.FormattingEnabled = true;
            this.Cinsiyet.Location = new System.Drawing.Point(555, 214);
            this.Cinsiyet.Name = "Cinsiyet";
            this.Cinsiyet.Size = new System.Drawing.Size(250, 28);
            this.Cinsiyet.TabIndex = 18;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(153, 273);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(178, 46);
            this.btnKaydet.TabIndex = 20;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 330);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(153, -1);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(125, 27);
            this.Id.TabIndex = 22;
            this.Id.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(406, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(178, 46);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(627, 273);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(178, 46);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.SGirisTarihi);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.SDepartman);
            this.panel1.Location = new System.Drawing.Point(862, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 280);
            this.panel1.TabIndex = 25;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(131, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(178, 46);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SGirisTarihi
            // 
            this.SGirisTarihi.Location = new System.Drawing.Point(131, 77);
            this.SGirisTarihi.Name = "SGirisTarihi";
            this.SGirisTarihi.Size = new System.Drawing.Size(189, 27);
            this.SGirisTarihi.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Giriş Tarihi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Departman";
            // 
            // SDepartman
            // 
            this.SDepartman.FormattingEnabled = true;
            this.SDepartman.Location = new System.Drawing.Point(131, 27);
            this.SDepartman.Name = "SDepartman";
            this.SDepartman.Size = new System.Drawing.Size(189, 28);
            this.SDepartman.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 713);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Cinsiyet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Departman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CepTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EvTel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.CikisTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GirisTarihi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SicilNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SicilNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker GirisTarihi;
        private System.Windows.Forms.DateTimePicker CikisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CepTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EvTel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.ComboBox Departman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Cinsiyet;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox SDepartman;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker SGirisTarihi;
        private System.Windows.Forms.Label label12;
    }
}

