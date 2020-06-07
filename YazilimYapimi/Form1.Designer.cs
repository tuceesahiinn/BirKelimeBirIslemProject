namespace YazilimYapimi
{
    partial class BirKelimeBirIslem
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirKelimeBirIslem));
            this.BirIslem = new System.Windows.Forms.ListBox();
            this.BirKelime = new System.Windows.Forms.ListBox();
            this.rdBtnRandomSayilar = new System.Windows.Forms.RadioButton();
            this.rdBtnKullaniciSayilar = new System.Windows.Forms.RadioButton();
            this.rdBtnRandomHarfler = new System.Windows.Forms.RadioButton();
            this.rdBtnKullaniciHarfler = new System.Windows.Forms.RadioButton();
            this.txtBulunacakSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.txtSayi6 = new System.Windows.Forms.TextBox();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.txtSayi3 = new System.Windows.Forms.TextBox();
            this.txtSayi4 = new System.Windows.Forms.TextBox();
            this.txtSayi5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHarf3 = new System.Windows.Forms.TextBox();
            this.txtHarf2 = new System.Windows.Forms.TextBox();
            this.txtHarf1 = new System.Windows.Forms.TextBox();
            this.txtJokerHarf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHarf8 = new System.Windows.Forms.TextBox();
            this.txtHarf7 = new System.Windows.Forms.TextBox();
            this.txtHarf6 = new System.Windows.Forms.TextBox();
            this.txtHarf5 = new System.Windows.Forms.TextBox();
            this.txtHarf4 = new System.Windows.Forms.TextBox();
            this.btnSayiUret = new System.Windows.Forms.Button();
            this.btnIslemYap = new System.Windows.Forms.Button();
            this.btnKelimeOlustur = new System.Windows.Forms.Button();
            this.btnPuanlamaSayilar = new System.Windows.Forms.Button();
            this.btnHarfUret = new System.Windows.Forms.Button();
            this.btnPuanlamaHarfler = new System.Windows.Forms.Button();
            this.Islemler = new System.Windows.Forms.ListBox();
            this.cmbIsaretSec = new System.Windows.Forms.ComboBox();
            this.txtIslemSayisi1 = new System.Windows.Forms.TextBox();
            this.txtIslemSayisi2 = new System.Windows.Forms.TextBox();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnYeniOyunIslem = new System.Windows.Forms.Button();
            this.btnYeniOyunKelime = new System.Windows.Forms.Button();
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rchTxtKelimeler = new System.Windows.Forms.RichTextBox();
            this.btnDosyaAc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirIslem
            // 
            this.BirIslem.BackColor = System.Drawing.Color.LightSlateGray;
            this.BirIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirIslem.FormattingEnabled = true;
            this.BirIslem.ItemHeight = 22;
            this.BirIslem.Items.AddRange(new object[] {
            "Bir Islem"});
            this.BirIslem.Location = new System.Drawing.Point(11, 10);
            this.BirIslem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirIslem.Name = "BirIslem";
            this.BirIslem.Size = new System.Drawing.Size(607, 906);
            this.BirIslem.TabIndex = 0;
            // 
            // BirKelime
            // 
            this.BirKelime.BackColor = System.Drawing.Color.LightSlateGray;
            this.BirKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirKelime.FormattingEnabled = true;
            this.BirKelime.ItemHeight = 22;
            this.BirKelime.Items.AddRange(new object[] {
            "Bir Kelime"});
            this.BirKelime.Location = new System.Drawing.Point(624, 10);
            this.BirKelime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BirKelime.Name = "BirKelime";
            this.BirKelime.Size = new System.Drawing.Size(988, 906);
            this.BirKelime.TabIndex = 1;
            // 
            // rdBtnRandomSayilar
            // 
            this.rdBtnRandomSayilar.AutoSize = true;
            this.rdBtnRandomSayilar.BackColor = System.Drawing.Color.Silver;
            this.rdBtnRandomSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnRandomSayilar.Location = new System.Drawing.Point(29, 63);
            this.rdBtnRandomSayilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnRandomSayilar.Name = "rdBtnRandomSayilar";
            this.rdBtnRandomSayilar.Size = new System.Drawing.Size(163, 28);
            this.rdBtnRandomSayilar.TabIndex = 1;
            this.rdBtnRandomSayilar.TabStop = true;
            this.rdBtnRandomSayilar.Text = "Random Sayilar";
            this.rdBtnRandomSayilar.UseVisualStyleBackColor = false;
            // 
            // rdBtnKullaniciSayilar
            // 
            this.rdBtnKullaniciSayilar.AutoSize = true;
            this.rdBtnKullaniciSayilar.BackColor = System.Drawing.Color.Silver;
            this.rdBtnKullaniciSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnKullaniciSayilar.Location = new System.Drawing.Point(250, 63);
            this.rdBtnKullaniciSayilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnKullaniciSayilar.Name = "rdBtnKullaniciSayilar";
            this.rdBtnKullaniciSayilar.Size = new System.Drawing.Size(246, 28);
            this.rdBtnKullaniciSayilar.TabIndex = 2;
            this.rdBtnKullaniciSayilar.TabStop = true;
            this.rdBtnKullaniciSayilar.Text = "Kullanicinin Girdigi Sayilar";
            this.rdBtnKullaniciSayilar.UseVisualStyleBackColor = false;
            this.rdBtnKullaniciSayilar.CheckedChanged += new System.EventHandler(this.rdBtnKullaniciSayilar_CheckedChanged);
            // 
            // rdBtnRandomHarfler
            // 
            this.rdBtnRandomHarfler.AutoSize = true;
            this.rdBtnRandomHarfler.BackColor = System.Drawing.Color.Silver;
            this.rdBtnRandomHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnRandomHarfler.Location = new System.Drawing.Point(655, 63);
            this.rdBtnRandomHarfler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnRandomHarfler.Name = "rdBtnRandomHarfler";
            this.rdBtnRandomHarfler.Size = new System.Drawing.Size(163, 28);
            this.rdBtnRandomHarfler.TabIndex = 14;
            this.rdBtnRandomHarfler.TabStop = true;
            this.rdBtnRandomHarfler.Text = "Random Harfler";
            this.rdBtnRandomHarfler.UseVisualStyleBackColor = false;
            // 
            // rdBtnKullaniciHarfler
            // 
            this.rdBtnKullaniciHarfler.AutoSize = true;
            this.rdBtnKullaniciHarfler.BackColor = System.Drawing.Color.Silver;
            this.rdBtnKullaniciHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBtnKullaniciHarfler.Location = new System.Drawing.Point(885, 63);
            this.rdBtnKullaniciHarfler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdBtnKullaniciHarfler.Name = "rdBtnKullaniciHarfler";
            this.rdBtnKullaniciHarfler.Size = new System.Drawing.Size(246, 28);
            this.rdBtnKullaniciHarfler.TabIndex = 15;
            this.rdBtnKullaniciHarfler.TabStop = true;
            this.rdBtnKullaniciHarfler.Text = "Kullanicinin Girdigi Harfler";
            this.rdBtnKullaniciHarfler.UseVisualStyleBackColor = false;
            this.rdBtnKullaniciHarfler.CheckedChanged += new System.EventHandler(this.rdBtnKullaniciHarfler_CheckedChanged);
            // 
            // txtBulunacakSayi
            // 
            this.txtBulunacakSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBulunacakSayi.Location = new System.Drawing.Point(33, 138);
            this.txtBulunacakSayi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBulunacakSayi.Name = "txtBulunacakSayi";
            this.txtBulunacakSayi.Size = new System.Drawing.Size(57, 28);
            this.txtBulunacakSayi.TabIndex = 3;
            this.txtBulunacakSayi.Leave += new System.EventHandler(this.txtBulunacakSayi_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bulunacak Sayi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kullanilacak Sayilar:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi1.Location = new System.Drawing.Point(33, 209);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(57, 28);
            this.txtSayi1.TabIndex = 4;
            this.txtSayi1.DoubleClick += new System.EventHandler(this.txtSayi1_DoubleClick);
            this.txtSayi1.Leave += new System.EventHandler(this.txtSayi1_Leave);
            // 
            // txtSayi6
            // 
            this.txtSayi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi6.Location = new System.Drawing.Point(344, 209);
            this.txtSayi6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi6.Name = "txtSayi6";
            this.txtSayi6.Size = new System.Drawing.Size(57, 28);
            this.txtSayi6.TabIndex = 9;
            this.txtSayi6.DoubleClick += new System.EventHandler(this.txtSayi6_DoubleClick);
            this.txtSayi6.Leave += new System.EventHandler(this.txtSayi6_Leave);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi2.Location = new System.Drawing.Point(95, 209);
            this.txtSayi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(57, 28);
            this.txtSayi2.TabIndex = 5;
            this.txtSayi2.DoubleClick += new System.EventHandler(this.txtSayi2_DoubleClick);
            this.txtSayi2.Leave += new System.EventHandler(this.txtSayi2_Leave);
            // 
            // txtSayi3
            // 
            this.txtSayi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi3.Location = new System.Drawing.Point(157, 209);
            this.txtSayi3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi3.Name = "txtSayi3";
            this.txtSayi3.Size = new System.Drawing.Size(57, 28);
            this.txtSayi3.TabIndex = 6;
            this.txtSayi3.DoubleClick += new System.EventHandler(this.txtSayi3_DoubleClick);
            this.txtSayi3.Leave += new System.EventHandler(this.txtSayi3_Leave);
            // 
            // txtSayi4
            // 
            this.txtSayi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi4.Location = new System.Drawing.Point(220, 209);
            this.txtSayi4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi4.Name = "txtSayi4";
            this.txtSayi4.Size = new System.Drawing.Size(57, 28);
            this.txtSayi4.TabIndex = 7;
            this.txtSayi4.DoubleClick += new System.EventHandler(this.txtSayi4_DoubleClick);
            this.txtSayi4.Leave += new System.EventHandler(this.txtSayi4_Leave);
            // 
            // txtSayi5
            // 
            this.txtSayi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi5.Location = new System.Drawing.Point(282, 209);
            this.txtSayi5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi5.Name = "txtSayi5";
            this.txtSayi5.Size = new System.Drawing.Size(57, 28);
            this.txtSayi5.TabIndex = 8;
            this.txtSayi5.DoubleClick += new System.EventHandler(this.txtSayi5_DoubleClick);
            this.txtSayi5.Leave += new System.EventHandler(this.txtSayi5_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(652, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Joker Harf:";
            // 
            // txtHarf3
            // 
            this.txtHarf3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf3.Location = new System.Drawing.Point(780, 209);
            this.txtHarf3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf3.Name = "txtHarf3";
            this.txtHarf3.Size = new System.Drawing.Size(57, 28);
            this.txtHarf3.TabIndex = 19;
            this.txtHarf3.DoubleClick += new System.EventHandler(this.txtHarf3_DoubleClick);
            // 
            // txtHarf2
            // 
            this.txtHarf2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf2.Location = new System.Drawing.Point(717, 209);
            this.txtHarf2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf2.Name = "txtHarf2";
            this.txtHarf2.Size = new System.Drawing.Size(57, 28);
            this.txtHarf2.TabIndex = 18;
            this.txtHarf2.DoubleClick += new System.EventHandler(this.txtHarf2_DoubleClick);
            // 
            // txtHarf1
            // 
            this.txtHarf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf1.Location = new System.Drawing.Point(655, 209);
            this.txtHarf1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf1.Name = "txtHarf1";
            this.txtHarf1.Size = new System.Drawing.Size(57, 28);
            this.txtHarf1.TabIndex = 17;
            this.txtHarf1.DoubleClick += new System.EventHandler(this.txtHarf1_DoubleClick);
            // 
            // txtJokerHarf
            // 
            this.txtJokerHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtJokerHarf.Location = new System.Drawing.Point(655, 138);
            this.txtJokerHarf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJokerHarf.Name = "txtJokerHarf";
            this.txtJokerHarf.Size = new System.Drawing.Size(57, 28);
            this.txtJokerHarf.TabIndex = 16;
            this.txtJokerHarf.DoubleClick += new System.EventHandler(this.txtJokerHarf_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(652, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kullanilacak Harfler:";
            // 
            // txtHarf8
            // 
            this.txtHarf8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf8.Location = new System.Drawing.Point(1091, 209);
            this.txtHarf8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf8.Name = "txtHarf8";
            this.txtHarf8.Size = new System.Drawing.Size(57, 28);
            this.txtHarf8.TabIndex = 24;
            this.txtHarf8.DoubleClick += new System.EventHandler(this.txtHarf8_DoubleClick);
            // 
            // txtHarf7
            // 
            this.txtHarf7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf7.Location = new System.Drawing.Point(1028, 209);
            this.txtHarf7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf7.Name = "txtHarf7";
            this.txtHarf7.Size = new System.Drawing.Size(57, 28);
            this.txtHarf7.TabIndex = 23;
            this.txtHarf7.DoubleClick += new System.EventHandler(this.txtHarf7_DoubleClick);
            // 
            // txtHarf6
            // 
            this.txtHarf6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf6.Location = new System.Drawing.Point(966, 209);
            this.txtHarf6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf6.Name = "txtHarf6";
            this.txtHarf6.Size = new System.Drawing.Size(57, 28);
            this.txtHarf6.TabIndex = 22;
            this.txtHarf6.DoubleClick += new System.EventHandler(this.txtHarf6_DoubleClick);
            // 
            // txtHarf5
            // 
            this.txtHarf5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf5.Location = new System.Drawing.Point(904, 209);
            this.txtHarf5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf5.Name = "txtHarf5";
            this.txtHarf5.Size = new System.Drawing.Size(57, 28);
            this.txtHarf5.TabIndex = 21;
            this.txtHarf5.DoubleClick += new System.EventHandler(this.txtHarf5_DoubleClick);
            // 
            // txtHarf4
            // 
            this.txtHarf4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf4.Location = new System.Drawing.Point(842, 209);
            this.txtHarf4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHarf4.Name = "txtHarf4";
            this.txtHarf4.Size = new System.Drawing.Size(57, 28);
            this.txtHarf4.TabIndex = 20;
            this.txtHarf4.DoubleClick += new System.EventHandler(this.txtHarf4_DoubleClick);
            // 
            // btnSayiUret
            // 
            this.btnSayiUret.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSayiUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiUret.Location = new System.Drawing.Point(29, 339);
            this.btnSayiUret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSayiUret.Name = "btnSayiUret";
            this.btnSayiUret.Size = new System.Drawing.Size(142, 39);
            this.btnSayiUret.TabIndex = 26;
            this.btnSayiUret.Text = "Sayi Uret";
            this.btnSayiUret.UseVisualStyleBackColor = false;
            this.btnSayiUret.Click += new System.EventHandler(this.btnSayiUret_Click_1);
            // 
            // btnIslemYap
            // 
            this.btnIslemYap.BackColor = System.Drawing.Color.RosyBrown;
            this.btnIslemYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIslemYap.Location = new System.Drawing.Point(177, 339);
            this.btnIslemYap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIslemYap.Name = "btnIslemYap";
            this.btnIslemYap.Size = new System.Drawing.Size(142, 39);
            this.btnIslemYap.TabIndex = 27;
            this.btnIslemYap.Text = "Islem Yap";
            this.btnIslemYap.UseVisualStyleBackColor = false;
            this.btnIslemYap.Click += new System.EventHandler(this.btnIslemYap_Click);
            // 
            // btnKelimeOlustur
            // 
            this.btnKelimeOlustur.BackColor = System.Drawing.Color.RosyBrown;
            this.btnKelimeOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeOlustur.Location = new System.Drawing.Point(803, 308);
            this.btnKelimeOlustur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKelimeOlustur.Name = "btnKelimeOlustur";
            this.btnKelimeOlustur.Size = new System.Drawing.Size(163, 39);
            this.btnKelimeOlustur.TabIndex = 28;
            this.btnKelimeOlustur.Text = "Kelime Olustur";
            this.btnKelimeOlustur.UseVisualStyleBackColor = false;
            this.btnKelimeOlustur.Click += new System.EventHandler(this.btnKelimeOlustur_Click);
            // 
            // btnPuanlamaSayilar
            // 
            this.btnPuanlamaSayilar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPuanlamaSayilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuanlamaSayilar.Location = new System.Drawing.Point(331, 339);
            this.btnPuanlamaSayilar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPuanlamaSayilar.Name = "btnPuanlamaSayilar";
            this.btnPuanlamaSayilar.Size = new System.Drawing.Size(142, 39);
            this.btnPuanlamaSayilar.TabIndex = 29;
            this.btnPuanlamaSayilar.Text = "Puanlama";
            this.btnPuanlamaSayilar.UseVisualStyleBackColor = false;
            this.btnPuanlamaSayilar.Click += new System.EventHandler(this.btnPuanlamaSayilar_Click);
            // 
            // btnHarfUret
            // 
            this.btnHarfUret.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHarfUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHarfUret.Location = new System.Drawing.Point(655, 308);
            this.btnHarfUret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHarfUret.Name = "btnHarfUret";
            this.btnHarfUret.Size = new System.Drawing.Size(142, 39);
            this.btnHarfUret.TabIndex = 30;
            this.btnHarfUret.Text = "Harf Uret";
            this.btnHarfUret.UseVisualStyleBackColor = false;
            this.btnHarfUret.Click += new System.EventHandler(this.btnHarfUret_Click);
            // 
            // btnPuanlamaHarfler
            // 
            this.btnPuanlamaHarfler.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPuanlamaHarfler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPuanlamaHarfler.Location = new System.Drawing.Point(971, 308);
            this.btnPuanlamaHarfler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPuanlamaHarfler.Name = "btnPuanlamaHarfler";
            this.btnPuanlamaHarfler.Size = new System.Drawing.Size(142, 39);
            this.btnPuanlamaHarfler.TabIndex = 31;
            this.btnPuanlamaHarfler.Text = "Puanlama";
            this.btnPuanlamaHarfler.UseVisualStyleBackColor = false;
            this.btnPuanlamaHarfler.Click += new System.EventHandler(this.btnPuanlamaHarfler_Click);
            // 
            // Islemler
            // 
            this.Islemler.FormattingEnabled = true;
            this.Islemler.ItemHeight = 16;
            this.Islemler.Items.AddRange(new object[] {
            "Islemler"});
            this.Islemler.Location = new System.Drawing.Point(406, 116);
            this.Islemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Islemler.Name = "Islemler";
            this.Islemler.Size = new System.Drawing.Size(178, 116);
            this.Islemler.TabIndex = 32;
            // 
            // cmbIsaretSec
            // 
            this.cmbIsaretSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIsaretSec.FormattingEnabled = true;
            this.cmbIsaretSec.Items.AddRange(new object[] {
            "Topla",
            "Cikar",
            "Bol",
            "Carp"});
            this.cmbIsaretSec.Location = new System.Drawing.Point(93, 292);
            this.cmbIsaretSec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIsaretSec.Name = "cmbIsaretSec";
            this.cmbIsaretSec.Size = new System.Drawing.Size(107, 28);
            this.cmbIsaretSec.TabIndex = 11;
            this.cmbIsaretSec.Click += new System.EventHandler(this.cmbIsaretSec_Click);
            // 
            // txtIslemSayisi1
            // 
            this.txtIslemSayisi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemSayisi1.Location = new System.Drawing.Point(30, 294);
            this.txtIslemSayisi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIslemSayisi1.Name = "txtIslemSayisi1";
            this.txtIslemSayisi1.Size = new System.Drawing.Size(57, 28);
            this.txtIslemSayisi1.TabIndex = 10;
            this.txtIslemSayisi1.Click += new System.EventHandler(this.txtIslemSayisi1_Click);
            // 
            // txtIslemSayisi2
            // 
            this.txtIslemSayisi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIslemSayisi2.Location = new System.Drawing.Point(206, 292);
            this.txtIslemSayisi2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIslemSayisi2.Name = "txtIslemSayisi2";
            this.txtIslemSayisi2.Size = new System.Drawing.Size(57, 28);
            this.txtIslemSayisi2.TabIndex = 12;
            this.txtIslemSayisi2.Click += new System.EventHandler(this.txtIslemSayisi2_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(478, 240);
            this.txtSonuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(70, 28);
            this.txtSonuc.TabIndex = 13;
            this.txtSonuc.Click += new System.EventHandler(this.txtSonuc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(403, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Sonuc:";
            // 
            // btnYeniOyunIslem
            // 
            this.btnYeniOyunIslem.BackColor = System.Drawing.Color.RosyBrown;
            this.btnYeniOyunIslem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyunIslem.Location = new System.Drawing.Point(331, 409);
            this.btnYeniOyunIslem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniOyunIslem.Name = "btnYeniOyunIslem";
            this.btnYeniOyunIslem.Size = new System.Drawing.Size(142, 39);
            this.btnYeniOyunIslem.TabIndex = 43;
            this.btnYeniOyunIslem.Text = "Yeni Oyun";
            this.btnYeniOyunIslem.UseVisualStyleBackColor = false;
            this.btnYeniOyunIslem.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btnYeniOyunKelime
            // 
            this.btnYeniOyunKelime.BackColor = System.Drawing.Color.RosyBrown;
            this.btnYeniOyunKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyunKelime.Location = new System.Drawing.Point(971, 367);
            this.btnYeniOyunKelime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYeniOyunKelime.Name = "btnYeniOyunKelime";
            this.btnYeniOyunKelime.Size = new System.Drawing.Size(142, 39);
            this.btnYeniOyunKelime.TabIndex = 44;
            this.btnYeniOyunKelime.Text = "Yeni Oyun";
            this.btnYeniOyunKelime.UseVisualStyleBackColor = false;
            this.btnYeniOyunKelime.Click += new System.EventHandler(this.btnYeniOyunKelime_Click);
            // 
            // txtKelime
            // 
            this.txtKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKelime.Location = new System.Drawing.Point(780, 254);
            this.txtKelime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(244, 28);
            this.txtKelime.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(691, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Kelime:";
            // 
            // rchTxtKelimeler
            // 
            this.rchTxtKelimeler.Location = new System.Drawing.Point(1314, 17);
            this.rchTxtKelimeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rchTxtKelimeler.Name = "rchTxtKelimeler";
            this.rchTxtKelimeler.Size = new System.Drawing.Size(286, 874);
            this.rchTxtKelimeler.TabIndex = 47;
            this.rchTxtKelimeler.Text = "";
            // 
            // btnDosyaAc
            // 
            this.btnDosyaAc.BackColor = System.Drawing.Color.RosyBrown;
            this.btnDosyaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDosyaAc.Location = new System.Drawing.Point(658, 367);
            this.btnDosyaAc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDosyaAc.Name = "btnDosyaAc";
            this.btnDosyaAc.Size = new System.Drawing.Size(142, 39);
            this.btnDosyaAc.TabIndex = 48;
            this.btnDosyaAc.Text = "Dosya Ac";
            this.btnDosyaAc.UseVisualStyleBackColor = false;
            this.btnDosyaAc.Click += new System.EventHandler(this.btnDosyaAc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(26, 417);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Oyun Kuralları:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(29, 455);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 436);
            this.richTextBox1.TabIndex = 50;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(29, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 51;
            this.label8.Text = "Yapilacak Islemler:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox2.Location = new System.Drawing.Point(637, 455);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(671, 436);
            this.richTextBox2.TabIndex = 52;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(641, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "Oyun Kuralları:";
            // 
            // BirKelimeBirIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1055);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDosyaAc);
            this.Controls.Add(this.rchTxtKelimeler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKelime);
            this.Controls.Add(this.btnYeniOyunKelime);
            this.Controls.Add(this.btnYeniOyunIslem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.txtIslemSayisi2);
            this.Controls.Add(this.txtIslemSayisi1);
            this.Controls.Add(this.cmbIsaretSec);
            this.Controls.Add(this.Islemler);
            this.Controls.Add(this.btnPuanlamaHarfler);
            this.Controls.Add(this.btnHarfUret);
            this.Controls.Add(this.btnPuanlamaSayilar);
            this.Controls.Add(this.btnKelimeOlustur);
            this.Controls.Add(this.btnIslemYap);
            this.Controls.Add(this.btnSayiUret);
            this.Controls.Add(this.txtHarf4);
            this.Controls.Add(this.txtHarf5);
            this.Controls.Add(this.txtHarf6);
            this.Controls.Add(this.txtHarf7);
            this.Controls.Add(this.txtHarf8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJokerHarf);
            this.Controls.Add(this.txtHarf1);
            this.Controls.Add(this.txtHarf2);
            this.Controls.Add(this.txtHarf3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSayi5);
            this.Controls.Add(this.txtSayi4);
            this.Controls.Add(this.txtSayi3);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.txtSayi6);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBulunacakSayi);
            this.Controls.Add(this.rdBtnKullaniciHarfler);
            this.Controls.Add(this.rdBtnRandomHarfler);
            this.Controls.Add(this.rdBtnKullaniciSayilar);
            this.Controls.Add(this.rdBtnRandomSayilar);
            this.Controls.Add(this.BirKelime);
            this.Controls.Add(this.BirIslem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BirKelimeBirIslem";
            this.Text = "BirKelimeBirIslem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BirIslem;
        private System.Windows.Forms.ListBox BirKelime;
        private System.Windows.Forms.RadioButton rdBtnRandomSayilar;
        private System.Windows.Forms.RadioButton rdBtnKullaniciSayilar;
        private System.Windows.Forms.RadioButton rdBtnRandomHarfler;
        private System.Windows.Forms.RadioButton rdBtnKullaniciHarfler;
        private System.Windows.Forms.TextBox txtBulunacakSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.TextBox txtSayi6;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.TextBox txtSayi3;
        private System.Windows.Forms.TextBox txtSayi4;
        private System.Windows.Forms.TextBox txtSayi5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHarf3;
        private System.Windows.Forms.TextBox txtHarf2;
        private System.Windows.Forms.TextBox txtHarf1;
        private System.Windows.Forms.TextBox txtJokerHarf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarf8;
        private System.Windows.Forms.TextBox txtHarf7;
        private System.Windows.Forms.TextBox txtHarf6;
        private System.Windows.Forms.TextBox txtHarf5;
        private System.Windows.Forms.TextBox txtHarf4;
        private System.Windows.Forms.Button btnSayiUret;
        private System.Windows.Forms.Button btnIslemYap;
        private System.Windows.Forms.Button btnKelimeOlustur;
        private System.Windows.Forms.Button btnPuanlamaSayilar;
        private System.Windows.Forms.Button btnHarfUret;
        private System.Windows.Forms.Button btnPuanlamaHarfler;
        private System.Windows.Forms.ListBox Islemler;
        private System.Windows.Forms.ComboBox cmbIsaretSec;
        private System.Windows.Forms.TextBox txtIslemSayisi1;
        private System.Windows.Forms.TextBox txtIslemSayisi2;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnYeniOyunIslem;
        private System.Windows.Forms.Button btnYeniOyunKelime;
        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchTxtKelimeler;
        private System.Windows.Forms.Button btnDosyaAc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label9;
    }
}

