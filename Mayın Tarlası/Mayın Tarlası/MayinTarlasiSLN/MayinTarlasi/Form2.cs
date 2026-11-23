using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}
		Form3 frm3 = new Form3();
		int skor = 0;
		int zorluk = 0;
		int zaman = 0;

		#region Methodlar

		void dosyayaYaz()
		{
			StreamWriter dosyaYaz = File.AppendText(Application.StartupPath + "/skorlar.txt");
			dosyaYaz.WriteLine($"{txtIsim.Text} => {frm3.txtSkor.Text}");
			dosyaYaz.Close();
		}

		void Doldur(int mayinSayisi, int Satir, int Sutun)
		{
			frm3.flowLayoutPanel1.Height = Convert.ToInt32(txtSutun.Text) * 50;
			frm3.flowLayoutPanel1.Width = Convert.ToInt32(txtSatir.Text) * 50;
			frm3.flowLayoutPanel1.Controls.Clear();
			int[] mayinlar = new int[mayinSayisi];
			Random rnd = new Random();

			for (int i = 0; i < mayinSayisi; i++)
			{
				int sec = rnd.Next(0, Satir * Sutun);
				if (mayinlar.Contains(sec))
				{
					i--;
					continue;
				}
				mayinlar[i] = sec;

			}

			for (int i = 0; i < Satir * Sutun; i++)
			{
				Button btn = new Button();
				btn.Height = 50;
				btn.Width = 50;
				btn.Margin = new Padding(0);
				btn.Tag = mayinlar.Contains(i);
				btn.Click += btn_Click;
				frm3.flowLayoutPanel1.Controls.Add(btn);
			}


		}

		void btn_Click(object sender, EventArgs e)
		{
			Button tiklanan = (Button)sender;

			if ((bool)tiklanan.Tag == true)
			{
				tiklanan.BackgroundImage = Image.FromFile("kirmizi.png");
				OyunuBitir();
			}
			else
			{
				if (tiklanan.BackColor != Color.Green)
				{
					skor++;
					tiklanan.BackColor = Color.Green;
					frm3.txtSkor.Text = skor.ToString();
				}
			}

		}

		void OyunuBitir()
		{
			foreach (Button item in frm3.flowLayoutPanel1.Controls)
			{
				bool durum = (bool)item.Tag;

				if (durum)
				{
					item.BackgroundImage = Image.FromFile("kirmizi.png");
					timer1.Stop();
				}
				else
				{
					item.BackColor = Color.Green;
				}
			}

			dosyayaYaz();

			DialogResult result = MessageBox.Show("Oyun Bitti!!! \nYeniden Oynamak İster misiniz ?", "Yeniden Oyna!!", MessageBoxButtons.YesNo);

			if (result == DialogResult.Yes)
			{
				frm3.Hide();
				this.Show();
				zaman = 0;
				zorluk = 0;
				skor = 0;
				frm3.txtSkor.Text = "";
			}
			else
			{
				MessageBox.Show("Oyun Kapatılacak!!");
				frm3.Close();
				this.Close();
				Application.Exit();
			}

		}



		#endregion

		private void btnOyunuBaslat_Click(object sender, EventArgs e)
		{
			if (!rdKolay.Checked && !rdOrta.Checked && !rdZor.Checked)
			{
				MessageBox.Show("Zorluk Seviyesi Seçiniz!!!");
			}
			else if (rdKolay.Checked == true)
			{
				zorluk += 5;
				zaman += 60;
				Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
				this.Hide();
				frm3.Show();
				timer1.Start();
			}
			else if (rdOrta.Checked == true)
			{
				zorluk += 10;
				zaman += 30;
				Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
				this.Hide();
				frm3.Show();
				timer1.Start();
			}
			else if (rdZor.Checked == true)
			{
				zorluk += 15;
				zaman += 15;
				Doldur(zorluk, Convert.ToInt32(txtSatir.Text), Convert.ToInt32(txtSutun.Text));
				this.Hide();
				frm3.Show();
				timer1.Start();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			zaman--;
			frm3.txtSure.Text = zaman.ToString();
			if (zaman == 0)
			{
				timer1.Stop();
				OyunuBitir();
			}
		}

		private void btnSkor_Click(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			frm4.Show();
			StreamReader skor = new StreamReader(Application.StartupPath + "/skorlar.txt");

			frm4.txtSkorListe.Text = skor.ReadToEnd();
			skor.Close();
		}
	}
}
