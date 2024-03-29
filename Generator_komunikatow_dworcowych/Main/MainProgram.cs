﻿using GeneratorKomunikatów;
using System;
//using System.ComponentModel;
using System.IO;
using System.Runtime.Versioning;
using System.Speech.Synthesis;
//using System.Windows.Controls;
using System.Windows.Forms;
/*using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Resources;
using System.Windows.Threading;*/


namespace Generator_komunikatów_dworcowych
{
    [SupportedOSPlatform("windows")]
    public partial class komunikaty : Form
    {
        string początek;
        string relacja;
        string torIPeron;
        string godziny;
        string rezerwacja;

        Generator.Wielowatkowosc wielowatkowosc = new Generator.Wielowatkowosc();
        API api = new API();

        public komunikaty()
        {
            sprawdzanieWersji();

            ZaladujDziekiGongu();
            InitializeComponent();

            wygladStrony.SelectedIndex = 0;
        }


        private void generujButton_Click(object sender, EventArgs e)
        {
            if (box_stacja_początkowa.Text.Length > 0 && box_stacja_końcowa.Text.Length > 0 && comboPrzewoźnik.Text.Length > 0 && comboKategoriaHandlowa.Text.Length > 0 && naszaStacjaWRJ.Text.Length > 0 && boxPeron.Text.Length > 0 && boxTor.Text.Length > 0 && comboPrzyStOdj.Text.Length > 0)
            {
                if (insideSF.SF.KategoriaAPrzewoźnik(comboKategoriaHandlowa.Text, comboPrzewoźnik.Text) == "0")
                {
                    if (insideSF.SF.koniecTylkoPrzyjazd(naszaStacjaWRJ.Text, comboPrzyStOdj.Text) == "0")
                    {
                        bool czyCzas = roznicaCzasu();
                        StringSet(czyCzas);

                        if (!pociągPrzyjedzieOpoznienie.Checked)
                        {
                            komunikatWygenerowanyBox.Clear();
                            komunikatWygenerowanyBox.AppendText(Generator.Late.Komunikat(początek, relacja, torIPeron, godziny, rezerwacja, comboPrzyStOdj.Text, naszaStacjaWRJ.Text));
                        }
                        else
                        {
                            komunikatWygenerowanyBox.Clear();
                            komunikatWygenerowanyBox.AppendText(Generator.Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, czyCzas));
                        }

                    }
                    else
                    {
                        MessageBox.Show("Na stację końcową nie może zostać wygenerowany odjazd pociągu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Podany przewoźnik nie pasuje do podanej kategorii składu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wszystkie wymagane parametry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
        }

        private void wyczyscButton_Click(object sender, EventArgs e)
        {
            box_stacja_początkowa.Clear();
            box_stacja_końcowa.Clear();
            przezBox.Clear();
            boxPeron.Clear();
            boxTor.Clear();
            nazwaPociąguBox.Clear();
            GC.Collect();
        }

        private void generujBezZatrzymaniaButton_Click(object sender, EventArgs e)
        {
            komunikatWygenerowanyBox.Clear();
            komunikatWygenerowanyBox.AppendText("Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!");
        }

        private void pociągMaOpóźnienie_CheckedChanged(object sender, EventArgs e)
        {
            if (pociągPrzyjedzieOpoznienie.Checked)
            {
                OpoznieniePrzyjTXT.Visible = true;
                opoznieniePrzyjBox.Visible = true;
            }
            else
            {
                OpoznieniePrzyjTXT.Visible = false;
                opoznieniePrzyjBox.Visible = false;
            }
        }

        public void dźwiękButton_Click(object sender, EventArgs e)
        {
            if (komunikatWygenerowanyBox.Text == "Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!")
            {
                if (GongName.Text.Length > 0 || !isGongOn.Checked)
                {
                    dźwiękButton.Enabled = false;
                    dzwiekTestButton.Enabled = false;
                    syntezatorTestButton.Enabled = false;

                    wielowatkowosc.NewThread1(this, GongName.Text, isGongOn.Checked, trackBarGlosnoscOgolna.Value, trackBarGlosnoscGongu.Value);
                }
                else
                {
                    MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (box_stacja_początkowa.Text.Length > 0 && box_stacja_końcowa.Text.Length > 0 && comboPrzewoźnik.Text.Length > 0 && comboKategoriaHandlowa.Text.Length > 0 && naszaStacjaWRJ.Text.Length > 0 && boxPeron.Text.Length > 0 && boxTor.Text.Length > 0 && comboPrzyStOdj.Text.Length > 0)
                {
                    if (insideSF.SF.KategoriaAPrzewoźnik(comboKategoriaHandlowa.Text, comboPrzewoźnik.Text) == "0")
                    {
                        if (insideSF.SF.koniecTylkoPrzyjazd(naszaStacjaWRJ.Text, comboPrzyStOdj.Text) == "0")
                        {
                            if (GongName.Text.Length > 0 || !isGongOn.Checked)
                            {
                                bool czyCzas = roznicaCzasu();

                                StringSetMowa(czyCzas);

                                dźwiękButton.Enabled = false;
                                dzwiekTestButton.Enabled = false;
                                syntezatorTestButton.Enabled = false;

                                wielowatkowosc.NewThread(początek, relacja, torIPeron, godziny, this, pociągPrzyjedzieOpoznienie.Checked, GongName.Text, rezerwacja, isGongOn.Checked, trackBarGlosnoscOgolna.Value, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, trackBarGlosnoscGongu.Value, czyCzas);
                            }
                            else
                            {
                                MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Na stację końcową nie może zostać wygenerowany odjazd pociągu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podany przewoźnik nie pasuje do podanej kategorii składu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wprowadzić wszystkie wymagane parametry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GC.Collect();
        }

        private void ifReserwation_CheckedChanged(object sender, EventArgs e)
        {
            if (ifReserwation.Checked)
            {
                ileWagonowTXT.Visible = true;
                ileWagonówWSkładzie.Visible = true;
                GeneratorKomunikatów.Rezerwacja.PokazywanieWagonówRezerwacji(this);
            }
            else
            {
                GeneratorKomunikatów.Rezerwacja.ChowanieWszystkichRezerwacji(this);
            }
        }

        private void ileWagonówWSkładzie_ValueChanged(object sender, EventArgs e)
        {
            if (ifReserwation.Checked)
            {
                GeneratorKomunikatów.Rezerwacja.PokazywanieWagonówRezerwacji(this);
            }
            else if (!ifReserwation.Checked)
            {
                GeneratorKomunikatów.Rezerwacja.ChowanieWszystkichRezerwacji(this);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wygladStrony.Text == "biały")
            {
                tabPageOpcje.BackColor = System.Drawing.Color.SeaShell;
                tabPageKomunikaty.BackColor = System.Drawing.Color.SeaShell;
                GUI.napisy.czarne(this);
                //GUI.Rubryki.biale(this);
            }
            else if (wygladStrony.Text == "różowy")
            {
                tabPageOpcje.BackColor = System.Drawing.Color.RosyBrown;
                tabPageKomunikaty.BackColor = System.Drawing.Color.RosyBrown;
                GUI.napisy.czarne(this);
                //GUI.Rubryki.biale(this);
            }
            else if (wygladStrony.Text == "ciemny1")
            {
                tabPageOpcje.BackColor = System.Drawing.Color.FromArgb(255, 28, 28, 28);
                tabPageKomunikaty.BackColor = System.Drawing.Color.FromArgb(255, 28, 28, 28);
                GUI.napisy.biale(this);
                //GUI.Rubryki.ciemne(this);
            }
            else if (wygladStrony.Text == "ciemny2")
            {
                tabPageOpcje.BackColor = System.Drawing.Color.FromArgb(255, 28, 28, 28);
                tabPageKomunikaty.BackColor = System.Drawing.Color.FromArgb(255, 28, 28, 28);
                GUI.napisy.zolte(this);
                //GUI.Rubryki.ciemne(this);
            }
        }

        private void dzwiekTestButton_Click(object sender, EventArgs e)
        {
            if (GongName.Text.Length > 0)
            {
                dźwiękButton.Enabled = false;
                dzwiekTestButton.Enabled = false;
                syntezatorTestButton.Enabled = false;
                wielowatkowosc.NewThread2(this, GongName.Text, trackBarGlosnoscGongu.Value);
            }
            else
            {
                MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StringSet(bool czyCzas)
        {
            początek = PodmianaNazw.Podmiana.Kategoria(comboKategoriaHandlowa.Text, pociągPrzyjedzieOpoznienie.Checked, comboPrzewoźnik.Text, nazwaPociąguBox.Text, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, czyCzas);
            relacja = PodmianaNazw.Podmiana.Relacja(box_stacja_początkowa.Text, box_stacja_końcowa.Text, przezBox.Text, naszaStacjaWRJ.Text, comboPrzyStOdj.Text, pociągPrzyjedzieOpoznienie.Checked, czyCzas);
            torIPeron = PodmianaNazw.Podmiana.torIPeron(comboPrzyStOdj.Text, boxPeron.Text, boxTor.Text, pociągPrzyjedzieOpoznienie.Checked, naszaStacjaWRJ.Text, comboKategoriaHandlowa.Text, czyCzas);
            godziny = PodmianaNazw.Podmiana.godzina(godzinyOdjazdu.Value.ToString(), godzinaPrzyjazdu.Value.ToString(), minutyOdjazdu.Value.ToString(), minutyPrzyjazdu.Value.ToString(), pociągPrzyjedzieOpoznienie.Checked, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, opoznieniePrzyjBox.Value.ToString(), czyCzas);
            rezerwacja = PodmianaNazw.Podmiana.Rezerwacja(ifReserwation.Checked, Początek1.Value.ToString(), Początek2.Value.ToString(), Początek3.Value.ToString(), Początek4.Value.ToString(), Początek5.Value.ToString(), Początek6.Value.ToString(), Początek7.Value.ToString(), Środek1.Value.ToString(), Środek2.Value.ToString(), Środek3.Value.ToString(), Środek4.Value.ToString(), Środek5.Value.ToString(), Środek6.Value.ToString(), Środek7.Value.ToString(), Koniec1.Value.ToString(), Koniec2.Value.ToString(), Koniec3.Value.ToString(), Koniec4.Value.ToString(), Koniec5.Value.ToString(), Koniec6.Value.ToString(), Koniec7.Value.ToString(), ileWagonówWSkładzie.Value.ToString(), comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
        }

        private void StringSetMowa(bool czyCzas)
        {
            początek = PodmianaNazw.Podmiana.Kategoria(comboKategoriaHandlowa.Text, pociągPrzyjedzieOpoznienie.Checked, comboPrzewoźnik.Text, nazwaPociąguBox.Text, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, czyCzas);
            relacja = PodmianaNazw.Podmiana.Relacja(box_stacja_początkowa.Text, box_stacja_końcowa.Text, przezBox.Text, naszaStacjaWRJ.Text, comboPrzyStOdj.Text, pociągPrzyjedzieOpoznienie.Checked, czyCzas);
            torIPeron = PodmianaNazw.Podmiana.torIPeronMowa(comboPrzyStOdj.Text, boxPeron.Text, boxTor.Text, pociągPrzyjedzieOpoznienie.Checked, naszaStacjaWRJ.Text, comboKategoriaHandlowa.Text, czyCzas);
            godziny = PodmianaNazw.Podmiana.godzinaMowa(godzinyOdjazdu.Value.ToString(), godzinaPrzyjazdu.Value.ToString(), minutyOdjazdu.Value.ToString(), minutyPrzyjazdu.Value.ToString(), pociągPrzyjedzieOpoznienie.Checked, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, opoznieniePrzyjBox.Value.ToString(), czyCzas);
            rezerwacja = PodmianaNazw.Podmiana.RezerwacjaMowa(ifReserwation.Checked, Początek1.Value.ToString(), Początek2.Value.ToString(), Początek3.Value.ToString(), Początek4.Value.ToString(), Początek5.Value.ToString(), Początek6.Value.ToString(), Początek7.Value.ToString(), Środek1.Value.ToString(), Środek2.Value.ToString(), Środek3.Value.ToString(), Środek4.Value.ToString(), Środek5.Value.ToString(), Środek6.Value.ToString(), Środek7.Value.ToString(), Koniec1.Value.ToString(), Koniec2.Value.ToString(), Koniec3.Value.ToString(), Koniec4.Value.ToString(), Koniec5.Value.ToString(), Koniec6.Value.ToString(), Koniec7.Value.ToString(), ileWagonówWSkładzie.Value.ToString(), comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
        }

        private void listaPociagowDodaj_Click(object sender, EventArgs e)
        {
            string[] wagony =
            {
                Początek1.Value.ToString(), Początek2.Value.ToString(), Początek3.Value.ToString(), Początek4.Value.ToString(), Początek5.Value.ToString(), Początek6.Value.ToString(), Początek7.Value.ToString(),
                Środek1.Value.ToString(), Środek2.Value.ToString(),Środek3.Value.ToString(), Środek4.Value.ToString(), Środek5.Value.ToString(), Środek6.Value.ToString(), Środek7.Value.ToString(),
                Koniec1.Value.ToString(), Koniec2.Value.ToString(), Koniec3.Value.ToString(), Koniec4.Value.ToString(), Koniec5.Value.ToString(), Koniec6.Value.ToString(), Koniec7.Value.ToString()
            };

            string[] tablica = new string[] {
                numerPociąguBox.Value.ToString(),
                box_stacja_początkowa.Text,
                box_stacja_końcowa.Text
            };

            System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem(tablica);

            //numer
            item.SubItems.Add(numerPociąguBox.Value.ToString());
            //stacje
            item.SubItems.Add(box_stacja_początkowa.Text);
            item.SubItems.Add(box_stacja_końcowa.Text);
            item.SubItems.Add(przezBox.Text);
            //godzina
            item.SubItems.Add(godzinaPrzyjazdu.Value.ToString());
            item.SubItems.Add(minutyPrzyjazdu.Value.ToString());
            item.SubItems.Add(godzinyOdjazdu.Value.ToString());
            item.SubItems.Add(minutyOdjazdu.Value.ToString());
            //opoźnienie
            item.SubItems.Add(pociągPrzyjedzieOpoznienie.Checked.ToString());
            item.SubItems.Add(opoznieniePrzyjBox.Value.ToString());
            //tor i peron
            item.SubItems.Add(boxTor.Text);
            item.SubItems.Add(boxPeron.Text);
            //rezerwacja
            item.SubItems.Add(ifReserwation.Checked.ToString());
            item.SubItems.Add(ileWagonówWSkładzie.Value.ToString());
            for (int i = 0; i < 21; i++)
            {
                item.SubItems.Add(wagony[i]);
            }
            //info ogólne
            item.SubItems.Add(naszaStacjaWRJ.Text);
            item.SubItems.Add(comboPrzyStOdj.Text);
            //przewoźnik
            item.SubItems.Add(comboKategoriaHandlowa.Text);
            item.SubItems.Add(comboPrzewoźnik.Text);
            item.SubItems.Add(nazwaPociąguBox.Text);

            listaPociagowZapisanych.Items.Add(item);
        }

        private void listaPociagowUsun_Click(object sender, EventArgs e)
        {
            if (listaPociagowZapisanych.SelectedItems.Count > 0)
            {
                listaPociagowZapisanych.Items.Remove(listaPociagowZapisanych.SelectedItems[0]);
                GC.Collect();
            }
        }

        private void listaPociagowWczytaj_Click(object sender, EventArgs e)
        {
            if (listaPociagowZapisanych.SelectedItems.Count > 0)
            {
                System.Windows.Forms.ListViewItem item = listaPociagowZapisanych.SelectedItems[0];

                //numer
                numerPociąguBox.Value = Decimal.Parse(item.SubItems[3].Text);
                //stacje
                box_stacja_początkowa.Text = item.SubItems[4].Text;
                box_stacja_końcowa.Text = item.SubItems[5].Text;
                przezBox.Text = item.SubItems[6].Text;
                //godzina
                godzinaPrzyjazdu.Value = Decimal.Parse(item.SubItems[7].Text);
                minutyPrzyjazdu.Value = Decimal.Parse(item.SubItems[8].Text);
                godzinyOdjazdu.Value = Decimal.Parse(item.SubItems[9].Text);
                minutyOdjazdu.Value = Decimal.Parse(item.SubItems[10].Text);
                //opóżnienie
                pociągPrzyjedzieOpoznienie.Checked = Boolean.Parse(item.SubItems[11].Text);
                opoznieniePrzyjBox.Value = Decimal.Parse(item.SubItems[12].Text);
                //tor i peron
                boxTor.Text = item.SubItems[13].Text;
                boxPeron.Text = item.SubItems[14].Text;
                //rezerwacja
                ifReserwation.Checked = Boolean.Parse(item.SubItems[15].Text);
                ileWagonówWSkładzie.Value = Decimal.Parse(item.SubItems[16].Text);
                uzupelnijNumeryWagonow(item);
                //info ogólne
                naszaStacjaWRJ.Text = item.SubItems[38].Text;
                comboPrzyStOdj.Text = item.SubItems[39].Text;
                //przewoźnik
                comboKategoriaHandlowa.Text = item.SubItems[40].Text;
                comboPrzewoźnik.Text = item.SubItems[41].Text;
                nazwaPociąguBox.Text = item.SubItems[42].Text;
            }
        }

        private void uzupelnijNumeryWagonow(System.Windows.Forms.ListViewItem item)
        {
            NumericUpDown[] tablicaNazwWagonow = {
                Początek1, Początek2, Początek3, Początek4, Początek5, Początek6, Początek7,
                Środek1, Środek2, Środek3, Środek4, Środek5, Środek6, Środek7,
                Koniec1, Koniec2, Koniec3, Koniec4, Koniec5, Koniec6, Koniec7
            };

            for (int i = 0; i < 21; i++)
            {
                tablicaNazwWagonow[i].Value = Decimal.Parse(item.SubItems[i + 17].Text);
            }
        }

        private void zatrzymajModulator_Click(object sender, EventArgs e)
        {
            zatrzymajModulator.Enabled = false;
            Generator.Gadanie.ButtonEnabled2(this);
            wielowatkowosc.synth.Pause();
        }

        private void wznowSyntezator_Click(object sender, EventArgs e)
        {
            wznowSyntezator.Enabled = false;
            Generator.Gadanie.ButtonEnabled1(this);
            wielowatkowosc.synth.Resume();
        }

        private void anulujSyntezator_Click(object sender, EventArgs e)
        {
            wielowatkowosc.synth.Pause();
            wielowatkowosc.synth.Dispose();

            Generator.Gadanie.ButtonEnabled(this);
            ButtonDisabled();
        }

        public void ButtonDisabled()
        {
            MethodInvoker changeState = delegate ()
            {
                wznowSyntezator.Enabled = false;
                zatrzymajModulator.Enabled = false;
                anulujSyntezator.Enabled = false;
            };

            if (InvokeRequired)
            {
                try
                {
                    Invoke(changeState);
                }
                catch (ObjectDisposedException)
                {

                }
            }
            else
            {
                changeState();
            }
        }

        public void ZamkniecieOkna(object sender, FormClosedEventArgs e)
        {
            if (wielowatkowosc.c != null)
            {
                wielowatkowosc.c.Stop();
            }

            if (wielowatkowosc.synth != null)
            {
                wielowatkowosc.synth.Dispose();
            }

            GC.Collect();
        }

        public void ZaladujDziekiGongu()
        {
            String[] nazwy = { "gong-wroclaw.wav", "gong1.wav", "gong2.wav", "gong-torun.wav" };
            Stream[] zasoby = { GeneratorKomunikatów.Properties.Resources.gong_wroclaw, GeneratorKomunikatów.Properties.Resources.gong1,
                GeneratorKomunikatów.Properties.Resources.gong2 , GeneratorKomunikatów.Properties.Resources.gong_torun};

            for (int i = 0; i < nazwy.Length; i++)
            {
                var file = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Voice");
                var file1 = System.IO.Path.Combine(file, nazwy[i]);

                if (!File.Exists(file1))
                {
                    Stream s = zasoby[i];

                    Directory.CreateDirectory(file);

                    var fileStream = File.Create(file1);

                    s.Seek(0, SeekOrigin.Begin);
                    s.CopyTo(fileStream);

                    s.Close();
                    fileStream.Close();
                }
            }
        }

        private bool roznicaCzasu()
        {
            bool czyCzas = false;
            if (pociągPrzyjedzieOpoznienie.Checked)
            {
                TimeZoneInfo polishTimeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
                DateTime polishTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, polishTimeZoneInfo);
                DateTime trainTime = new DateTime(polishTime.Year, polishTime.Month, polishTime.Day, (int)godzinaPrzyjazdu.Value, (int)minutyPrzyjazdu.Value, 0);

                if (polishTime > trainTime)
                {
                    trainTime = new DateTime(polishTime.Year, polishTime.Month, polishTime.Day + 1, (int)godzinaPrzyjazdu.Value, (int)minutyPrzyjazdu.Value, 0);
                }
                TimeSpan timeSpan = trainTime - polishTime;

                if (timeSpan.Hours == 0 && timeSpan.Minutes <= 3)
                {
                    czyCzas = true;
                }
            }
            return czyCzas;
        }

        private void buttonWypelnijZAPI_Click(object sender, EventArgs e)
        {
            api.DeserilizeJsonTrain(this);
        }

        private void sprawdzanieWersji()
        {
            api.DeserilizeJsonVersion(this);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            return;
        }

        private void buttonSoundToFile_Click(object sender, EventArgs e)
        {
            if (komunikatWygenerowanyBox.Text == "Uwaga! Przez stację przejedzie pociąg, bez zatrzymania! Prosimy zachować ostrożność i odsunąć się od krawędzi peronu!")
            {
                if (GongName.Text.Length > 0 || !isGongOn.Checked)
                {
                    dźwiękButton.Enabled = false;
                    dzwiekTestButton.Enabled = false;

                    wielowatkowosc.ThreadSaveSpeechBezZatrzymania(this, GongName.Text, isGongOn.Checked);
                }
                else
                {
                    MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (box_stacja_początkowa.Text.Length > 0 && box_stacja_końcowa.Text.Length > 0 && comboPrzewoźnik.Text.Length > 0 && comboKategoriaHandlowa.Text.Length > 0 && naszaStacjaWRJ.Text.Length > 0 && boxPeron.Text.Length > 0 && boxTor.Text.Length > 0 && comboPrzyStOdj.Text.Length > 0)
                {
                    if (insideSF.SF.KategoriaAPrzewoźnik(comboKategoriaHandlowa.Text, comboPrzewoźnik.Text) == "0")
                    {
                        if (insideSF.SF.koniecTylkoPrzyjazd(naszaStacjaWRJ.Text, comboPrzyStOdj.Text) == "0")
                        {
                            if (GongName.Text.Length > 0 || !isGongOn.Checked)
                            {
                                bool czyCzas = roznicaCzasu();
                                StringSetMowa(czyCzas);

                                dźwiękButton.Enabled = false;
                                dzwiekTestButton.Enabled = false;

                                wielowatkowosc.ThreadSaveSpeech(początek, relacja, torIPeron, godziny, this, pociągPrzyjedzieOpoznienie.Checked, GongName.Text, rezerwacja, isGongOn.Checked, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, czyCzas);
                            }
                            else
                            {
                                MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Na stację końcową nie może zostać wygenerowany odjazd pociągu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podany przewoźnik nie pasuje do podanej kategorii składu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wprowadzić wszystkie wymagane parametry!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            GC.Collect();
        }

        private void syntezatorTestButton_Click(object sender, EventArgs e)
        {
            dźwiękButton.Enabled = false;
            dzwiekTestButton.Enabled = false;
            syntezatorTestButton.Enabled = false;
            wielowatkowosc.NewThread3(this, trackBarGlosnoscOgolna.Value);
        }

        private void pociągOdjedzieOpoznienie_CheckedChanged(object sender, EventArgs e)
        {
            if (pociągOdjedzieOpoznienie.Checked)
            {
                OpoznienieOdjTXT.Visible = true;
                opoznienieOdjBox.Visible = true;
            }
            else
            {
                OpoznienieOdjTXT.Visible = false;
                opoznienieOdjBox.Visible = false;
            }
        }
    }
}
