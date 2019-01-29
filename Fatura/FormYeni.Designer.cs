namespace Fatura
{
    partial class FormYeni
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboSehir = new System.Windows.Forms.ComboBox();
            this.comboİlce = new System.Windows.Forms.ComboBox();
            this.comboMusteri = new System.Windows.Forms.ComboBox();
            this.textIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.dateTimeOdeme = new System.Windows.Forms.DateTimePicker();
            this.comboUrunAdi = new System.Windows.Forms.ComboBox();
            this.textUrunFiyati = new System.Windows.Forms.TextBox();
            this.textBrim = new System.Windows.Forms.TextBox();
            this.textKdv = new System.Windows.Forms.TextBox();
            this.UrunMiktari = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeOdeme);
            this.groupBox1.Controls.Add(this.textIrsaliyeNo);
            this.groupBox1.Controls.Add(this.comboMusteri);
            this.groupBox1.Controls.Add(this.comboİlce);
            this.groupBox1.Controls.Add(this.comboSehir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Ve İrsaliye";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.UrunMiktari);
            this.groupBox2.Controls.Add(this.textKdv);
            this.groupBox2.Controls.Add(this.textBrim);
            this.groupBox2.Controls.Add(this.textUrunFiyati);
            this.groupBox2.Controls.Add(this.comboUrunAdi);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(353, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 351);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatura No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şehir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "İlçe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Müşteri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "İrsaliye No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Ürün Miktarı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "KDV";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ürün Birimi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ürün Fiyatı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Ürün Adı";
            // 
            // comboSehir
            // 
            this.comboSehir.FormattingEnabled = true;
            this.comboSehir.Location = new System.Drawing.Point(84, 67);
            this.comboSehir.Name = "comboSehir";
            this.comboSehir.Size = new System.Drawing.Size(200, 21);
            this.comboSehir.TabIndex = 1;
            // 
            // comboİlce
            // 
            this.comboİlce.FormattingEnabled = true;
            this.comboİlce.Location = new System.Drawing.Point(84, 107);
            this.comboİlce.Name = "comboİlce";
            this.comboİlce.Size = new System.Drawing.Size(200, 21);
            this.comboİlce.TabIndex = 2;
            // 
            // comboMusteri
            // 
            this.comboMusteri.FormattingEnabled = true;
            this.comboMusteri.Location = new System.Drawing.Point(84, 144);
            this.comboMusteri.Name = "comboMusteri";
            this.comboMusteri.Size = new System.Drawing.Size(200, 21);
            this.comboMusteri.TabIndex = 3;
            // 
            // textIrsaliyeNo
            // 
            this.textIrsaliyeNo.Location = new System.Drawing.Point(84, 180);
            this.textIrsaliyeNo.Name = "textIrsaliyeNo";
            this.textIrsaliyeNo.Size = new System.Drawing.Size(200, 20);
            this.textIrsaliyeNo.TabIndex = 4;
            // 
            // dateTimeOdeme
            // 
            this.dateTimeOdeme.Location = new System.Drawing.Point(84, 221);
            this.dateTimeOdeme.Name = "dateTimeOdeme";
            this.dateTimeOdeme.Size = new System.Drawing.Size(200, 20);
            this.dateTimeOdeme.TabIndex = 5;
            // 
            // comboUrunAdi
            // 
            this.comboUrunAdi.FormattingEnabled = true;
            this.comboUrunAdi.Location = new System.Drawing.Point(94, 62);
            this.comboUrunAdi.Name = "comboUrunAdi";
            this.comboUrunAdi.Size = new System.Drawing.Size(200, 21);
            this.comboUrunAdi.TabIndex = 6;
            // 
            // textUrunFiyati
            // 
            this.textUrunFiyati.Location = new System.Drawing.Point(94, 103);
            this.textUrunFiyati.Name = "textUrunFiyati";
            this.textUrunFiyati.Size = new System.Drawing.Size(200, 20);
            this.textUrunFiyati.TabIndex = 6;
            // 
            // textBrim
            // 
            this.textBrim.Location = new System.Drawing.Point(94, 144);
            this.textBrim.Name = "textBrim";
            this.textBrim.Size = new System.Drawing.Size(200, 20);
            this.textBrim.TabIndex = 7;
            // 
            // textKdv
            // 
            this.textKdv.Location = new System.Drawing.Point(94, 178);
            this.textKdv.Name = "textKdv";
            this.textKdv.Size = new System.Drawing.Size(200, 20);
            this.textKdv.TabIndex = 8;
            // 
            // UrunMiktari
            // 
            this.UrunMiktari.Location = new System.Drawing.Point(94, 220);
            this.UrunMiktari.Name = "UrunMiktari";
            this.UrunMiktari.Size = new System.Drawing.Size(200, 20);
            this.UrunMiktari.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ürün Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Ürün Sil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(694, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 13;
            this.button4.Text = "Fatura Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 226);
            this.dataGridView1.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(694, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 70);
            this.button5.TabIndex = 15;
            this.button5.Text = "Liste Temizle";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FormYeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormYeni";
            this.Text = "FormYeni";
            this.Load += new System.EventHandler(this.FormYeni_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UrunMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimeOdeme;
        private System.Windows.Forms.TextBox textIrsaliyeNo;
        private System.Windows.Forms.ComboBox comboMusteri;
        private System.Windows.Forms.ComboBox comboİlce;
        private System.Windows.Forms.ComboBox comboSehir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown UrunMiktari;
        private System.Windows.Forms.TextBox textKdv;
        private System.Windows.Forms.TextBox textBrim;
        private System.Windows.Forms.TextBox textUrunFiyati;
        private System.Windows.Forms.ComboBox comboUrunAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
    }
}