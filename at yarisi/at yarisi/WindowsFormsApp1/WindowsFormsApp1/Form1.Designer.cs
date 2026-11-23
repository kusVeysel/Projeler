namespace WindowsFormsApp1
{
	partial class Form1
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
			this.btnYarisiBaslat = new System.Windows.Forms.Button();
			this.btnYarisiSifirla = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblFinishLine = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pcbAt1 = new System.Windows.Forms.PictureBox();
			this.pcbAt2 = new System.Windows.Forms.PictureBox();
			this.pcbAt3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnYarisiBaslat
			// 
			this.btnYarisiBaslat.Location = new System.Drawing.Point(22, 619);
			this.btnYarisiBaslat.Name = "btnYarisiBaslat";
			this.btnYarisiBaslat.Size = new System.Drawing.Size(120, 39);
			this.btnYarisiBaslat.TabIndex = 0;
			this.btnYarisiBaslat.Text = "Yarışı Başlat";
			this.btnYarisiBaslat.UseVisualStyleBackColor = true;
			this.btnYarisiBaslat.Click += new System.EventHandler(this.btnYarisiBaslat_Click);
			// 
			// btnYarisiSifirla
			// 
			this.btnYarisiSifirla.Enabled = false;
			this.btnYarisiSifirla.Location = new System.Drawing.Point(166, 619);
			this.btnYarisiSifirla.Name = "btnYarisiSifirla";
			this.btnYarisiSifirla.Size = new System.Drawing.Size(120, 39);
			this.btnYarisiSifirla.TabIndex = 1;
			this.btnYarisiSifirla.Text = "Yarışı Sıfırla";
			this.btnYarisiSifirla.UseVisualStyleBackColor = true;
			this.btnYarisiSifirla.Click += new System.EventHandler(this.btnYarisiSifirla_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Ivory;
			this.label1.Location = new System.Drawing.Point(12, 181);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1148, 10);
			this.label1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Ivory;
			this.label2.Location = new System.Drawing.Point(12, 402);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1148, 10);
			this.label2.TabIndex = 3;
			// 
			// lblFinishLine
			// 
			this.lblFinishLine.BackColor = System.Drawing.Color.Ivory;
			this.lblFinishLine.Location = new System.Drawing.Point(1159, 25);
			this.lblFinishLine.Name = "lblFinishLine";
			this.lblFinishLine.Size = new System.Drawing.Size(11, 642);
			this.lblFinishLine.TabIndex = 4;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pcbAt1
			// 
			this.pcbAt1.Enabled = false;
			this.pcbAt1.Image = global::WindowsFormsApp1.Properties.Resources._1;
			this.pcbAt1.Location = new System.Drawing.Point(22, 25);
			this.pcbAt1.Name = "pcbAt1";
			this.pcbAt1.Size = new System.Drawing.Size(197, 125);
			this.pcbAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbAt1.TabIndex = 5;
			this.pcbAt1.TabStop = false;
			// 
			// pcbAt2
			// 
			this.pcbAt2.Enabled = false;
			this.pcbAt2.Image = global::WindowsFormsApp1.Properties.Resources._2;
			this.pcbAt2.Location = new System.Drawing.Point(22, 240);
			this.pcbAt2.Name = "pcbAt2";
			this.pcbAt2.Size = new System.Drawing.Size(197, 127);
			this.pcbAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbAt2.TabIndex = 6;
			this.pcbAt2.TabStop = false;
			// 
			// pcbAt3
			// 
			this.pcbAt3.Enabled = false;
			this.pcbAt3.Image = global::WindowsFormsApp1.Properties.Resources._3;
			this.pcbAt3.Location = new System.Drawing.Point(22, 445);
			this.pcbAt3.Name = "pcbAt3";
			this.pcbAt3.Size = new System.Drawing.Size(197, 130);
			this.pcbAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbAt3.TabIndex = 7;
			this.pcbAt3.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.ClientSize = new System.Drawing.Size(1222, 697);
			this.Controls.Add(this.pcbAt3);
			this.Controls.Add(this.pcbAt2);
			this.Controls.Add(this.pcbAt1);
			this.Controls.Add(this.lblFinishLine);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnYarisiSifirla);
			this.Controls.Add(this.btnYarisiBaslat);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbAt1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAt2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbAt3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnYarisiBaslat;
		private System.Windows.Forms.Button btnYarisiSifirla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblFinishLine;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pcbAt1;
		private System.Windows.Forms.PictureBox pcbAt2;
		private System.Windows.Forms.PictureBox pcbAt3;
	}
}

