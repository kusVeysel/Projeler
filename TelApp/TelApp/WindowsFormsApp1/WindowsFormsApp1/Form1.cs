using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTelefon_Click(object sender, EventArgs e)
		{
			if (txtAranacak.Text != "")
			{
				List<Kisi> sonuc = Methodlar.TelefonileGetir(txtAranacak.Text.Replace(" ", "").Trim());

				if (sonuc.Count != 0)
				{
					dgwKisiData.DataSource = sonuc;
				}
				else
				{
					MessageBox.Show("Kisi Bulunamadı!");
					txtAranacak.Text = "";
				}
			}
			else
			{
				MessageBox.Show("Arama Kutusu Boş Geçilemez!");
			}
		}

		private void btnEmail_Click(object sender, EventArgs e)
		{
			List<Kisi> sonuc;

			if (txtAranacak.Text != "")
			{
				if (txtAranacak.Text.Contains("@"))
				{
					if (txtAranacak.Text.StartsWith("@"))
					{
						sonuc = Methodlar.EmailileGetir(txtAranacak.Text.Replace(" ", "").Trim(),"");

						if (sonuc.Count != 0)
						{
							dgwKisiData.DataSource = sonuc;
						}
						else
						{
							MessageBox.Show("Kisi Bulunamadı!");
							txtAranacak.Text = "";
						}
					}
					else
					{
						sonuc = Methodlar.EmailileGetir(txtAranacak.Text.Replace(" ", "").Trim());

						if (sonuc.Count != 0)
						{
							dgwKisiData.DataSource = sonuc;
						}
						else
						{
							MessageBox.Show("Kisi Bulunamadı!");
							txtAranacak.Text = "";
						}
					}
				}
				else
				{
					MessageBox.Show("Email Formatı Doğru Değil '@' İşareti İçermiyor!");
				}

			}
			else
			{
				MessageBox.Show("Arama Kutusu Boş Geçilemez!");
			}
		}
	}
}
