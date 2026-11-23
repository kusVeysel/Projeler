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
			this.label1 = new System.Windows.Forms.Label();
			this.txtAranacak = new System.Windows.Forms.TextBox();
			this.btnTelefon = new System.Windows.Forms.Button();
			this.dgwKisiData = new System.Windows.Forms.DataGridView();
			this.btnEmail = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwKisiData)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Aranacak Bilgi:";
			// 
			// txtAranacak
			// 
			this.txtAranacak.Location = new System.Drawing.Point(12, 49);
			this.txtAranacak.Name = "txtAranacak";
			this.txtAranacak.Size = new System.Drawing.Size(335, 22);
			this.txtAranacak.TabIndex = 1;
			// 
			// btnTelefon
			// 
			this.btnTelefon.Location = new System.Drawing.Point(375, 42);
			this.btnTelefon.Name = "btnTelefon";
			this.btnTelefon.Size = new System.Drawing.Size(133, 37);
			this.btnTelefon.TabIndex = 2;
			this.btnTelefon.Text = "Telefon ile Ara";
			this.btnTelefon.UseVisualStyleBackColor = true;
			this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
			// 
			// dgwKisiData
			// 
			this.dgwKisiData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwKisiData.Location = new System.Drawing.Point(12, 195);
			this.dgwKisiData.Name = "dgwKisiData";
			this.dgwKisiData.RowHeadersWidth = 51;
			this.dgwKisiData.RowTemplate.Height = 24;
			this.dgwKisiData.Size = new System.Drawing.Size(1046, 498);
			this.dgwKisiData.TabIndex = 3;
			// 
			// btnEmail
			// 
			this.btnEmail.Location = new System.Drawing.Point(527, 42);
			this.btnEmail.Name = "btnEmail";
			this.btnEmail.Size = new System.Drawing.Size(133, 37);
			this.btnEmail.TabIndex = 4;
			this.btnEmail.Text = "Email ile Ara";
			this.btnEmail.UseVisualStyleBackColor = true;
			this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1070, 715);
			this.Controls.Add(this.btnEmail);
			this.Controls.Add(this.dgwKisiData);
			this.Controls.Add(this.btnTelefon);
			this.Controls.Add(this.txtAranacak);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgwKisiData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAranacak;
		private System.Windows.Forms.Button btnTelefon;
		private System.Windows.Forms.DataGridView dgwKisiData;
		private System.Windows.Forms.Button btnEmail;
	}
}

