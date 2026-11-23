using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
        }
        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
                btnYarisiBaslat.Text = "Yarışı Başlat";
            }
            else
            {
                timer1.Start();
                pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = true;
                btnYarisiBaslat.Text = "Yarışı Durdur";
            }
        }

        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbAt1.Left += rnd.Next(2, 9);
            pcbAt2.Left += rnd.Next(2, 9);
            pcbAt3.Left += rnd.Next(2, 9);

            if (pcbAt1.Left > pcbAt2.Left && pcbAt1.Left > pcbAt3.Left)
            {
                this.Text = "BoldPilot Önde Gidiyor";
            }
            else if (pcbAt2.Left > pcbAt1.Left && pcbAt2.Left > pcbAt3.Left)
            {
                this.Text = "Gülbatur Önde Gidiyor";
            }
            else if (pcbAt3.Left > pcbAt1.Left && pcbAt3.Left > pcbAt2.Left)
            {
                this.Text = "Şahbatur Önde Gidiyor";
            }

            if (pcbAt1.Left + pcbAt1.Width >= lblFinishLine.Left)
            {
                timer1.Stop();
                pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
                MessageBox.Show("BoldPilot Yarışı Kazandı");
                btnYarisiSifirla.Enabled = true;
                btnYarisiBaslat.Text = "Yarışı Başlat";
            }
            else if (pcbAt2.Left + pcbAt2.Width >= lblFinishLine.Left)
            {
                timer1.Stop();
                pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
                MessageBox.Show("Gülbatur Yarışı Kazandı");
                btnYarisiSifirla.Enabled = true;
                btnYarisiBaslat.Text = "Yarışı Başlat";

            }
            else if (pcbAt3.Left + pcbAt3.Width >= lblFinishLine.Left)
            {
                timer1.Stop();
                pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
                MessageBox.Show("Şahbatur Yarışı Kazandı");
                btnYarisiSifirla.Enabled = true;
                btnYarisiBaslat.Text = "Yarışı Başlat";
            }
        }

        private void btnYarisiSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbAt1.Left = pcbAt2.Left = pcbAt3.Left = 20;
            pcbAt1.Enabled = pcbAt2.Enabled = pcbAt3.Enabled = false;
            btnYarisiSifirla.Enabled = false;
            btnYarisiBaslat.Text = "Yarışı Başlat";
        }
    }
}
