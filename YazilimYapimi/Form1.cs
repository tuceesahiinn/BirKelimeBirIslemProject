using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace YazilimYapimi
{
    public partial class BirKelimeBirIslem : Form
    {
        public BirKelimeBirIslem()
        {
            InitializeComponent();
        }
        Random random = new Random();

        //Islem kismi
        private void btnSayiUret_Click_1(object sender, EventArgs e)
        {
            if (rdBtnRandomSayilar.Checked == true)
            {
                int randomSayi = random.Next(10, 100);
                int onunKatiSayi = randomSayi - randomSayi % 10;
                txtBulunacakSayi.Text = random.Next(100, 1000).ToString();
                txtSayi1.Text = random.Next(1, 10).ToString();
                txtSayi2.Text = random.Next(1, 10).ToString();
                txtSayi3.Text = random.Next(1, 10).ToString();
                txtSayi4.Text = random.Next(1, 10).ToString();
                txtSayi5.Text = random.Next(1, 10).ToString();
                txtSayi6.Text = onunKatiSayi.ToString();
            }
        }
        private void btnIslemYap_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtIslemSayisi1.Text);
            int sayi2 = int.Parse(txtIslemSayisi2.Text);
            if(cmbIsaretSec.Text=="Topla")
            {
                Islemler.Items.Add(sayi1+ "+" + sayi2+ "="+ (sayi1 + sayi2).ToString());
            }
            if(cmbIsaretSec.Text=="Cikar")
            {
                Islemler.Items.Add(sayi1 + "-" + sayi2 + "=" + (sayi1 - sayi2).ToString());
            }
            if(cmbIsaretSec.Text=="Bol")
            {
                Islemler.Items.Add(sayi1 + "/" + sayi2 + "=" + (sayi1 / sayi2).ToString());
            }
            if(cmbIsaretSec.Text=="Carp")
            {
                Islemler.Items.Add(sayi1 + "*" + sayi2 + "=" + (sayi1 * sayi2).ToString());
            }
            txtIslemSayisi1.Text = "";
            txtIslemSayisi2.Text = "";
            cmbIsaretSec.Text = "";
        }
        private void btnPuanlamaSayilar_Click(object sender, EventArgs e)
        {
            int puan;
            int toplamPuan = 0;
            int fark = Convert.ToInt32(txtBulunacakSayi.Text) - Convert.ToInt32(txtSonuc.Text);
            if (fark == 0)
            {
                puan = 10;
                toplamPuan += puan;
            }
            else if (fark == 1 || fark == (-1))
            {
                puan = 9;
                toplamPuan += puan;
            }
            else if (fark == 2 || fark == (-2))
            {
                puan = 8;
                toplamPuan += puan;
            }
            else if (fark == 3 || fark == (-3))
            {
                puan = 7;
                toplamPuan += puan;
            }
            else if (fark == 4 || fark == (-4))
            {
                puan = 6;
                toplamPuan += puan;
            }
            else if (fark == 5 || fark == (-5))
            {
                puan = 5;
                toplamPuan += puan;
            }
            else if (fark == 6 || fark == (-6))
            {
                puan = 4;
                toplamPuan += puan;
            }
            else if (fark == 7 || fark == (-7))
            {
                puan = 3;
                toplamPuan += puan;
            }
            else if (fark == 8 || fark == (-8))
            {
                puan = 2;
                toplamPuan += puan;
            }
            else if (fark == 9 || fark == (-9))
            {
                puan = 1;
                toplamPuan += puan;
            }
            else
            {
                puan = 0;
                toplamPuan += puan;
            }
            MessageBox.Show("Puanınız: " + toplamPuan, "Puan Tablosu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            rdBtnKullaniciSayilar.Checked = false;
            rdBtnRandomSayilar.Checked = false;
            txtSayi1.Text = "";
            txtSayi2.Text = "";
            txtSayi3.Text = "";
            txtSayi4.Text = "";
            txtSayi5.Text = "";
            txtSayi6.Text = "";
            txtSayi1.Enabled = true;
            txtSayi2.Enabled = true;
            txtSayi3.Enabled = true;
            txtSayi4.Enabled = true;
            txtSayi5.Enabled = true;
            txtSayi6.Enabled = true;
            txtBulunacakSayi.Text = "";
            txtIslemSayisi1.Text = "";
            txtIslemSayisi2.Text = "";
            cmbIsaretSec.Text = "";
            txtSonuc.Text = "";
            Islemler.Items.Clear();
        }
        private void rdBtnKullaniciSayilar_CheckedChanged(object sender, EventArgs e)
        {
            btnSayiUret.Enabled = false;
            txtBulunacakSayi.Focus();
        }
        private void txtIslemSayisi1_Click(object sender, EventArgs e)
        {
            txtIslemSayisi1.Text = "";
        }
        private void txtIslemSayisi2_Click(object sender, EventArgs e)
        {
            txtIslemSayisi2.Text = "";
        }
        private void cmbIsaretSec_Click(object sender, EventArgs e)
        {
            cmbIsaretSec.Text = "";
        }
        private void txtSonuc_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "";
        }
        public void sayiTasi(TextBox textBox)
        {
            if (txtIslemSayisi1.Text == "")
            {
                txtIslemSayisi1.Text = textBox.Text;
                textBox.Enabled = false;
            }
            else if (txtIslemSayisi2.Text == "")
            {
                txtIslemSayisi2.Text = textBox.Text;
                textBox.Enabled = false;
            }
        }
        private void txtSayi1_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi1);
        }
        private void txtSayi2_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi2);
        }
        private void txtSayi3_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi3);
        }
        private void txtSayi4_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi4);
        }
        private void txtSayi5_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi5);
        }
        private void txtSayi6_DoubleClick(object sender, EventArgs e)
        {
            sayiTasi(txtSayi6);
        }
        private void txtBulunacakSayi_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtBulunacakSayi.Text)<=99 || Convert.ToInt32(txtBulunacakSayi.Text)>=1000)
            {
                MessageBox.Show("Lutfen 100 ile 1000 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBulunacakSayi.Text = "";
                txtBulunacakSayi.Focus();
            }
        }
        private void txtSayi1_Leave(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtSayi1.Text)<=0 || Convert.ToInt32(txtSayi1.Text)>=10)
            {
                MessageBox.Show("Lutfen 1 ile 10 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi1.Text = "";
                txtSayi1.Focus();
            }
        }
        private void txtSayi2_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi2.Text) <= 0 || Convert.ToInt32(txtSayi2.Text) >= 10)
            {
                MessageBox.Show("Lutfen 1 ile 10 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi2.Text = "";
                txtSayi2.Focus();
            }
        }
        private void txtSayi3_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi3.Text) <= 0 || Convert.ToInt32(txtSayi3.Text) >= 10)
            {
                MessageBox.Show("Lutfen 1 ile 10 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi3.Text = "";
                txtSayi3.Focus();
            }
        }
        private void txtSayi4_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi4.Text) <= 0 || Convert.ToInt32(txtSayi4.Text) >= 10)
            {
                MessageBox.Show("Lutfen 1 ile 10 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi4.Text = "";
                txtSayi4.Focus();
            }
        }
        private void txtSayi5_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi5.Text) <= 0 || Convert.ToInt32(txtSayi5.Text) >= 10)
            {
                MessageBox.Show("Lutfen 1 ile 10 arasinda sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi5.Text = "";
                txtSayi5.Focus();
            }
        }
        private void txtSayi6_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtSayi6.Text) <= 9 || Convert.ToInt32(txtSayi6.Text) >= 91 || Convert.ToInt32(txtSayi6.Text) % 10 != 0)
            {
                MessageBox.Show("Lutfen 2 basamakli ve 10'un kati sayi giriniz", "GECERSIZ SAYI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSayi6.Text = "";
                txtSayi6.Focus();
            }
        }
        //Kelime kismi
        private void btnHarfUret_Click(object sender, EventArgs e)
        {
            if (rdBtnRandomHarfler.Checked == true)
            {
                int asciKarakter1 = random.Next(65, 91);
                int asciKarakter2 = random.Next(65, 91);
                int asciKarakter3 = random.Next(65, 91);
                int asciKarakter4 = random.Next(65, 91);
                int asciKarakter5 = random.Next(65, 91);
                int asciKarakter6 = random.Next(65, 91);
                int asciKarakter7 = random.Next(65, 91);
                int asciKarakter8 = random.Next(65, 91);
                char harf1 = Convert.ToChar(asciKarakter1);
                char harf2 = Convert.ToChar(asciKarakter2);
                char harf3 = Convert.ToChar(asciKarakter3);
                char harf4 = Convert.ToChar(asciKarakter4);
                char harf5 = Convert.ToChar(asciKarakter5);
                char harf6 = Convert.ToChar(asciKarakter6);
                char harf7 = Convert.ToChar(asciKarakter7);
                char harf8 = Convert.ToChar(asciKarakter8);
                txtHarf1.Text = harf1.ToString();
                txtHarf2.Text = harf2.ToString();
                txtHarf3.Text = harf3.ToString();
                txtHarf4.Text = harf4.ToString();
                txtHarf5.Text = harf5.ToString();
                txtHarf6.Text = harf6.ToString();
                txtHarf7.Text = harf7.ToString();
                txtHarf8.Text = harf8.ToString();
            }
        }
        private void btnKelimeOlustur_Click(object sender, EventArgs e)
        {
            int indeks = 0;
            string t = rchTxtKelimeler.Text;
            rchTxtKelimeler.Text = "";
            rchTxtKelimeler.Text = t;
            while (indeks < rchTxtKelimeler.Text.LastIndexOf(txtKelime.Text))
            {
                rchTxtKelimeler.Find(txtKelime.Text, indeks, rchTxtKelimeler.TextLength, RichTextBoxFinds.None);
                rchTxtKelimeler.SelectionBackColor = Color.Red;
                indeks = rchTxtKelimeler.Text.IndexOf(txtKelime.Text, indeks) + 1;
                txtKelime.Enabled = false;
            }
            if(txtKelime.Enabled==true)
            {
                MessageBox.Show("Boyle bir kelime sistemde bulunamamistir.", "Mesaj",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (txtKelime.Text.Length < 3)
            {
                MessageBox.Show("Program sonlandi, Kelime uzunlugu en az 3 olmalı.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void btnYeniOyunKelime_Click(object sender, EventArgs e)
        {
            rdBtnKullaniciHarfler.Checked = false;
            rdBtnRandomHarfler.Checked = false;
            txtJokerHarf.Text = "";
            txtHarf1.Text = "";
            txtHarf2.Text = "";
            txtHarf3.Text = "";
            txtHarf4.Text = "";
            txtHarf5.Text = "";
            txtHarf6.Text = "";
            txtHarf7.Text = "";
            txtHarf8.Text = "";
            txtKelime.Text = "";
            txtJokerHarf.Enabled = true;
            txtHarf1.Enabled = true;
            txtHarf2.Enabled = true;
            txtHarf3.Enabled = true;
            txtHarf4.Enabled = true;
            txtHarf5.Enabled = true;
            txtHarf6.Enabled = true;
            txtHarf7.Enabled = true;
            txtHarf8.Enabled = true;
            txtKelime.Enabled = true;
            btnHarfUret.Enabled = true;
        }
        private void btnDosyaAc_Click(object sender, EventArgs e)
        {
            Stream st;
            OpenFileDialog diyalog = new OpenFileDialog();
            if (diyalog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((st = diyalog.OpenFile()) != null)
                {
                    Encoding e2 = Encoding.GetEncoding("iso-8859-9");
                    string dosyaIsmi = diyalog.FileName;
                    string dosyaMetni = File.ReadAllText(dosyaIsmi);
                    rchTxtKelimeler.Text = dosyaMetni;
                }
            }
        }
        private void btnPuanlamaHarfler_Click(object sender, EventArgs e)
        {
            int puan;
            int toplamPuan = 0;
            int kelimeUzunlugu = txtKelime.Text.Length;
            if (kelimeUzunlugu == 3)
            {
                puan = 3;
                toplamPuan += puan;
            }
            else if (kelimeUzunlugu == 4)
            {
                puan = 4;
                toplamPuan += 4;
            }
            else if (kelimeUzunlugu == 5)
            {
                puan = 5;
                toplamPuan += puan;
            }
            else if (kelimeUzunlugu == 6)
            {
                puan = 7;
                toplamPuan += puan;
            }
            else if (kelimeUzunlugu == 7)
            {
                puan = 9;
                toplamPuan += puan;
            }
            else if (kelimeUzunlugu == 8)
            {
                puan = 11;
                toplamPuan += puan;
            }
            else if (kelimeUzunlugu == 9)
            {
                puan = 15;
                toplamPuan += puan;
            }
            else
            {
                puan = 0;
                toplamPuan += puan;
            }
            MessageBox.Show("Puanınız: " + toplamPuan, "Puan Tablosu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void rdBtnKullaniciHarfler_CheckedChanged(object sender, EventArgs e)
        {
            btnHarfUret.Enabled = false;
            txtJokerHarf.Focus();
        }
        public void harfTasi(TextBox textBox)
        {
            txtKelime.Text += textBox.Text;
            textBox.Enabled = false;
        }
        private void txtHarf1_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf1);
        }
        private void txtHarf2_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf2);
        }
        private void txtHarf3_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf3);
        }
        private void txtHarf4_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf4);
        }
        private void txtHarf5_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf5);
        }
        private void txtHarf6_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf6);
        }
        private void txtHarf7_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf7);
        }
        private void txtHarf8_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtHarf8);
        }
        private void txtJokerHarf_DoubleClick(object sender, EventArgs e)
        {
            harfTasi(txtJokerHarf);
        }
    }
}
