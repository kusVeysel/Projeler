namespace MayinTarlasi
{
	partial class Form4
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
			this.pcbRenk = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tmrRenk = new System.Windows.Forms.Timer(this.components);
			this.txtSkorListe = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbRenk)).BeginInit();
			this.SuspendLayout();
			// 
			// pcbRenk
			// 
			this.pcbRenk.Location = new System.Drawing.Point(0, 0);
			this.pcbRenk.Name = "pcbRenk";
			this.pcbRenk.Size = new System.Drawing.Size(799, 108);
			this.pcbRenk.TabIndex = 0;
			this.pcbRenk.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Poplar Std", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(311, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "SKORLAR";
			// 
			// tmrRenk
			// 
			this.tmrRenk.Enabled = true;
			this.tmrRenk.Interval = 75;
			this.tmrRenk.Tick += new System.EventHandler(this.tmrRenk_Tick);
			// 
			// txtSkorListe
			// 
			this.txtSkorListe.Location = new System.Drawing.Point(12, 114);
			this.txtSkorListe.Multiline = true;
			this.txtSkorListe.Name = "txtSkorListe";
			this.txtSkorListe.Size = new System.Drawing.Size(776, 658);
			this.txtSkorListe.TabIndex = 2;
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 784);
			this.Controls.Add(this.txtSkorListe);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pcbRenk);
			this.Name = "Form4";
			this.Text = "Form4";
			this.Load += new System.EventHandler(this.Form4_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbRenk)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbRenk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer tmrRenk;
		public System.Windows.Forms.TextBox txtSkorListe;
	}
}