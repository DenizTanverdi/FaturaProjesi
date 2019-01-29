namespace Fatura
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilceEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleSorgulaDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsteriToolStripMenuItem,
            this.birimEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.ilEkleToolStripMenuItem,
            this.ilceEkleToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // müsteriToolStripMenuItem
            // 
            this.müsteriToolStripMenuItem.Name = "müsteriToolStripMenuItem";
            this.müsteriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müsteriToolStripMenuItem.Text = "Müsteri  Ekle";
            // 
            // birimEkleToolStripMenuItem
            // 
            this.birimEkleToolStripMenuItem.Name = "birimEkleToolStripMenuItem";
            this.birimEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.birimEkleToolStripMenuItem.Text = "Birim Ekle";
            this.birimEkleToolStripMenuItem.Click += new System.EventHandler(this.birimEkleToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.urunEkleToolStripMenuItem.Text = "Urun Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilceEkleToolStripMenuItem
            // 
            this.ilceEkleToolStripMenuItem.Name = "ilceEkleToolStripMenuItem";
            this.ilceEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ilceEkleToolStripMenuItem.Text = "İlce Ekle";
            this.ilceEkleToolStripMenuItem.Click += new System.EventHandler(this.ilceEkleToolStripMenuItem_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleSorgulaDüzenleToolStripMenuItem,
            this.yeniFaturaOluşturToolStripMenuItem});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // görüntüleSorgulaDüzenleToolStripMenuItem
            // 
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Name = "görüntüleSorgulaDüzenleToolStripMenuItem";
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Text = "Görüntüle/Sorgula/Düzenle";
            // 
            // yeniFaturaOluşturToolStripMenuItem
            // 
            this.yeniFaturaOluşturToolStripMenuItem.Name = "yeniFaturaOluşturToolStripMenuItem";
            this.yeniFaturaOluşturToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.yeniFaturaOluşturToolStripMenuItem.Text = "Yeni Fatura Oluştur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilceEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleSorgulaDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaOluşturToolStripMenuItem;
    }
}

