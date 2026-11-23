using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public static class Methodlar
	{
		public static List<Kisi> KisiListesiGetir()
		{
			List<Kisi> kisiListe = new List<Kisi>();

			Kisi kisi1 = new Kisi
			{
				ID = 1,
				Isim = "Betül",
				Soyisim = "Afşar",
				TcNo = "12345678910",
				Telefon = "02125269024",
				Email = "betulafsar@hotmail.com",
				AktifMi = true
			};
			Kisi kisi2 = new Kisi
			{
				ID = 2,
				Isim = "Cansu",
				Soyisim = "İşyar",
				TcNo = "12345678911",
				Telefon = "02125269025",
				Email = "cansuisyar@gmail.com",
				AktifMi = false
			};
			Kisi kisi3 = new Kisi
			{
				ID = 3,
				Isim = "İbrahim",
				Soyisim = "Çelik",
				TcNo = "12345678912",
				Telefon = "02125269026",
				Email = "ibrahimcelik@gmail.com",
				AktifMi = true
			};
			Kisi kisi4 = new Kisi
			{
				ID = 4,
				Isim = "Efe",
				Soyisim = "Karşıyakalı",
				TcNo = "12345678913",
				Telefon = "02125269027",
				Email = "efekarsiyakali@gmail.com",
				AktifMi = false
			};

			kisiListe.Add(kisi1);
			kisiListe.Add(kisi2);
			kisiListe.Add(kisi3);
			kisiListe.Add(kisi4);

			return kisiListe.Distinct().ToList();

		}

		public static List<Kisi> TelefonileGetir(string tel)
		{
			List<Kisi> sonuc;

			List<Kisi> kisiListesi = KisiListesiGetir();

			sonuc = kisiListesi.Where(x => x.Telefon == tel).ToList();
			if (sonuc == null)
			{
				sonuc = new List<Kisi>();
				return sonuc;
			}
			else
			{
				return sonuc;
			}
		}

		public static List<Kisi> EmailileGetir(string mail)
		{
			List<Kisi> sonuc;

			List<Kisi> kisiListesi = KisiListesiGetir();

			sonuc = kisiListesi.Where(x => x.Email == mail).ToList();
			if (sonuc == null)
			{
				sonuc = new List<Kisi>();
				return sonuc;
			}
			else
			{
				return sonuc;
			}
		}

		public static List<Kisi> EmailileGetir(string uzanti,string deger = null)
		{
			List<Kisi> sonuc;

			List<Kisi> kisiListesi = KisiListesiGetir();

			sonuc = kisiListesi.Where(x => x.Email.Contains(uzanti)).ToList();
			if (sonuc == null)
			{
				sonuc = new List<Kisi>();
				return sonuc;
			}
			else
			{
				return sonuc;
			}


		}
	}
}
