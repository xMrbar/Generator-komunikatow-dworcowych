using System;
using System.Windows.Forms;

namespace Generator_komunikatów_dworcowych
{
    public partial class komunikaty : Form
    {
        string początek;
        string relacja;
        string torIPeron;
        string godziny;
        string rezerwacja;

        public komunikaty()
        {
            InitializeComponent();
        }

        private void generujButton_Click(object sender, EventArgs e)
        {
            if (box_stacja_początkowa.Text.Length > 0 && box_stacja_końcowa.Text.Length > 0 && comboPrzewoźnik.Text.Length > 0 && comboKategoriaHandlowa.Text.Length > 0 && naszaStacjaWRJ.Text.Length > 0 && boxPeron.Text.Length > 0 && boxTor.Text.Length > 0 && comboPrzyStOdj.Text.Length > 0)
            {
                if (insideSF.SF.KategoriaAPrzewoźnik(comboKategoriaHandlowa.Text, comboPrzewoźnik.Text) == "0")
                {
                    if (insideSF.SF.koniecTylkoPrzyjazd(naszaStacjaWRJ.Text, comboPrzyStOdj.Text) == "0")
                    {

                        StringSet();

                        if (!pociągMaOpóźnienie.Checked)
                        {
                            komunikatWygenerowanyBox.Clear();
                            komunikatWygenerowanyBox.AppendText(Generator.Late.Komunikat(początek, relacja, torIPeron, godziny, rezerwacja));
                        }
                        else
                        {
                            komunikatWygenerowanyBox.Clear();
                            komunikatWygenerowanyBox.AppendText(Generator.Late.KomunikatLate(początek, relacja, torIPeron, godziny, rezerwacja));
                        }

                    }
                    else
                    {
                        MessageBox.Show("Na stację końcową może zostać wygenerowany tylko wjazd pociągu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (pociągMaOpóźnienie.Checked)
            {
                OpóźnienieTXT.Visible = true;
                opóźnienieBox.Visible = true;
            }
            else
            {
                OpóźnienieTXT.Visible = false;
                opóźnienieBox.Visible = false;
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
                    Generator.Wielowątkowość.NewThread1(this, GongName.Text, isGongOn.Checked);
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
                                StringSetMowa();

                                dźwiękButton.Enabled = false;
                                dzwiekTestButton.Enabled = false;
                                Generator.Wielowątkowość.NewThread(początek, relacja, torIPeron, godziny, this, pociągMaOpóźnienie.Checked, GongName.Text, rezerwacja, isGongOn.Checked);
                            }
                            else
                            {
                                MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Na stację końcową może zostać wygenerowany tylko wjazd pociągu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Generator.Wielowątkowość.NewThread2(this, GongName.Text);
            }
            else
            {
                MessageBox.Show("Proszę wybrać gong rozpoczynający zapowiedź", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StringSet()
        {
            początek = PodmianaNazw.Podmiana.Kategoria(comboKategoriaHandlowa.Text, pociągMaOpóźnienie.Checked, comboPrzewoźnik.Text, nazwaPociąguBox.Text, comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
            relacja = PodmianaNazw.Podmiana.Relacja(box_stacja_początkowa.Text, box_stacja_końcowa.Text, przezBox.Text, naszaStacjaWRJ.Text, comboPrzyStOdj.Text, pociągMaOpóźnienie.Checked);
            torIPeron = PodmianaNazw.Podmiana.torIPeron(comboPrzyStOdj.Text, boxPeron.Text, boxTor.Text, pociągMaOpóźnienie.Checked, naszaStacjaWRJ.Text);
            godziny = PodmianaNazw.Podmiana.godzina(godzinyOdjazdu.Value.ToString(), godzinaPrzyjazdu.Value.ToString(), minutyOdjazdu.Value.ToString(), minutyPrzyjazdu.Value.ToString(), pociągMaOpóźnienie.Checked, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, opóźnienieBox.Value.ToString());
            rezerwacja = PodmianaNazw.Podmiana.Rezerwacja(ifReserwation.Checked, Początek1.Value.ToString(), Początek2.Value.ToString(), Początek3.Value.ToString(), Początek4.Value.ToString(), Początek5.Value.ToString(), Początek6.Value.ToString(), Początek7.Value.ToString(), Środek1.Value.ToString(), Środek2.Value.ToString(), Środek3.Value.ToString(), Środek4.Value.ToString(), Środek5.Value.ToString(), Środek6.Value.ToString(), Środek7.Value.ToString(), Koniec1.Value.ToString(), Koniec2.Value.ToString(), Koniec3.Value.ToString(), Koniec4.Value.ToString(), Koniec5.Value.ToString(), Koniec6.Value.ToString(), Koniec7.Value.ToString(), ileWagonówWSkładzie.Value.ToString(), comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
        }

        private void StringSetMowa()
        {
            początek = PodmianaNazw.Podmiana.Kategoria(comboKategoriaHandlowa.Text, pociągMaOpóźnienie.Checked, comboPrzewoźnik.Text, nazwaPociąguBox.Text, comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
            relacja = PodmianaNazw.Podmiana.Relacja(box_stacja_początkowa.Text, box_stacja_końcowa.Text, przezBox.Text, naszaStacjaWRJ.Text, comboPrzyStOdj.Text, pociągMaOpóźnienie.Checked);
            torIPeron = PodmianaNazw.Podmiana.torIPeronMowa(comboPrzyStOdj.Text, boxPeron.Text, boxTor.Text, pociągMaOpóźnienie.Checked, naszaStacjaWRJ.Text);
            godziny = PodmianaNazw.Podmiana.godzinaMowa(godzinyOdjazdu.Value.ToString(), godzinaPrzyjazdu.Value.ToString(), minutyOdjazdu.Value.ToString(), minutyPrzyjazdu.Value.ToString(), pociągMaOpóźnienie.Checked, comboPrzyStOdj.Text, naszaStacjaWRJ.Text, opóźnienieBox.Value.ToString());
            rezerwacja = PodmianaNazw.Podmiana.RezerwacjaMowa(ifReserwation.Checked, Początek1.Value.ToString(), Początek2.Value.ToString(), Początek3.Value.ToString(), Początek4.Value.ToString(), Początek5.Value.ToString(), Początek6.Value.ToString(), Początek7.Value.ToString(), Środek1.Value.ToString(), Środek2.Value.ToString(), Środek3.Value.ToString(), Środek4.Value.ToString(), Środek5.Value.ToString(), Środek6.Value.ToString(), Środek7.Value.ToString(), Koniec1.Value.ToString(), Koniec2.Value.ToString(), Koniec3.Value.ToString(), Koniec4.Value.ToString(), Koniec5.Value.ToString(), Koniec6.Value.ToString(), Koniec7.Value.ToString(), ileWagonówWSkładzie.Value.ToString(), comboPrzyStOdj.Text, naszaStacjaWRJ.Text);
        }
    }
}
