namespace MayinTarlasi
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.rdKolay = new System.Windows.Forms.RadioButton();
			this.rdOrta = new System.Windows.Forms.RadioButton();
			this.rdZor = new System.Windows.Forms.RadioButton();
			this.txtSutun = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSatir = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtIsim = new System.Windows.Forms.TextBox();
			this.btnSkor = new System.Windows.Forms.Button();
			this.btnOyunuBaslat = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::MayinTarlasi.Properties.Resources.giphy;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1069, 938);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// rdKolay
			// 
			this.rdKolay.AutoSize = true;
			this.rdKolay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rdKolay.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdKolay.ForeColor = System.Drawing.SystemColors.Control;
			this.rdKolay.Location = new System.Drawing.Point(28, 22);
			this.rdKolay.Name = "rdKolay";
			this.rdKolay.Size = new System.Drawing.Size(100, 36);
			this.rdKolay.TabIndex = 1;
			this.rdKolay.TabStop = true;
			this.rdKolay.Text = "KOLAY";
			this.rdKolay.UseVisualStyleBackColor = false;
			// 
			// rdOrta
			// 
			this.rdOrta.AutoSize = true;
			this.rdOrta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rdOrta.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdOrta.ForeColor = System.Drawing.SystemColors.Control;
			this.rdOrta.Location = new System.Drawing.Point(28, 64);
			this.rdOrta.Name = "rdOrta";
			this.rdOrta.Size = new System.Drawing.Size(89, 36);
			this.rdOrta.TabIndex = 2;
			this.rdOrta.TabStop = true;
			this.rdOrta.Text = "ORTA";
			this.rdOrta.UseVisualStyleBackColor = false;
			// 
			// rdZor
			// 
			this.rdZor.AutoSize = true;
			this.rdZor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.rdZor.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdZor.ForeColor = System.Drawing.SystemColors.Control;
			this.rdZor.Location = new System.Drawing.Point(28, 106);
			this.rdZor.Name = "rdZor";
			this.rdZor.Size = new System.Drawing.Size(75, 36);
			this.rdZor.TabIndex = 3;
			this.rdZor.TabStop = true;
			this.rdZor.Text = "ZOR";
			this.rdZor.UseVisualStyleBackColor = false;
			// 
			// txtSutun
			// 
			this.txtSutun.Location = new System.Drawing.Point(940, 22);
			this.txtSutun.Name = "txtSutun";
			this.txtSutun.Size = new System.Drawing.Size(100, 22);
			this.txtSutun.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(843, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 28);
			this.label1.TabIndex = 5;
			this.label1.Text = "SÜTUN";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(843, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 28);
			this.label2.TabIndex = 7;
			this.label2.Text = "SATIR";
			// 
			// txtSatir
			// 
			this.txtSatir.Location = new System.Drawing.Point(940, 64);
			this.txtSatir.Name = "txtSatir";
			this.txtSatir.Size = new System.Drawing.Size(100, 22);
			this.txtSatir.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label3.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(276, 332);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 28);
			this.label3.TabIndex = 9;
			this.label3.Text = "Oyuncu İsim";
			// 
			// txtIsim
			// 
			this.txtIsim.Location = new System.Drawing.Point(410, 338);
			this.txtIsim.Name = "txtIsim";
			this.txtIsim.Size = new System.Drawing.Size(285, 22);
			this.txtIsim.TabIndex = 8;
			// 
			// btnSkor
			// 
			this.btnSkor.Location = new System.Drawing.Point(12, 869);
			this.btnSkor.Name = "btnSkor";
			this.btnSkor.Size = new System.Drawing.Size(172, 57);
			this.btnSkor.TabIndex = 10;
			this.btnSkor.Text = "Skor Tablosu";
			this.btnSkor.UseVisualStyleBackColor = true;
			this.btnSkor.Click += new System.EventHandler(this.btnSkor_Click);
			// 
			// btnOyunuBaslat
			// 
			this.btnOyunuBaslat.Location = new System.Drawing.Point(885, 869);
			this.btnOyunuBaslat.Name = "btnOyunuBaslat";
			this.btnOyunuBaslat.Size = new System.Drawing.Size(172, 57);
			this.btnOyunuBaslat.TabIndex = 11;
			this.btnOyunuBaslat.Text = "Oyunu Başlat";
			this.btnOyunuBaslat.UseVisualStyleBackColor = true;
			this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 938);
			this.Controls.Add(this.btnOyunuBaslat);
			this.Controls.Add(this.btnSkor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtIsim);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtSatir);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtSutun);
			this.Controls.Add(this.rdZor);
			this.Controls.Add(this.rdOrta);
			this.Controls.Add(this.rdKolay);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form2";
			this.Text = "Form2";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RadioButton rdKolay;
		private System.Windows.Forms.RadioButton rdOrta;
		private System.Windows.Forms.RadioButton rdZor;
		private System.Windows.Forms.TextBox txtSutun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSatir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIsim;
		private System.Windows.Forms.Button btnSkor;
		private System.Windows.Forms.Button btnOyunuBaslat;
		private System.Windows.Forms.Timer timer1;
	}
}