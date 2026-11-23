using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}
		Random rnd = new Random();
		private void tmrRenk_Tick(object sender, EventArgs e)
		{
			pcbRenk.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
		}

		private void Form4_Load(object sender, EventArgs e)
		{

		}
	}
}
