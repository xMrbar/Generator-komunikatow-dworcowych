using System.Runtime.Versioning;

namespace GeneratorKomunikatów
{
    [SupportedOSPlatform("windows")]
    class Rezerwacja
    {
        public static void PokazywanieWagonówRezerwacji(Generator_komunikatów_dworcowych.komunikaty current)
        {
            if (current.ileWagonówWSkładzie.Value == 1)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = false;
                current.WagonyKoniecTXT.Visible = false;
                current.Początek1.Visible = true;
                current.Początek2.Visible = false;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = false;
                current.Środek2.Visible = false;
                current.Środek3.Visible = false;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = false;
                current.Koniec2.Visible = false;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 2)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = false;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = false;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = false;
                current.Środek2.Visible = false;
                current.Środek3.Visible = false;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = false;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 3)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = false;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = false;
                current.Środek3.Visible = false;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = false;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 4)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = false;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = false;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = false;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 5)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = false;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = false;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 6)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = false;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 7)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 8)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = false;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = false;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 9)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = false;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 10)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 11)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = false;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = false;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 12)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = false;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 13)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 14)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = false;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = false;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 15)
            {
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = false;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 16)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 17)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = false;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = true;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = false;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 18)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = true;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = false;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = true;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 19)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = true;
                current.Początek7.Visible = false;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = true;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = true;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 20)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = true;
                current.Początek7.Visible = true;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = true;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = true;
                current.Koniec7.Visible = false;
            }
            else if (current.ileWagonówWSkładzie.Value == 21)
            {
                current.WagonyPoczątekTXT.Visible = true;
                current.WagonyŚrodekTXT.Visible = true;
                current.WagonyKoniecTXT.Visible = true;
                current.Początek1.Visible = true;
                current.Początek2.Visible = true;
                current.Początek3.Visible = true;
                current.Początek4.Visible = true;
                current.Początek5.Visible = true;
                current.Początek6.Visible = true;
                current.Początek7.Visible = true;
                current.Środek1.Visible = true;
                current.Środek2.Visible = true;
                current.Środek3.Visible = true;
                current.Środek4.Visible = true;
                current.Środek5.Visible = true;
                current.Środek6.Visible = true;
                current.Środek7.Visible = true;
                current.Koniec1.Visible = true;
                current.Koniec2.Visible = true;
                current.Koniec3.Visible = true;
                current.Koniec4.Visible = true;
                current.Koniec5.Visible = true;
                current.Koniec6.Visible = true;
                current.Koniec7.Visible = true;
            }
        }

        public static void ChowanieWszystkichRezerwacji(Generator_komunikatów_dworcowych.komunikaty current)
        {
            current.ileWagonowTXT.Visible = false;
            current.ileWagonówWSkładzie.Visible = false;
            current.WagonyPoczątekTXT.Visible = false;
            current.WagonyŚrodekTXT.Visible = false;
            current.WagonyKoniecTXT.Visible = false;
            current.Początek1.Visible = false;
            current.Początek2.Visible = false;
            current.Początek3.Visible = false;
            current.Początek4.Visible = false;
            current.Początek5.Visible = false;
            current.Początek6.Visible = false;
            current.Początek7.Visible = false;
            current.Środek1.Visible = false;
            current.Środek2.Visible = false;
            current.Środek3.Visible = false;
            current.Środek4.Visible = false;
            current.Środek5.Visible = false;
            current.Środek6.Visible = false;
            current.Środek7.Visible = false;
            current.Koniec1.Visible = false;
            current.Koniec2.Visible = false;
            current.Koniec3.Visible = false;
            current.Koniec4.Visible = false;
            current.Koniec5.Visible = false;
            current.Koniec6.Visible = false;
            current.Koniec7.Visible = false;
        }
    }
}
