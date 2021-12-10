
namespace RentACarFormApplication
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
            this.tanimlamalarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.islemlerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.istatistiklerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkindaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.subeTanimlamaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciTanimlamaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aracTanimlamaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriTanimlamaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aracRezerveEtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aracKiralaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.araciBakimaAlMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sozlesmelerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.araclarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.musterilerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonlarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriIstatistikleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aracIstatistikleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.bakimIstatistikleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.kilometreKontroluSayaciMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aracGiderIstatistikleriMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimataGoreAraclarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanimlamalarMenu,
            this.islemlerMenu,
            this.istatistiklerMenu,
            this.hakkindaMenu,
            this.cikisMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanimlamalarMenu
            // 
            this.tanimlamalarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subeTanimlamaMenu,
            this.kullaniciTanimlamaMenu,
            this.aracTanimlamaMenu,
            this.musteriTanimlamaMenu});
            this.tanimlamalarMenu.Name = "tanimlamalarMenu";
            this.tanimlamalarMenu.Size = new System.Drawing.Size(112, 24);
            this.tanimlamalarMenu.Text = "Tanımlamalar";
            // 
            // islemlerMenu
            // 
            this.islemlerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracRezerveEtMenu,
            this.aracKiralaMenu,
            this.araciBakimaAlMenu,
            this.sozlesmelerMenu,
            this.araclarMenu,
            this.musterilerMenu,
            this.rezervasyonlarMenu});
            this.islemlerMenu.Name = "islemlerMenu";
            this.islemlerMenu.Size = new System.Drawing.Size(75, 24);
            this.islemlerMenu.Text = "İşlemler";
            // 
            // istatistiklerMenu
            // 
            this.istatistiklerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriIstatistikleriMenu,
            this.aracIstatistikleriMenu,
            this.bakimIstatistikleriMenu,
            this.kilometreKontroluSayaciMenu,
            this.aracGiderIstatistikleriMenu,
            this.teslimataGoreAraclarMenu});
            this.istatistiklerMenu.Name = "istatistiklerMenu";
            this.istatistiklerMenu.Size = new System.Drawing.Size(94, 24);
            this.istatistiklerMenu.Text = "İstatistikler";
            // 
            // hakkindaMenu
            // 
            this.hakkindaMenu.Name = "hakkindaMenu";
            this.hakkindaMenu.Size = new System.Drawing.Size(85, 24);
            this.hakkindaMenu.Text = "Hakkında";
            // 
            // cikisMenu
            // 
            this.cikisMenu.Name = "cikisMenu";
            this.cikisMenu.Size = new System.Drawing.Size(53, 24);
            this.cikisMenu.Text = "Çıkış";
            // 
            // subeTanimlamaMenu
            // 
            this.subeTanimlamaMenu.Name = "subeTanimlamaMenu";
            this.subeTanimlamaMenu.Size = new System.Drawing.Size(224, 26);
            this.subeTanimlamaMenu.Text = "Şube Tanımlama";
            this.subeTanimlamaMenu.Click += new System.EventHandler(this.subeTanimlamaMenu_Click);
            // 
            // kullaniciTanimlamaMenu
            // 
            this.kullaniciTanimlamaMenu.Name = "kullaniciTanimlamaMenu";
            this.kullaniciTanimlamaMenu.Size = new System.Drawing.Size(224, 26);
            this.kullaniciTanimlamaMenu.Text = "Kullanıcı Tanımlama";
            this.kullaniciTanimlamaMenu.Click += new System.EventHandler(this.kullaniciTanimlamaMenu_Click);
            // 
            // aracTanimlamaMenu
            // 
            this.aracTanimlamaMenu.Name = "aracTanimlamaMenu";
            this.aracTanimlamaMenu.Size = new System.Drawing.Size(224, 26);
            this.aracTanimlamaMenu.Text = "Araç Tanımlama";
            this.aracTanimlamaMenu.Click += new System.EventHandler(this.aracTanimlamaMenu_Click);
            // 
            // musteriTanimlamaMenu
            // 
            this.musteriTanimlamaMenu.Name = "musteriTanimlamaMenu";
            this.musteriTanimlamaMenu.Size = new System.Drawing.Size(224, 26);
            this.musteriTanimlamaMenu.Text = "Müşteri Tanımlama";
            this.musteriTanimlamaMenu.Click += new System.EventHandler(this.musteriTanimlamaMenu_Click);
            // 
            // aracRezerveEtMenu
            // 
            this.aracRezerveEtMenu.Name = "aracRezerveEtMenu";
            this.aracRezerveEtMenu.Size = new System.Drawing.Size(224, 26);
            this.aracRezerveEtMenu.Text = "Araç Rezerve Et";
            this.aracRezerveEtMenu.Click += new System.EventHandler(this.aracRezerveEtMenu_Click);
            // 
            // aracKiralaMenu
            // 
            this.aracKiralaMenu.Name = "aracKiralaMenu";
            this.aracKiralaMenu.Size = new System.Drawing.Size(224, 26);
            this.aracKiralaMenu.Text = "Araç Kirala";
            this.aracKiralaMenu.Click += new System.EventHandler(this.aracKiralaMenu_Click);
            // 
            // araciBakimaAlMenu
            // 
            this.araciBakimaAlMenu.Name = "araciBakimaAlMenu";
            this.araciBakimaAlMenu.Size = new System.Drawing.Size(224, 26);
            this.araciBakimaAlMenu.Text = "Aracı Bakıma Al";
            this.araciBakimaAlMenu.Click += new System.EventHandler(this.araciBakimaAlMenu_Click);
            // 
            // sozlesmelerMenu
            // 
            this.sozlesmelerMenu.Name = "sozlesmelerMenu";
            this.sozlesmelerMenu.Size = new System.Drawing.Size(224, 26);
            this.sozlesmelerMenu.Text = "Sözleşmeler";
            // 
            // araclarMenu
            // 
            this.araclarMenu.Name = "araclarMenu";
            this.araclarMenu.Size = new System.Drawing.Size(224, 26);
            this.araclarMenu.Text = "Araçlar";
            this.araclarMenu.Click += new System.EventHandler(this.araclarMenu_Click);
            // 
            // musterilerMenu
            // 
            this.musterilerMenu.Name = "musterilerMenu";
            this.musterilerMenu.Size = new System.Drawing.Size(224, 26);
            this.musterilerMenu.Text = "Müşteriler";
            this.musterilerMenu.Click += new System.EventHandler(this.musterilerMenu_Click);
            // 
            // rezervasyonlarMenu
            // 
            this.rezervasyonlarMenu.Name = "rezervasyonlarMenu";
            this.rezervasyonlarMenu.Size = new System.Drawing.Size(224, 26);
            this.rezervasyonlarMenu.Text = "Rezervasyonlar";
            this.rezervasyonlarMenu.Click += new System.EventHandler(this.rezervasyonlarMenu_Click);
            // 
            // musteriIstatistikleriMenu
            // 
            this.musteriIstatistikleriMenu.Name = "musteriIstatistikleriMenu";
            this.musteriIstatistikleriMenu.Size = new System.Drawing.Size(264, 26);
            this.musteriIstatistikleriMenu.Text = "Müşteri İstatistikleri";
            this.musteriIstatistikleriMenu.Click += new System.EventHandler(this.musteriIstatistikleriMenu_Click);
            // 
            // aracIstatistikleriMenu
            // 
            this.aracIstatistikleriMenu.Name = "aracIstatistikleriMenu";
            this.aracIstatistikleriMenu.Size = new System.Drawing.Size(264, 26);
            this.aracIstatistikleriMenu.Text = "Araç İstatistikleri";
            this.aracIstatistikleriMenu.Click += new System.EventHandler(this.aracIstatistikleriMenu_Click);
            // 
            // bakimIstatistikleriMenu
            // 
            this.bakimIstatistikleriMenu.Name = "bakimIstatistikleriMenu";
            this.bakimIstatistikleriMenu.Size = new System.Drawing.Size(264, 26);
            this.bakimIstatistikleriMenu.Text = "Bakım İstatistikleri";
            this.bakimIstatistikleriMenu.Click += new System.EventHandler(this.bakimIstatistikleriMenu_Click);
            // 
            // kilometreKontroluSayaciMenu
            // 
            this.kilometreKontroluSayaciMenu.Name = "kilometreKontroluSayaciMenu";
            this.kilometreKontroluSayaciMenu.Size = new System.Drawing.Size(264, 26);
            this.kilometreKontroluSayaciMenu.Text = "Kilometre Kontrolü Sayacı";
            // 
            // aracGiderIstatistikleriMenu
            // 
            this.aracGiderIstatistikleriMenu.Name = "aracGiderIstatistikleriMenu";
            this.aracGiderIstatistikleriMenu.Size = new System.Drawing.Size(264, 26);
            this.aracGiderIstatistikleriMenu.Text = "Araç Gider İstatistikleri";
            // 
            // teslimataGoreAraclarMenu
            // 
            this.teslimataGoreAraclarMenu.Name = "teslimataGoreAraclarMenu";
            this.teslimataGoreAraclarMenu.Size = new System.Drawing.Size(264, 26);
            this.teslimataGoreAraclarMenu.Text = "Teslimata Göre Araçlar";
            this.teslimataGoreAraclarMenu.Click += new System.EventHandler(this.teslimataGoreAraclarMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rent A Car";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanimlamalarMenu;
        private System.Windows.Forms.ToolStripMenuItem islemlerMenu;
        private System.Windows.Forms.ToolStripMenuItem istatistiklerMenu;
        private System.Windows.Forms.ToolStripMenuItem hakkindaMenu;
        private System.Windows.Forms.ToolStripMenuItem subeTanimlamaMenu;
        private System.Windows.Forms.ToolStripMenuItem kullaniciTanimlamaMenu;
        private System.Windows.Forms.ToolStripMenuItem aracTanimlamaMenu;
        private System.Windows.Forms.ToolStripMenuItem musteriTanimlamaMenu;
        private System.Windows.Forms.ToolStripMenuItem aracRezerveEtMenu;
        private System.Windows.Forms.ToolStripMenuItem aracKiralaMenu;
        private System.Windows.Forms.ToolStripMenuItem araciBakimaAlMenu;
        private System.Windows.Forms.ToolStripMenuItem sozlesmelerMenu;
        private System.Windows.Forms.ToolStripMenuItem araclarMenu;
        private System.Windows.Forms.ToolStripMenuItem musterilerMenu;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonlarMenu;
        private System.Windows.Forms.ToolStripMenuItem cikisMenu;
        private System.Windows.Forms.ToolStripMenuItem musteriIstatistikleriMenu;
        private System.Windows.Forms.ToolStripMenuItem aracIstatistikleriMenu;
        private System.Windows.Forms.ToolStripMenuItem bakimIstatistikleriMenu;
        private System.Windows.Forms.ToolStripMenuItem kilometreKontroluSayaciMenu;
        private System.Windows.Forms.ToolStripMenuItem aracGiderIstatistikleriMenu;
        private System.Windows.Forms.ToolStripMenuItem teslimataGoreAraclarMenu;
    }
}

