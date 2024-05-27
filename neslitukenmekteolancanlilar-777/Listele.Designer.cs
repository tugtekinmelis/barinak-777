namespace neslitukenmekteolancanlilar_777
{
    partial class Listele
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPopulasyon = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.dgwCanli = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 102);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(108, 45);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(120, 167);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(108, 45);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Popülasyon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ülke";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ad";
            // 
            // txtPopulasyon
            // 
            this.txtPopulasyon.Location = new System.Drawing.Point(364, 172);
            this.txtPopulasyon.Name = "txtPopulasyon";
            this.txtPopulasyon.Size = new System.Drawing.Size(100, 20);
            this.txtPopulasyon.TabIndex = 11;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(364, 136);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(100, 20);
            this.txtUlke.TabIndex = 10;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(364, 102);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 9;
            // 
            // dgwCanli
            // 
            this.dgwCanli.AllowUserToAddRows = false;
            this.dgwCanli.AllowUserToDeleteRows = false;
            this.dgwCanli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCanli.Location = new System.Drawing.Point(51, 263);
            this.dgwCanli.Name = "dgwCanli";
            this.dgwCanli.ReadOnly = true;
            this.dgwCanli.Size = new System.Drawing.Size(711, 240);
            this.dgwCanli.TabIndex = 15;
            this.dgwCanli.SelectionChanged += new System.EventHandler(this.dgwCanli_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Resim";
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(537, 70);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(167, 157);
            this.pbResim.TabIndex = 16;
            this.pbResim.TabStop = false;
            this.pbResim.Click += new System.EventHandler(this.pbResim_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(24, 37);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(189, 20);
            this.txtAra.TabIndex = 18;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(250, 24);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(108, 45);
            this.btnAra.TabIndex = 19;
            this.btnAra.Text = "Arama";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 544);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.dgwCanli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPopulasyon);
            this.Controls.Add(this.txtUlke);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "Listele";
            this.Text = "Listele";
            this.Load += new System.EventHandler(this.Listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPopulasyon;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.DataGridView dgwCanli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAra;
    }
}