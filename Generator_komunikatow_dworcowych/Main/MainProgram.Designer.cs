namespace Generator_komunikatów_dworcowych
{
    public partial class komunikaty
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(komunikaty));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.wersja = new System.Windows.Forms.ToolStripStatusLabel();
            this.podpis = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageOpcje = new System.Windows.Forms.TabPage();
            this.trackBarGlosnoscGongu = new System.Windows.Forms.TrackBar();
            this.GlosnoscGonguTXT = new System.Windows.Forms.Label();
            this.GlosnoscSyntezatoraTXT = new System.Windows.Forms.Label();
            this.trackBarGlosnoscOgolna = new System.Windows.Forms.TrackBar();
            this.dzwiekTestButton = new System.Windows.Forms.Button();
            this.wygladStrony = new System.Windows.Forms.ComboBox();
            this.wygladtxt = new System.Windows.Forms.Label();
            this.GongName = new System.Windows.Forms.ComboBox();
            this.GongTxt = new System.Windows.Forms.Label();
            this.Pomoc1_5 = new System.Windows.Forms.Label();
            this.Pomoc1_4 = new System.Windows.Forms.Label();
            this.Pomoc1_3 = new System.Windows.Forms.Label();
            this.Pomoc1_2 = new System.Windows.Forms.Label();
            this.Pomoc1_1 = new System.Windows.Forms.Label();
            this.Pomoc1 = new System.Windows.Forms.Label();
            this.tabPageKomunikaty = new System.Windows.Forms.TabPage();
            this.buttonWypelnijZAPI = new System.Windows.Forms.Button();
            this.anulujSyntezator = new System.Windows.Forms.Button();
            this.wznowSyntezator = new System.Windows.Forms.Button();
            this.zatrzymajModulator = new System.Windows.Forms.Button();
            this.listaPociagowZapisanych = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.listaPociagowUsun = new System.Windows.Forms.Button();
            this.listaPociagowWczytaj = new System.Windows.Forms.Button();
            this.listaPociagowDodaj = new System.Windows.Forms.Button();
            this.numerPociąguBox = new System.Windows.Forms.NumericUpDown();
            this.isGongOn = new System.Windows.Forms.CheckBox();
            this.Koniec5 = new System.Windows.Forms.NumericUpDown();
            this.Koniec7 = new System.Windows.Forms.NumericUpDown();
            this.Koniec6 = new System.Windows.Forms.NumericUpDown();
            this.Koniec4 = new System.Windows.Forms.NumericUpDown();
            this.Koniec1 = new System.Windows.Forms.NumericUpDown();
            this.Koniec3 = new System.Windows.Forms.NumericUpDown();
            this.Koniec2 = new System.Windows.Forms.NumericUpDown();
            this.Środek1 = new System.Windows.Forms.NumericUpDown();
            this.Początek1 = new System.Windows.Forms.NumericUpDown();
            this.Środek3 = new System.Windows.Forms.NumericUpDown();
            this.Środek2 = new System.Windows.Forms.NumericUpDown();
            this.Środek5 = new System.Windows.Forms.NumericUpDown();
            this.Środek7 = new System.Windows.Forms.NumericUpDown();
            this.Środek6 = new System.Windows.Forms.NumericUpDown();
            this.Środek4 = new System.Windows.Forms.NumericUpDown();
            this.Początek5 = new System.Windows.Forms.NumericUpDown();
            this.Początek7 = new System.Windows.Forms.NumericUpDown();
            this.Początek6 = new System.Windows.Forms.NumericUpDown();
            this.Początek4 = new System.Windows.Forms.NumericUpDown();
            this.Początek3 = new System.Windows.Forms.NumericUpDown();
            this.Początek2 = new System.Windows.Forms.NumericUpDown();
            this.WagonyKoniecTXT = new System.Windows.Forms.Label();
            this.WagonyŚrodekTXT = new System.Windows.Forms.Label();
            this.ileWagonówWSkładzie = new System.Windows.Forms.NumericUpDown();
            this.ileWagonowTXT = new System.Windows.Forms.Label();
            this.WagonyPoczątekTXT = new System.Windows.Forms.Label();
            this.ifReserwation = new System.Windows.Forms.CheckBox();
            this.dźwiękButton = new System.Windows.Forms.Button();
            this.PrzyStOdjTXT = new System.Windows.Forms.Label();
            this.comboPrzyStOdj = new System.Windows.Forms.ComboBox();
            this.labelTor = new System.Windows.Forms.Label();
            this.labelPeron = new System.Windows.Forms.Label();
            this.przezTXT = new System.Windows.Forms.Label();
            this.przezBox = new System.Windows.Forms.TextBox();
            this.komunikatWygenerowanyBox = new System.Windows.Forms.RichTextBox();
            this.nazwaPociąguBox = new System.Windows.Forms.TextBox();
            this.boxPeron = new System.Windows.Forms.TextBox();
            this.boxTor = new System.Windows.Forms.TextBox();
            this.box_stacja_końcowa = new System.Windows.Forms.TextBox();
            this.box_stacja_początkowa = new System.Windows.Forms.TextBox();
            this.pociągMaOpóźnienie = new System.Windows.Forms.CheckBox();
            this.OpóźnienieTXT = new System.Windows.Forms.Label();
            this.opóźnienieBox = new System.Windows.Forms.NumericUpDown();
            this.nazwaPociąguTXT = new System.Windows.Forms.Label();
            this.generujBezZatrzymaniaButton = new System.Windows.Forms.Button();
            this.generujButton = new System.Windows.Forms.Button();
            this.wyczyscButton = new System.Windows.Forms.Button();
            this.GodzinaTXT = new System.Windows.Forms.Label();
            this.OdjazdGodzinaTXT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minutyOdjazdu = new System.Windows.Forms.NumericUpDown();
            this.godzinyOdjazdu = new System.Windows.Forms.NumericUpDown();
            this.PrzyjazdGodzinaTXT = new System.Windows.Forms.Label();
            this.oddzieleniePrzyjazd = new System.Windows.Forms.Label();
            this.minutyPrzyjazdu = new System.Windows.Forms.NumericUpDown();
            this.godzinaPrzyjazdu = new System.Windows.Forms.NumericUpDown();
            this.naszaStacjaWRJtxt = new System.Windows.Forms.Label();
            this.naszaStacjaWRJ = new System.Windows.Forms.ComboBox();
            this.kategoriaHandlowa = new System.Windows.Forms.Label();
            this.przewoźnik = new System.Windows.Forms.Label();
            this.comboKategoriaHandlowa = new System.Windows.Forms.ComboBox();
            this.comboPrzewoźnik = new System.Windows.Forms.ComboBox();
            this.stacjaKońcowa = new System.Windows.Forms.Label();
            this.stacjaPoczątkowa = new System.Windows.Forms.Label();
            this.NumerPociągu = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip1.SuspendLayout();
            this.tabPageOpcje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlosnoscGongu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlosnoscOgolna)).BeginInit();
            this.tabPageKomunikaty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerPociąguBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileWagonówWSkładzie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opóźnienieBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutyOdjazdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinyOdjazdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutyPrzyjazdu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinaPrzyjazdu)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wersja,
            this.podpis});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // wersja
            // 
            this.wersja.BackColor = System.Drawing.SystemColors.Info;
            this.wersja.Name = "wersja";
            resources.ApplyResources(this.wersja, "wersja");
            // 
            // podpis
            // 
            this.podpis.BackColor = System.Drawing.SystemColors.Info;
            this.podpis.Name = "podpis";
            resources.ApplyResources(this.podpis, "podpis");
            // 
            // tabPageOpcje
            // 
            this.tabPageOpcje.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageOpcje.Controls.Add(this.trackBarGlosnoscGongu);
            this.tabPageOpcje.Controls.Add(this.GlosnoscGonguTXT);
            this.tabPageOpcje.Controls.Add(this.GlosnoscSyntezatoraTXT);
            this.tabPageOpcje.Controls.Add(this.trackBarGlosnoscOgolna);
            this.tabPageOpcje.Controls.Add(this.dzwiekTestButton);
            this.tabPageOpcje.Controls.Add(this.wygladStrony);
            this.tabPageOpcje.Controls.Add(this.wygladtxt);
            this.tabPageOpcje.Controls.Add(this.GongName);
            this.tabPageOpcje.Controls.Add(this.GongTxt);
            this.tabPageOpcje.Controls.Add(this.Pomoc1_5);
            this.tabPageOpcje.Controls.Add(this.Pomoc1_4);
            this.tabPageOpcje.Controls.Add(this.Pomoc1_3);
            this.tabPageOpcje.Controls.Add(this.Pomoc1_2);
            this.tabPageOpcje.Controls.Add(this.Pomoc1_1);
            this.tabPageOpcje.Controls.Add(this.Pomoc1);
            resources.ApplyResources(this.tabPageOpcje, "tabPageOpcje");
            this.tabPageOpcje.Name = "tabPageOpcje";
            // 
            // trackBarGlosnoscGongu
            // 
            resources.ApplyResources(this.trackBarGlosnoscGongu, "trackBarGlosnoscGongu");
            this.trackBarGlosnoscGongu.LargeChange = 2;
            this.trackBarGlosnoscGongu.Maximum = 50;
            this.trackBarGlosnoscGongu.Name = "trackBarGlosnoscGongu";
            this.trackBarGlosnoscGongu.TickFrequency = 5;
            this.trackBarGlosnoscGongu.Value = 25;
            // 
            // GlosnoscGonguTXT
            // 
            resources.ApplyResources(this.GlosnoscGonguTXT, "GlosnoscGonguTXT");
            this.GlosnoscGonguTXT.Name = "GlosnoscGonguTXT";
            // 
            // GlosnoscSyntezatoraTXT
            // 
            resources.ApplyResources(this.GlosnoscSyntezatoraTXT, "GlosnoscSyntezatoraTXT");
            this.GlosnoscSyntezatoraTXT.Name = "GlosnoscSyntezatoraTXT";
            // 
            // trackBarGlosnoscOgolna
            // 
            resources.ApplyResources(this.trackBarGlosnoscOgolna, "trackBarGlosnoscOgolna");
            this.trackBarGlosnoscOgolna.Maximum = 100;
            this.trackBarGlosnoscOgolna.Name = "trackBarGlosnoscOgolna";
            this.trackBarGlosnoscOgolna.TickFrequency = 10;
            this.trackBarGlosnoscOgolna.Value = 80;
            // 
            // dzwiekTestButton
            // 
            this.dzwiekTestButton.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.dzwiekTestButton, "dzwiekTestButton");
            this.dzwiekTestButton.Name = "dzwiekTestButton";
            this.dzwiekTestButton.UseVisualStyleBackColor = false;
            this.dzwiekTestButton.Click += new System.EventHandler(this.dzwiekTestButton_Click);
            // 
            // wygladStrony
            // 
            this.wygladStrony.DisplayMember = "12";
            this.wygladStrony.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wygladStrony.FormattingEnabled = true;
            resources.ApplyResources(this.wygladStrony, "wygladStrony");
            this.wygladStrony.Items.AddRange(new object[] {
            resources.GetString("wygladStrony.Items"),
            resources.GetString("wygladStrony.Items1"),
            resources.GetString("wygladStrony.Items2"),
            resources.GetString("wygladStrony.Items3")});
            this.wygladStrony.Name = "wygladStrony";
            this.wygladStrony.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // wygladtxt
            // 
            resources.ApplyResources(this.wygladtxt, "wygladtxt");
            this.wygladtxt.ForeColor = System.Drawing.Color.Black;
            this.wygladtxt.Name = "wygladtxt";
            // 
            // GongName
            // 
            this.GongName.BackColor = System.Drawing.SystemColors.Window;
            this.GongName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GongName.FormattingEnabled = true;
            this.GongName.Items.AddRange(new object[] {
            resources.GetString("GongName.Items"),
            resources.GetString("GongName.Items1"),
            resources.GetString("GongName.Items2"),
            resources.GetString("GongName.Items3")});
            resources.ApplyResources(this.GongName, "GongName");
            this.GongName.Name = "GongName";
            // 
            // GongTxt
            // 
            resources.ApplyResources(this.GongTxt, "GongTxt");
            this.GongTxt.Name = "GongTxt";
            // 
            // Pomoc1_5
            // 
            resources.ApplyResources(this.Pomoc1_5, "Pomoc1_5");
            this.Pomoc1_5.Name = "Pomoc1_5";
            // 
            // Pomoc1_4
            // 
            resources.ApplyResources(this.Pomoc1_4, "Pomoc1_4");
            this.Pomoc1_4.Name = "Pomoc1_4";
            // 
            // Pomoc1_3
            // 
            resources.ApplyResources(this.Pomoc1_3, "Pomoc1_3");
            this.Pomoc1_3.Name = "Pomoc1_3";
            // 
            // Pomoc1_2
            // 
            resources.ApplyResources(this.Pomoc1_2, "Pomoc1_2");
            this.Pomoc1_2.Name = "Pomoc1_2";
            // 
            // Pomoc1_1
            // 
            resources.ApplyResources(this.Pomoc1_1, "Pomoc1_1");
            this.Pomoc1_1.Name = "Pomoc1_1";
            // 
            // Pomoc1
            // 
            resources.ApplyResources(this.Pomoc1, "Pomoc1");
            this.Pomoc1.Name = "Pomoc1";
            // 
            // tabPageKomunikaty
            // 
            this.tabPageKomunikaty.BackColor = System.Drawing.Color.RosyBrown;
            resources.ApplyResources(this.tabPageKomunikaty, "tabPageKomunikaty");
            this.tabPageKomunikaty.Controls.Add(this.buttonWypelnijZAPI);
            this.tabPageKomunikaty.Controls.Add(this.anulujSyntezator);
            this.tabPageKomunikaty.Controls.Add(this.wznowSyntezator);
            this.tabPageKomunikaty.Controls.Add(this.zatrzymajModulator);
            this.tabPageKomunikaty.Controls.Add(this.listaPociagowZapisanych);
            this.tabPageKomunikaty.Controls.Add(this.listaPociagowUsun);
            this.tabPageKomunikaty.Controls.Add(this.listaPociagowWczytaj);
            this.tabPageKomunikaty.Controls.Add(this.listaPociagowDodaj);
            this.tabPageKomunikaty.Controls.Add(this.numerPociąguBox);
            this.tabPageKomunikaty.Controls.Add(this.isGongOn);
            this.tabPageKomunikaty.Controls.Add(this.Koniec5);
            this.tabPageKomunikaty.Controls.Add(this.Koniec7);
            this.tabPageKomunikaty.Controls.Add(this.Koniec6);
            this.tabPageKomunikaty.Controls.Add(this.Koniec4);
            this.tabPageKomunikaty.Controls.Add(this.Koniec1);
            this.tabPageKomunikaty.Controls.Add(this.Koniec3);
            this.tabPageKomunikaty.Controls.Add(this.Koniec2);
            this.tabPageKomunikaty.Controls.Add(this.Środek1);
            this.tabPageKomunikaty.Controls.Add(this.Początek1);
            this.tabPageKomunikaty.Controls.Add(this.Środek3);
            this.tabPageKomunikaty.Controls.Add(this.Środek2);
            this.tabPageKomunikaty.Controls.Add(this.Środek5);
            this.tabPageKomunikaty.Controls.Add(this.Środek7);
            this.tabPageKomunikaty.Controls.Add(this.Środek6);
            this.tabPageKomunikaty.Controls.Add(this.Środek4);
            this.tabPageKomunikaty.Controls.Add(this.Początek5);
            this.tabPageKomunikaty.Controls.Add(this.Początek7);
            this.tabPageKomunikaty.Controls.Add(this.Początek6);
            this.tabPageKomunikaty.Controls.Add(this.Początek4);
            this.tabPageKomunikaty.Controls.Add(this.Początek3);
            this.tabPageKomunikaty.Controls.Add(this.Początek2);
            this.tabPageKomunikaty.Controls.Add(this.WagonyKoniecTXT);
            this.tabPageKomunikaty.Controls.Add(this.WagonyŚrodekTXT);
            this.tabPageKomunikaty.Controls.Add(this.ileWagonówWSkładzie);
            this.tabPageKomunikaty.Controls.Add(this.ileWagonowTXT);
            this.tabPageKomunikaty.Controls.Add(this.WagonyPoczątekTXT);
            this.tabPageKomunikaty.Controls.Add(this.ifReserwation);
            this.tabPageKomunikaty.Controls.Add(this.dźwiękButton);
            this.tabPageKomunikaty.Controls.Add(this.PrzyStOdjTXT);
            this.tabPageKomunikaty.Controls.Add(this.comboPrzyStOdj);
            this.tabPageKomunikaty.Controls.Add(this.labelTor);
            this.tabPageKomunikaty.Controls.Add(this.labelPeron);
            this.tabPageKomunikaty.Controls.Add(this.przezTXT);
            this.tabPageKomunikaty.Controls.Add(this.przezBox);
            this.tabPageKomunikaty.Controls.Add(this.komunikatWygenerowanyBox);
            this.tabPageKomunikaty.Controls.Add(this.nazwaPociąguBox);
            this.tabPageKomunikaty.Controls.Add(this.boxPeron);
            this.tabPageKomunikaty.Controls.Add(this.boxTor);
            this.tabPageKomunikaty.Controls.Add(this.box_stacja_końcowa);
            this.tabPageKomunikaty.Controls.Add(this.box_stacja_początkowa);
            this.tabPageKomunikaty.Controls.Add(this.pociągMaOpóźnienie);
            this.tabPageKomunikaty.Controls.Add(this.OpóźnienieTXT);
            this.tabPageKomunikaty.Controls.Add(this.opóźnienieBox);
            this.tabPageKomunikaty.Controls.Add(this.nazwaPociąguTXT);
            this.tabPageKomunikaty.Controls.Add(this.generujBezZatrzymaniaButton);
            this.tabPageKomunikaty.Controls.Add(this.generujButton);
            this.tabPageKomunikaty.Controls.Add(this.wyczyscButton);
            this.tabPageKomunikaty.Controls.Add(this.GodzinaTXT);
            this.tabPageKomunikaty.Controls.Add(this.OdjazdGodzinaTXT);
            this.tabPageKomunikaty.Controls.Add(this.label2);
            this.tabPageKomunikaty.Controls.Add(this.minutyOdjazdu);
            this.tabPageKomunikaty.Controls.Add(this.godzinyOdjazdu);
            this.tabPageKomunikaty.Controls.Add(this.PrzyjazdGodzinaTXT);
            this.tabPageKomunikaty.Controls.Add(this.oddzieleniePrzyjazd);
            this.tabPageKomunikaty.Controls.Add(this.minutyPrzyjazdu);
            this.tabPageKomunikaty.Controls.Add(this.godzinaPrzyjazdu);
            this.tabPageKomunikaty.Controls.Add(this.naszaStacjaWRJtxt);
            this.tabPageKomunikaty.Controls.Add(this.naszaStacjaWRJ);
            this.tabPageKomunikaty.Controls.Add(this.kategoriaHandlowa);
            this.tabPageKomunikaty.Controls.Add(this.przewoźnik);
            this.tabPageKomunikaty.Controls.Add(this.comboKategoriaHandlowa);
            this.tabPageKomunikaty.Controls.Add(this.comboPrzewoźnik);
            this.tabPageKomunikaty.Controls.Add(this.stacjaKońcowa);
            this.tabPageKomunikaty.Controls.Add(this.stacjaPoczątkowa);
            this.tabPageKomunikaty.Controls.Add(this.NumerPociągu);
            this.tabPageKomunikaty.Name = "tabPageKomunikaty";
            // 
            // buttonWypelnijZAPI
            // 
            resources.ApplyResources(this.buttonWypelnijZAPI, "buttonWypelnijZAPI");
            this.buttonWypelnijZAPI.Name = "buttonWypelnijZAPI";
            this.buttonWypelnijZAPI.TabStop = false;
            this.buttonWypelnijZAPI.UseVisualStyleBackColor = true;
            this.buttonWypelnijZAPI.Click += new System.EventHandler(this.buttonWypelnijZAPI_Click);
            // 
            // anulujSyntezator
            // 
            resources.ApplyResources(this.anulujSyntezator, "anulujSyntezator");
            this.anulujSyntezator.Name = "anulujSyntezator";
            this.anulujSyntezator.UseVisualStyleBackColor = true;
            this.anulujSyntezator.Click += new System.EventHandler(this.anulujSyntezator_Click);
            // 
            // wznowSyntezator
            // 
            resources.ApplyResources(this.wznowSyntezator, "wznowSyntezator");
            this.wznowSyntezator.Name = "wznowSyntezator";
            this.wznowSyntezator.UseVisualStyleBackColor = true;
            this.wznowSyntezator.Click += new System.EventHandler(this.wznowSyntezator_Click);
            // 
            // zatrzymajModulator
            // 
            resources.ApplyResources(this.zatrzymajModulator, "zatrzymajModulator");
            this.zatrzymajModulator.Name = "zatrzymajModulator";
            this.zatrzymajModulator.UseVisualStyleBackColor = true;
            this.zatrzymajModulator.Click += new System.EventHandler(this.zatrzymajModulator_Click);
            // 
            // listaPociagowZapisanych
            // 
            this.listaPociagowZapisanych.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            resources.ApplyResources(this.listaPociagowZapisanych, "listaPociagowZapisanych");
            this.listaPociagowZapisanych.Name = "listaPociagowZapisanych";
            this.listaPociagowZapisanych.UseCompatibleStateImageBehavior = false;
            this.listaPociagowZapisanych.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // listaPociagowUsun
            // 
            resources.ApplyResources(this.listaPociagowUsun, "listaPociagowUsun");
            this.listaPociagowUsun.Name = "listaPociagowUsun";
            this.listaPociagowUsun.UseVisualStyleBackColor = true;
            this.listaPociagowUsun.Click += new System.EventHandler(this.listaPociagowUsun_Click);
            // 
            // listaPociagowWczytaj
            // 
            resources.ApplyResources(this.listaPociagowWczytaj, "listaPociagowWczytaj");
            this.listaPociagowWczytaj.Name = "listaPociagowWczytaj";
            this.listaPociagowWczytaj.UseVisualStyleBackColor = true;
            this.listaPociagowWczytaj.Click += new System.EventHandler(this.listaPociagowWczytaj_Click);
            // 
            // listaPociagowDodaj
            // 
            resources.ApplyResources(this.listaPociagowDodaj, "listaPociagowDodaj");
            this.listaPociagowDodaj.Name = "listaPociagowDodaj";
            this.listaPociagowDodaj.UseVisualStyleBackColor = true;
            this.listaPociagowDodaj.Click += new System.EventHandler(this.listaPociagowDodaj_Click);
            // 
            // numerPociąguBox
            // 
            this.numerPociąguBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.numerPociąguBox, "numerPociąguBox");
            this.numerPociąguBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numerPociąguBox.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numerPociąguBox.Name = "numerPociąguBox";
            this.numerPociąguBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // isGongOn
            // 
            resources.ApplyResources(this.isGongOn, "isGongOn");
            this.isGongOn.Name = "isGongOn";
            this.isGongOn.UseVisualStyleBackColor = true;
            // 
            // Koniec5
            // 
            resources.ApplyResources(this.Koniec5, "Koniec5");
            this.Koniec5.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec5.Name = "Koniec5";
            this.Koniec5.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // Koniec7
            // 
            resources.ApplyResources(this.Koniec7, "Koniec7");
            this.Koniec7.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec7.Name = "Koniec7";
            this.Koniec7.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // Koniec6
            // 
            resources.ApplyResources(this.Koniec6, "Koniec6");
            this.Koniec6.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec6.Name = "Koniec6";
            this.Koniec6.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Koniec4
            // 
            resources.ApplyResources(this.Koniec4, "Koniec4");
            this.Koniec4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec4.Name = "Koniec4";
            this.Koniec4.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Koniec1
            // 
            resources.ApplyResources(this.Koniec1, "Koniec1");
            this.Koniec1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec1.Name = "Koniec1";
            this.Koniec1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Koniec3
            // 
            resources.ApplyResources(this.Koniec3, "Koniec3");
            this.Koniec3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec3.Name = "Koniec3";
            this.Koniec3.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // Koniec2
            // 
            resources.ApplyResources(this.Koniec2, "Koniec2");
            this.Koniec2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Koniec2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Koniec2.Name = "Koniec2";
            this.Koniec2.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // Środek1
            // 
            resources.ApplyResources(this.Środek1, "Środek1");
            this.Środek1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek1.Name = "Środek1";
            this.Środek1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Początek1
            // 
            resources.ApplyResources(this.Początek1, "Początek1");
            this.Początek1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek1.Name = "Początek1";
            this.Początek1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Środek3
            // 
            resources.ApplyResources(this.Środek3, "Środek3");
            this.Środek3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek3.Name = "Środek3";
            this.Środek3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Środek2
            // 
            resources.ApplyResources(this.Środek2, "Środek2");
            this.Środek2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek2.Name = "Środek2";
            this.Środek2.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // Środek5
            // 
            resources.ApplyResources(this.Środek5, "Środek5");
            this.Środek5.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek5.Name = "Środek5";
            this.Środek5.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // Środek7
            // 
            resources.ApplyResources(this.Środek7, "Środek7");
            this.Środek7.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek7.Name = "Środek7";
            this.Środek7.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // Środek6
            // 
            resources.ApplyResources(this.Środek6, "Środek6");
            this.Środek6.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek6.Name = "Środek6";
            this.Środek6.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // Środek4
            // 
            resources.ApplyResources(this.Środek4, "Środek4");
            this.Środek4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Środek4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Środek4.Name = "Środek4";
            this.Środek4.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // Początek5
            // 
            resources.ApplyResources(this.Początek5, "Początek5");
            this.Początek5.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek5.Name = "Początek5";
            this.Początek5.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Początek7
            // 
            resources.ApplyResources(this.Początek7, "Początek7");
            this.Początek7.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek7.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek7.Name = "Początek7";
            this.Początek7.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Początek6
            // 
            resources.ApplyResources(this.Początek6, "Początek6");
            this.Początek6.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek6.Name = "Początek6";
            this.Początek6.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // Początek4
            // 
            resources.ApplyResources(this.Początek4, "Początek4");
            this.Początek4.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek4.Name = "Początek4";
            this.Początek4.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Początek3
            // 
            resources.ApplyResources(this.Początek3, "Początek3");
            this.Początek3.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek3.Name = "Początek3";
            this.Początek3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Początek2
            // 
            resources.ApplyResources(this.Początek2, "Początek2");
            this.Początek2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Początek2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Początek2.Name = "Początek2";
            this.Początek2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // WagonyKoniecTXT
            // 
            resources.ApplyResources(this.WagonyKoniecTXT, "WagonyKoniecTXT");
            this.WagonyKoniecTXT.Name = "WagonyKoniecTXT";
            // 
            // WagonyŚrodekTXT
            // 
            resources.ApplyResources(this.WagonyŚrodekTXT, "WagonyŚrodekTXT");
            this.WagonyŚrodekTXT.Name = "WagonyŚrodekTXT";
            // 
            // ileWagonówWSkładzie
            // 
            resources.ApplyResources(this.ileWagonówWSkładzie, "ileWagonówWSkładzie");
            this.ileWagonówWSkładzie.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.ileWagonówWSkładzie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileWagonówWSkładzie.Name = "ileWagonówWSkładzie";
            this.ileWagonówWSkładzie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ileWagonówWSkładzie.ValueChanged += new System.EventHandler(this.ileWagonówWSkładzie_ValueChanged);
            // 
            // ileWagonowTXT
            // 
            resources.ApplyResources(this.ileWagonowTXT, "ileWagonowTXT");
            this.ileWagonowTXT.Name = "ileWagonowTXT";
            // 
            // WagonyPoczątekTXT
            // 
            resources.ApplyResources(this.WagonyPoczątekTXT, "WagonyPoczątekTXT");
            this.WagonyPoczątekTXT.Name = "WagonyPoczątekTXT";
            // 
            // ifReserwation
            // 
            resources.ApplyResources(this.ifReserwation, "ifReserwation");
            this.ifReserwation.Name = "ifReserwation";
            this.ifReserwation.UseVisualStyleBackColor = true;
            this.ifReserwation.CheckedChanged += new System.EventHandler(this.ifReserwation_CheckedChanged);
            // 
            // dźwiękButton
            // 
            this.dźwiękButton.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.dźwiękButton, "dźwiękButton");
            this.dźwiękButton.Name = "dźwiękButton";
            this.dźwiękButton.UseVisualStyleBackColor = false;
            this.dźwiękButton.Click += new System.EventHandler(this.dźwiękButton_Click);
            // 
            // PrzyStOdjTXT
            // 
            resources.ApplyResources(this.PrzyStOdjTXT, "PrzyStOdjTXT");
            this.PrzyStOdjTXT.Name = "PrzyStOdjTXT";
            // 
            // comboPrzyStOdj
            // 
            this.comboPrzyStOdj.BackColor = System.Drawing.SystemColors.Window;
            this.comboPrzyStOdj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrzyStOdj.FormattingEnabled = true;
            this.comboPrzyStOdj.Items.AddRange(new object[] {
            resources.GetString("comboPrzyStOdj.Items"),
            resources.GetString("comboPrzyStOdj.Items1"),
            resources.GetString("comboPrzyStOdj.Items2")});
            resources.ApplyResources(this.comboPrzyStOdj, "comboPrzyStOdj");
            this.comboPrzyStOdj.Name = "comboPrzyStOdj";
            // 
            // labelTor
            // 
            resources.ApplyResources(this.labelTor, "labelTor");
            this.labelTor.Name = "labelTor";
            // 
            // labelPeron
            // 
            resources.ApplyResources(this.labelPeron, "labelPeron");
            this.labelPeron.Name = "labelPeron";
            // 
            // przezTXT
            // 
            resources.ApplyResources(this.przezTXT, "przezTXT");
            this.przezTXT.Name = "przezTXT";
            // 
            // przezBox
            // 
            this.przezBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("przezBox.AutoCompleteCustomSource"),
            resources.GetString("przezBox.AutoCompleteCustomSource1"),
            resources.GetString("przezBox.AutoCompleteCustomSource2"),
            resources.GetString("przezBox.AutoCompleteCustomSource3"),
            resources.GetString("przezBox.AutoCompleteCustomSource4"),
            resources.GetString("przezBox.AutoCompleteCustomSource5"),
            resources.GetString("przezBox.AutoCompleteCustomSource6"),
            resources.GetString("przezBox.AutoCompleteCustomSource7"),
            resources.GetString("przezBox.AutoCompleteCustomSource8"),
            resources.GetString("przezBox.AutoCompleteCustomSource9"),
            resources.GetString("przezBox.AutoCompleteCustomSource10"),
            resources.GetString("przezBox.AutoCompleteCustomSource11"),
            resources.GetString("przezBox.AutoCompleteCustomSource12"),
            resources.GetString("przezBox.AutoCompleteCustomSource13"),
            resources.GetString("przezBox.AutoCompleteCustomSource14"),
            resources.GetString("przezBox.AutoCompleteCustomSource15"),
            resources.GetString("przezBox.AutoCompleteCustomSource16"),
            resources.GetString("przezBox.AutoCompleteCustomSource17"),
            resources.GetString("przezBox.AutoCompleteCustomSource18"),
            resources.GetString("przezBox.AutoCompleteCustomSource19"),
            resources.GetString("przezBox.AutoCompleteCustomSource20"),
            resources.GetString("przezBox.AutoCompleteCustomSource21"),
            resources.GetString("przezBox.AutoCompleteCustomSource22"),
            resources.GetString("przezBox.AutoCompleteCustomSource23"),
            resources.GetString("przezBox.AutoCompleteCustomSource24"),
            resources.GetString("przezBox.AutoCompleteCustomSource25"),
            resources.GetString("przezBox.AutoCompleteCustomSource26"),
            resources.GetString("przezBox.AutoCompleteCustomSource27"),
            resources.GetString("przezBox.AutoCompleteCustomSource28"),
            resources.GetString("przezBox.AutoCompleteCustomSource29"),
            resources.GetString("przezBox.AutoCompleteCustomSource30"),
            resources.GetString("przezBox.AutoCompleteCustomSource31"),
            resources.GetString("przezBox.AutoCompleteCustomSource32"),
            resources.GetString("przezBox.AutoCompleteCustomSource33"),
            resources.GetString("przezBox.AutoCompleteCustomSource34")});
            this.przezBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.przezBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.przezBox, "przezBox");
            this.przezBox.Name = "przezBox";
            this.przezBox.Tag = "";
            // 
            // komunikatWygenerowanyBox
            // 
            this.komunikatWygenerowanyBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.komunikatWygenerowanyBox, "komunikatWygenerowanyBox");
            this.komunikatWygenerowanyBox.Name = "komunikatWygenerowanyBox";
            this.komunikatWygenerowanyBox.ReadOnly = true;
            // 
            // nazwaPociąguBox
            // 
            resources.ApplyResources(this.nazwaPociąguBox, "nazwaPociąguBox");
            this.nazwaPociąguBox.Name = "nazwaPociąguBox";
            // 
            // boxPeron
            // 
            this.boxPeron.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("boxPeron.AutoCompleteCustomSource"),
            resources.GetString("boxPeron.AutoCompleteCustomSource1"),
            resources.GetString("boxPeron.AutoCompleteCustomSource2"),
            resources.GetString("boxPeron.AutoCompleteCustomSource3"),
            resources.GetString("boxPeron.AutoCompleteCustomSource4"),
            resources.GetString("boxPeron.AutoCompleteCustomSource5"),
            resources.GetString("boxPeron.AutoCompleteCustomSource6"),
            resources.GetString("boxPeron.AutoCompleteCustomSource7"),
            resources.GetString("boxPeron.AutoCompleteCustomSource8"),
            resources.GetString("boxPeron.AutoCompleteCustomSource9"),
            resources.GetString("boxPeron.AutoCompleteCustomSource10")});
            resources.ApplyResources(this.boxPeron, "boxPeron");
            this.boxPeron.Name = "boxPeron";
            // 
            // boxTor
            // 
            this.boxTor.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("boxTor.AutoCompleteCustomSource"),
            resources.GetString("boxTor.AutoCompleteCustomSource1"),
            resources.GetString("boxTor.AutoCompleteCustomSource2"),
            resources.GetString("boxTor.AutoCompleteCustomSource3"),
            resources.GetString("boxTor.AutoCompleteCustomSource4"),
            resources.GetString("boxTor.AutoCompleteCustomSource5"),
            resources.GetString("boxTor.AutoCompleteCustomSource6"),
            resources.GetString("boxTor.AutoCompleteCustomSource7"),
            resources.GetString("boxTor.AutoCompleteCustomSource8"),
            resources.GetString("boxTor.AutoCompleteCustomSource9"),
            resources.GetString("boxTor.AutoCompleteCustomSource10"),
            resources.GetString("boxTor.AutoCompleteCustomSource11")});
            resources.ApplyResources(this.boxTor, "boxTor");
            this.boxTor.Name = "boxTor";
            // 
            // box_stacja_końcowa
            // 
            this.box_stacja_końcowa.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource1"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource2"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource3"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource4"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource5"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource6"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource7"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource8"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource9"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource10"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource11"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource12"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource13"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource14"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource15"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource16"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource17"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource18"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource19"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource20"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource21"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource22"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource23"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource24"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource25"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource26"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource27"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource28"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource29"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource30"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource31"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource32"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource33"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource34"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource35"),
            resources.GetString("box_stacja_końcowa.AutoCompleteCustomSource36")});
            this.box_stacja_końcowa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_stacja_końcowa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.box_stacja_końcowa.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.box_stacja_końcowa, "box_stacja_końcowa");
            this.box_stacja_końcowa.Name = "box_stacja_końcowa";
            // 
            // box_stacja_początkowa
            // 
            this.box_stacja_początkowa.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource1"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource2"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource3"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource4"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource5"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource6"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource7"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource8"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource9"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource10"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource11"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource12"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource13"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource14"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource15"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource16"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource17"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource18"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource19"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource20"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource21"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource22"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource23"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource24"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource25"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource26"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource27"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource28"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource29"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource30"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource31"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource32"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource33"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource34"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource35"),
            resources.GetString("box_stacja_początkowa.AutoCompleteCustomSource36")});
            this.box_stacja_początkowa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.box_stacja_początkowa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.box_stacja_początkowa, "box_stacja_początkowa");
            this.box_stacja_początkowa.Name = "box_stacja_początkowa";
            // 
            // pociągMaOpóźnienie
            // 
            resources.ApplyResources(this.pociągMaOpóźnienie, "pociągMaOpóźnienie");
            this.pociągMaOpóźnienie.Name = "pociągMaOpóźnienie";
            this.pociągMaOpóźnienie.UseVisualStyleBackColor = true;
            this.pociągMaOpóźnienie.CheckedChanged += new System.EventHandler(this.pociągMaOpóźnienie_CheckedChanged);
            // 
            // OpóźnienieTXT
            // 
            resources.ApplyResources(this.OpóźnienieTXT, "OpóźnienieTXT");
            this.OpóźnienieTXT.Name = "OpóźnienieTXT";
            // 
            // opóźnienieBox
            // 
            resources.ApplyResources(this.opóźnienieBox, "opóźnienieBox");
            this.opóźnienieBox.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.opóźnienieBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.opóźnienieBox.Name = "opóźnienieBox";
            this.opóźnienieBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nazwaPociąguTXT
            // 
            resources.ApplyResources(this.nazwaPociąguTXT, "nazwaPociąguTXT");
            this.nazwaPociąguTXT.Name = "nazwaPociąguTXT";
            // 
            // generujBezZatrzymaniaButton
            // 
            this.generujBezZatrzymaniaButton.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.generujBezZatrzymaniaButton, "generujBezZatrzymaniaButton");
            this.generujBezZatrzymaniaButton.Name = "generujBezZatrzymaniaButton";
            this.generujBezZatrzymaniaButton.UseVisualStyleBackColor = false;
            this.generujBezZatrzymaniaButton.Click += new System.EventHandler(this.generujBezZatrzymaniaButton_Click);
            // 
            // generujButton
            // 
            this.generujButton.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.generujButton, "generujButton");
            this.generujButton.Name = "generujButton";
            this.generujButton.UseVisualStyleBackColor = false;
            this.generujButton.Click += new System.EventHandler(this.generujButton_Click);
            // 
            // wyczyscButton
            // 
            this.wyczyscButton.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.wyczyscButton, "wyczyscButton");
            this.wyczyscButton.Name = "wyczyscButton";
            this.wyczyscButton.UseVisualStyleBackColor = false;
            this.wyczyscButton.Click += new System.EventHandler(this.wyczyscButton_Click);
            // 
            // GodzinaTXT
            // 
            resources.ApplyResources(this.GodzinaTXT, "GodzinaTXT");
            this.GodzinaTXT.Name = "GodzinaTXT";
            // 
            // OdjazdGodzinaTXT
            // 
            resources.ApplyResources(this.OdjazdGodzinaTXT, "OdjazdGodzinaTXT");
            this.OdjazdGodzinaTXT.Name = "OdjazdGodzinaTXT";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // minutyOdjazdu
            // 
            resources.ApplyResources(this.minutyOdjazdu, "minutyOdjazdu");
            this.minutyOdjazdu.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutyOdjazdu.Name = "minutyOdjazdu";
            // 
            // godzinyOdjazdu
            // 
            resources.ApplyResources(this.godzinyOdjazdu, "godzinyOdjazdu");
            this.godzinyOdjazdu.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.godzinyOdjazdu.Name = "godzinyOdjazdu";
            // 
            // PrzyjazdGodzinaTXT
            // 
            resources.ApplyResources(this.PrzyjazdGodzinaTXT, "PrzyjazdGodzinaTXT");
            this.PrzyjazdGodzinaTXT.Name = "PrzyjazdGodzinaTXT";
            // 
            // oddzieleniePrzyjazd
            // 
            resources.ApplyResources(this.oddzieleniePrzyjazd, "oddzieleniePrzyjazd");
            this.oddzieleniePrzyjazd.Name = "oddzieleniePrzyjazd";
            // 
            // minutyPrzyjazdu
            // 
            resources.ApplyResources(this.minutyPrzyjazdu, "minutyPrzyjazdu");
            this.minutyPrzyjazdu.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutyPrzyjazdu.Name = "minutyPrzyjazdu";
            // 
            // godzinaPrzyjazdu
            // 
            resources.ApplyResources(this.godzinaPrzyjazdu, "godzinaPrzyjazdu");
            this.godzinaPrzyjazdu.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.godzinaPrzyjazdu.Name = "godzinaPrzyjazdu";
            // 
            // naszaStacjaWRJtxt
            // 
            resources.ApplyResources(this.naszaStacjaWRJtxt, "naszaStacjaWRJtxt");
            this.naszaStacjaWRJtxt.ForeColor = System.Drawing.Color.Black;
            this.naszaStacjaWRJtxt.Name = "naszaStacjaWRJtxt";
            // 
            // naszaStacjaWRJ
            // 
            this.naszaStacjaWRJ.BackColor = System.Drawing.SystemColors.Window;
            this.naszaStacjaWRJ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.naszaStacjaWRJ.FormattingEnabled = true;
            this.naszaStacjaWRJ.Items.AddRange(new object[] {
            resources.GetString("naszaStacjaWRJ.Items"),
            resources.GetString("naszaStacjaWRJ.Items1"),
            resources.GetString("naszaStacjaWRJ.Items2")});
            resources.ApplyResources(this.naszaStacjaWRJ, "naszaStacjaWRJ");
            this.naszaStacjaWRJ.Name = "naszaStacjaWRJ";
            // 
            // kategoriaHandlowa
            // 
            resources.ApplyResources(this.kategoriaHandlowa, "kategoriaHandlowa");
            this.kategoriaHandlowa.Name = "kategoriaHandlowa";
            // 
            // przewoźnik
            // 
            resources.ApplyResources(this.przewoźnik, "przewoźnik");
            this.przewoźnik.Name = "przewoźnik";
            // 
            // comboKategoriaHandlowa
            // 
            this.comboKategoriaHandlowa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKategoriaHandlowa.FormattingEnabled = true;
            resources.ApplyResources(this.comboKategoriaHandlowa, "comboKategoriaHandlowa");
            this.comboKategoriaHandlowa.Items.AddRange(new object[] {
            resources.GetString("comboKategoriaHandlowa.Items"),
            resources.GetString("comboKategoriaHandlowa.Items1"),
            resources.GetString("comboKategoriaHandlowa.Items2"),
            resources.GetString("comboKategoriaHandlowa.Items3"),
            resources.GetString("comboKategoriaHandlowa.Items4"),
            resources.GetString("comboKategoriaHandlowa.Items5"),
            resources.GetString("comboKategoriaHandlowa.Items6")});
            this.comboKategoriaHandlowa.Name = "comboKategoriaHandlowa";
            // 
            // comboPrzewoźnik
            // 
            this.comboPrzewoźnik.BackColor = System.Drawing.SystemColors.Window;
            this.comboPrzewoźnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPrzewoźnik.FormattingEnabled = true;
            this.comboPrzewoźnik.Items.AddRange(new object[] {
            resources.GetString("comboPrzewoźnik.Items"),
            resources.GetString("comboPrzewoźnik.Items1"),
            resources.GetString("comboPrzewoźnik.Items2"),
            resources.GetString("comboPrzewoźnik.Items3"),
            resources.GetString("comboPrzewoźnik.Items4"),
            resources.GetString("comboPrzewoźnik.Items5"),
            resources.GetString("comboPrzewoźnik.Items6"),
            resources.GetString("comboPrzewoźnik.Items7"),
            resources.GetString("comboPrzewoźnik.Items8")});
            resources.ApplyResources(this.comboPrzewoźnik, "comboPrzewoźnik");
            this.comboPrzewoźnik.Name = "comboPrzewoźnik";
            // 
            // stacjaKońcowa
            // 
            resources.ApplyResources(this.stacjaKońcowa, "stacjaKońcowa");
            this.stacjaKońcowa.Name = "stacjaKońcowa";
            // 
            // stacjaPoczątkowa
            // 
            resources.ApplyResources(this.stacjaPoczątkowa, "stacjaPoczątkowa");
            this.stacjaPoczątkowa.Name = "stacjaPoczątkowa";
            // 
            // NumerPociągu
            // 
            resources.ApplyResources(this.NumerPociągu, "NumerPociągu");
            this.NumerPociągu.ForeColor = System.Drawing.Color.Black;
            this.NumerPociągu.Name = "NumerPociągu";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageKomunikaty);
            this.tabControl.Controls.Add(this.tabPageOpcje);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // komunikaty
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "komunikaty";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZamkniecieOkna);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPageOpcje.ResumeLayout(false);
            this.tabPageOpcje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlosnoscGongu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGlosnoscOgolna)).EndInit();
            this.tabPageKomunikaty.ResumeLayout(false);
            this.tabPageKomunikaty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerPociąguBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koniec2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Środek4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Początek2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ileWagonówWSkładzie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opóźnienieBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutyOdjazdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinyOdjazdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutyPrzyjazdu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.godzinaPrzyjazdu)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel podpis;
        public System.Windows.Forms.TabPage tabPageOpcje;
        public System.Windows.Forms.Button dzwiekTestButton;
        public System.Windows.Forms.ComboBox wygladStrony;
        public System.Windows.Forms.Label wygladtxt;
        private System.Windows.Forms.ComboBox GongName;
        public System.Windows.Forms.Label GongTxt;
        public System.Windows.Forms.Label Pomoc1_5;
        public System.Windows.Forms.Label Pomoc1_4;
        public System.Windows.Forms.Label Pomoc1_3;
        public System.Windows.Forms.Label Pomoc1_2;
        public System.Windows.Forms.Label Pomoc1_1;
        public System.Windows.Forms.Label Pomoc1;
        public System.Windows.Forms.TabPage tabPageKomunikaty;
        public System.Windows.Forms.NumericUpDown Koniec5;
        public System.Windows.Forms.NumericUpDown Koniec7;
        public System.Windows.Forms.NumericUpDown Koniec6;
        public System.Windows.Forms.NumericUpDown Koniec4;
        public System.Windows.Forms.NumericUpDown Koniec1;
        public System.Windows.Forms.NumericUpDown Koniec3;
        public System.Windows.Forms.NumericUpDown Koniec2;
        public System.Windows.Forms.NumericUpDown Środek1;
        public System.Windows.Forms.NumericUpDown Początek1;
        public System.Windows.Forms.NumericUpDown Środek3;
        public System.Windows.Forms.NumericUpDown Środek2;
        public System.Windows.Forms.NumericUpDown Środek5;
        public System.Windows.Forms.NumericUpDown Środek7;
        public System.Windows.Forms.NumericUpDown Środek6;
        public System.Windows.Forms.NumericUpDown Środek4;
        public System.Windows.Forms.NumericUpDown Początek5;
        public System.Windows.Forms.NumericUpDown Początek7;
        public System.Windows.Forms.NumericUpDown Początek6;
        public System.Windows.Forms.NumericUpDown Początek4;
        public System.Windows.Forms.NumericUpDown Początek3;
        public System.Windows.Forms.NumericUpDown Początek2;
        public System.Windows.Forms.Label WagonyKoniecTXT;
        public System.Windows.Forms.Label WagonyŚrodekTXT;
        public System.Windows.Forms.NumericUpDown ileWagonówWSkładzie;
        public System.Windows.Forms.Label ileWagonowTXT;
        public System.Windows.Forms.Label WagonyPoczątekTXT;
        public System.Windows.Forms.CheckBox ifReserwation;
        public System.Windows.Forms.Button dźwiękButton;
        public System.Windows.Forms.Label PrzyStOdjTXT;
        private System.Windows.Forms.ComboBox comboPrzyStOdj;
        public System.Windows.Forms.Label labelTor;
        public System.Windows.Forms.Label labelPeron;
        public System.Windows.Forms.Label przezTXT;
        public System.Windows.Forms.TextBox przezBox;
        public System.Windows.Forms.RichTextBox komunikatWygenerowanyBox;
        public System.Windows.Forms.TextBox nazwaPociąguBox;
        public System.Windows.Forms.TextBox boxPeron;
        public System.Windows.Forms.TextBox boxTor;
        public System.Windows.Forms.TextBox box_stacja_końcowa;
        public System.Windows.Forms.TextBox box_stacja_początkowa;
        public System.Windows.Forms.CheckBox pociągMaOpóźnienie;
        public System.Windows.Forms.Label OpóźnienieTXT;
        public System.Windows.Forms.NumericUpDown opóźnienieBox;
        public System.Windows.Forms.Label nazwaPociąguTXT;
        public System.Windows.Forms.Button generujBezZatrzymaniaButton;
        public System.Windows.Forms.Button generujButton;
        public System.Windows.Forms.Button wyczyscButton;
        public System.Windows.Forms.Label GodzinaTXT;
        public System.Windows.Forms.Label OdjazdGodzinaTXT;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown minutyOdjazdu;
        public System.Windows.Forms.NumericUpDown godzinyOdjazdu;
        public System.Windows.Forms.Label PrzyjazdGodzinaTXT;
        private System.Windows.Forms.Label oddzieleniePrzyjazd;
        public System.Windows.Forms.NumericUpDown minutyPrzyjazdu;
        public System.Windows.Forms.NumericUpDown godzinaPrzyjazdu;
        public System.Windows.Forms.NumericUpDown numerPociąguBox;
        public System.Windows.Forms.Label naszaStacjaWRJtxt;
        private System.Windows.Forms.ComboBox naszaStacjaWRJ;
        public System.Windows.Forms.Label kategoriaHandlowa;
        public System.Windows.Forms.Label przewoźnik;
        private System.Windows.Forms.ComboBox comboKategoriaHandlowa;
        private System.Windows.Forms.ComboBox comboPrzewoźnik;
        public System.Windows.Forms.Label stacjaKońcowa;
        public System.Windows.Forms.Label stacjaPoczątkowa;
        public System.Windows.Forms.Label NumerPociągu;
        private System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.CheckBox isGongOn;
        private System.Windows.Forms.Button listaPociagowUsun;
        private System.Windows.Forms.Button listaPociagowWczytaj;
        private System.Windows.Forms.Button listaPociagowDodaj;
        private System.Windows.Forms.ListView listaPociagowZapisanych;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.Label GlosnoscSyntezatoraTXT;
        public System.Windows.Forms.TrackBar trackBarGlosnoscOgolna;
        public System.Windows.Forms.Button anulujSyntezator;
        public System.Windows.Forms.Button wznowSyntezator;
        public System.Windows.Forms.Button zatrzymajModulator;
        public System.Windows.Forms.TrackBar trackBarGlosnoscGongu;
        public System.Windows.Forms.Label GlosnoscGonguTXT;
        private System.Windows.Forms.Button buttonWypelnijZAPI;
        private System.Windows.Forms.ToolStripStatusLabel wersja;
    }
}

