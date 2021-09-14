using System;
using System.Windows.Forms.VisualStyles;

namespace PodmianaNazw
{
    class Podmiana
    {
        public static string Kategoria(string kategoriaWprowadzona, bool opóźnienie, string Przewoźnik, string nazwaSkładu, string PSO, string stacjaWRJ)
        {
            if (opóźnienie == false)
            {
                if (kategoriaWprowadzona == "TLK")
                {
                    return "Pociąg TLK " + nazwaSkładu + " ";
                }
                else if (kategoriaWprowadzona == "IC")
                {
                    return "Pociąg Intercity " + nazwaSkładu + " ";
                }
                else if (kategoriaWprowadzona == "EIC")
                {
                    return "Pociąg Express Intercity " + nazwaSkładu + " ";
                }
                else if (kategoriaWprowadzona == "Osobowy")
                {
                    if (Przewoźnik == "POLREGIO")
                    {
                        return "Pociąg regio " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "SKM")
                    {
                        return "Pociąg SKM " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KD")
                    {
                        return "Pociąg Kolei Dolnośląskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KM")
                    {
                        return "Pociąg Kolei Mazowieckich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KMŁ")
                    {
                        return "Pociąg Kolei Małopolskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KŚ")
                    {
                        return "Pociąg Kolei Śląskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KW")
                    {
                        return "Pociąg Kolei Wielkopolskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "ŁKA")
                    {
                        return "Pociąg Łódzkiej Kolei Aglomeracyjnej " + nazwaSkładu + " ";
                    }
                    else
                    {
                        return "BŁĄD PODCZAS GENEROWANIA";
                    }
                }
                else if (kategoriaWprowadzona == "Os. Przyspieszony")
                {
                    if (Przewoźnik == "KD")
                    {
                        return "Przyspieszony pociąg Kolei Dolnośląskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KM")
                    {
                        return "Przyspieszony pociąg Kolei Mazowieckich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KMŁ")
                    {
                        return "Przyspieszony pociąg Kolei Małopolskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KŚ")
                    {
                        return "Przyspieszony pociąg Kolei Śląskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "KW")
                    {
                        return "Przyspieszony pociąg Kolei Wielkopolskich " + nazwaSkładu + " ";
                    }
                    else if (Przewoźnik == "ŁKA")
                    {
                        return "Przyspieszony pociąg Łódzkiej Kolei Aglomeracyjnej " + nazwaSkładu + " ";
                    }
                    else
                    {
                        return "BŁĄD PODCZAS GENEROWANIA";
                    }
                }
                else if (kategoriaWprowadzona == "interREGIO")
                {
                    return "Pociąg INTERREGIO " + nazwaSkładu + " ";
                }
                else if (kategoriaWprowadzona == "superREGIO")
                {
                    return "Pociąg SUPERREGIO " + nazwaSkładu + " ";
                }
                else
                {
                    return "NIEOBSŁUGIWANY WYJĄTEK!";
                }
            }
            else
            {
                if (PSO == "Przyjedzie" && stacjaWRJ == "Początkowa")
                {

                    if (kategoriaWprowadzona == "TLK")
                    {
                        return "Pociąg TLK " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "IC")
                    {
                        return "Pociąg Intercity " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "EIC")
                    {
                        return "Pociąg Express Intercity " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                    {
                        if (Przewoźnik == "POLREGIO")
                        {
                            return "Pociąg regio " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "SKM")
                        {
                            return "Pociąg SKM " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KD")
                        {
                            return "Pociąg Kolei Dolnośląskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KM")
                        {
                            return "Pociąg Kolei Mazowieckich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KMŁ")
                        {
                            return "Pociąg Kolei Małopolskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KŚ")
                        {
                            return "Pociąg Kolei Śląskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KW")
                        {
                            return "Pociąg Kolei Wielkopolskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "ŁKA")
                        {
                            return "Pociąg Łódzkiej Kolei Aglomeracyjnej " + nazwaSkładu + " ";
                        }
                        else
                        {
                            return "BŁĄD PODCZAS GENEROWANIA";
                        }
                    }
                    else if (kategoriaWprowadzona == "superREGIO")
                    {
                        return "Pociąg SUPERREGIO " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "interREGIO")
                    {
                        return "Pociąg INTERREGIO " + nazwaSkładu + " ";
                    }
                    else
                    {
                        return "NIEOBSŁUGIWANY WYJĄTEK!";
                    }
                }
                else
                {
                    if (kategoriaWprowadzona == "TLK")
                    {
                        return "Opóźniony pociąg TLK " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "IC")
                    {
                        return "Opóźniony pociąg Intercity " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "EIC")
                    {
                        return "Opóźniony pociąg Express Intercity " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                    {
                        if (Przewoźnik == "POLREGIO")
                        {
                            return "Opóźniony pociąg " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "SKM")
                        {
                            return "Opóźniony pociąg SKM " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KD")
                        {
                            return "Opóźniony pociąg Kolei Dolnośląskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KM")
                        {
                            return "Opóźniony pociąg Kolei Mazowieckich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KMŁ")
                        {
                            return "Opóźniony pociąg Kolei Małopolskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KŚ")
                        {
                            return "Opóźniony pociąg Kolei Śląskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "KW")
                        {
                            return "Opóźniony pociąg Kolei Wielkopolskich " + nazwaSkładu + " ";
                        }
                        else if (Przewoźnik == "ŁKA")
                        {
                            return "Opóźniony pociąg Łódzkiej Kolei Aglomeracyjnej " + nazwaSkładu + " ";
                        }
                        else
                        {
                            return "BŁĄD PODCZAS GENEROWANIA";
                        }
                    }
                    else if (kategoriaWprowadzona == "interREGIO")
                    {
                        return "Opóźniony pociąg INTERREGIO " + nazwaSkładu + " ";
                    }
                    else if (kategoriaWprowadzona == "superREGIO")
                    {
                        return "Opóźniony pociąg SUPERREGIO " + nazwaSkładu + " ";
                    }
                    else
                    {
                        return "NIEOBSŁUGIWANY WYJĄTEK!";
                    }
                }
            }
        }
        public static string Relacja(string początek, string koniec, string przez, string stacjaWRJ, string PSO, bool czyOpóźniony)
        {
            if (stacjaWRJ == "Początkowa")
            {
                if (czyOpóźniony == false)
                {
                    if (przez.Length > 0)
                    {
                        return "do stacji " + koniec + ", przez stacje: " + przez;
                    }
                    else
                    {
                        return "do stacji " + koniec;
                    }
                }
                else
                {
                    return "do stacji " + koniec;
                }
            }
            else if (stacjaWRJ == "Pośrednia")
            {
                if (PSO == "Przyjedzie")
                {
                    if (przez.Length > 0)
                    {
                        return "ze stacji " + początek + " do stacji " + koniec + ", przez stacje: " + przez;
                    }
                    else
                    {
                        return "ze stacji " + początek + " do stacji " + koniec;
                    }
                }
                else
                {
                    if (przez.Length > 0)
                    {
                        return "do stacji " + koniec + ", przez stacje: " + przez;
                    }
                    else
                    {
                        return "do stacji " + koniec;
                    }
                }
            }
            else if (stacjaWRJ == "Końcowa")
            {
                return "ze stacji " + początek;
            }
            else
            {
                return "<NIEOBSŁUGIWANY WYJĄTEK!>";
            }
        }
        public static string torIPeron(string PSO, string Peron, string Tor, bool czyOpóźniony, string stacjaWRJ)
        {
            if (czyOpóźniony == true && PSO == "Przyjedzie" && stacjaWRJ == "Początkowa")
            {
                return "";
            }
            else
            {
                if (PSO == "Przyjedzie")
                {
                    return ", wjedzie na tor " + Tor + " przy peronie " + Peron;
                }
                else if (PSO == "Stoi")
                {
                    return ", stoi na torze " + Tor + " przy peronie " + Peron;
                }
                else
                {
                    return ", odjedzie z toru " + Tor + " przy peronie " + Peron;
                }
            }
        }
        public static string torIPeronMowa(string PSO, string Peron, string Tor, bool czyOpóźniony, string stacjaWRJ)
        {
            Tor = SyntezatorNumer.PodmianaNumerToru(Tor, PSO);
            Peron = SyntezatorNumer.PodmianaNumerPeronu(Peron);

            if (czyOpóźniony == true && PSO == "Przyjedzie" && stacjaWRJ == "Początkowa")
            {
                return "";
            }
            else
            {
                if (PSO == "Przyjedzie")
                {
                    return ", wjedzie na tor" + Tor + " przy peronie " + Peron + " ";
                }
                else if (PSO == "Stoi")
                {
                    return ", stoi na torze" + Tor + " przy peronie " + Peron + " ";
                }
                else
                {
                    return ", odjedzie z toru" + Tor + " przy peronie " + Peron + " ";
                }
            }
        }
        public static string godzina(string godzinaOdj, string godzinaPrz, string minutaOdj, string minutaPrz, bool czyOpóźniony, string PSO, string stacjaWRJ, string czasOpóźnienia)
        {
            godzinaOdj = godzinaOdj.PadLeft(2, '0');
            godzinaPrz = godzinaPrz.PadLeft(2, '0');
            minutaOdj = minutaOdj.PadLeft(2, '0');
            minutaPrz = minutaPrz.PadLeft(2, '0');
            if (czyOpóźniony == false)
            {
                if (stacjaWRJ == "Końcowa")
                {
                    return ". Pociąg kończy bieg. Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu.";
                }
                else
                {
                    if (PSO == "Przyjedzie")
                    {
                        return ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu. Planowy odjazd pociągu o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                    else if (PSO == "Stoi")
                    {
                        return ". Planowy odjazd pociągu o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                    else
                    {
                        return ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu. Życzymy państwu przyjemnej podróży.";
                    }
                }
            }
            else
            {
                if (stacjaWRJ == "Początkowa")
                {
                    if (PSO == "Przyjedzie")
                    {
                        return " odjeżdżający o godzinie " + godzinaOdj + ":" + minutaOdj + " z przyczyn technicznych zostanie podstawiony z opóźnieniem około " + czasOpóźnienia + " minut";
                    }
                    else
                    {
                        return " planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
                else
                {
                    if (PSO == "Przyjedzie")
                    {
                        return " planowy przyjazd o godzinie " + godzinaPrz + ":" + minutaPrz;
                    }
                    else
                    {
                        return " planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
            }
        }
        public static string godzinaMowa(string godzinaOdj, string godzinaPrz, string minutaOdj, string minutaPrz, bool czyOpóźniony, string PSO, string stacjaWRJ, string czasOpóźnienia)
        {
            godzinaOdj = godzinaOdj.PadLeft(2, '0');
            godzinaPrz = godzinaPrz.PadLeft(2, '0');
            minutaOdj = minutaOdj.PadLeft(2, '0');
            minutaPrz = minutaPrz.PadLeft(2, '0');

            godzinaOdj = SyntezatorNumer.GodzinaZmiana(godzinaOdj);
            godzinaPrz = SyntezatorNumer.GodzinaZmiana(godzinaPrz);

            if (czyOpóźniony == false)
            {
                if (stacjaWRJ == "Końcowa")
                {
                    return ". Pociąg kończy bieg. Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu";
                }
                else
                {
                    if (PSO == "Przyjedzie")
                    {
                        return ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu. Planowy odjazd pociągu o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                    else if (PSO == "Stoi")
                    {
                        return ". Planowy odjazd pociągu o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                    else
                    {
                        return ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu. Życzymy państwu przyjemnej podróży.";
                    }
                }
            }
            else
            {
                if (stacjaWRJ == "Początkowa")
                {
                    if (PSO == "Przyjedzie")
                    {
                        return " odjeżdżający o godzinie " + godzinaOdj + ":" + minutaOdj + " z przyczyn technicznych zostanie podstawiony z opóźnieniem około " + czasOpóźnienia + " minut";
                    }
                    else
                    {
                        return " planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
                else
                {
                    if (PSO == "Przyjedzie")
                    {
                        return " planowy przyjazd o godzinie " + godzinaPrz + ":" + minutaPrz;
                    }
                    else
                    {
                        return " planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
            }
        }
        public static string Rezerwacja(bool CzyRezerwacja, string Początek1, string Początek2, string Początek3, string Początek4, string Początek5, string Początek6, string Początek7, string Środek1, string Środek2, string Środek3, string Środek4, string Środek5, string Środek6, string Środek7, string Koniec1, string Koniec2, string Koniec3, string Koniec4, string Koniec5, string Koniec6, string Koniec7, string ileWagonówWSkładzie, string PSO, string stacjaWRJ)
        {
            if (CzyRezerwacja == true)
            {
                if (PSO == "Odjedzie" || stacjaWRJ == "Końcowa")
                {
                    return "";
                }
                else
                {
                    const string start = ". Pociąg objęty jest obowiązkową rezerwacją miejsc. ";
                    if (ileWagonówWSkładzie == "1")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "2")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "3")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagon numer " + Środek1 + " znajduje się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "4")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + " znajdują się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "5")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "6")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "7")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "8")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "9")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "10")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "11")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "12")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "13")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "14")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "15")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "16")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "17")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "18")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "19")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "20")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + ", " + Początek7 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "21")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + ", " + Początek7 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + ", " + Koniec7 + " znajdują się na końcu składu pociągu";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            else
            {
                return "";
            }
        }
        public static string RezerwacjaMowa(bool CzyRezerwacja, string Początek1, string Początek2, string Początek3, string Początek4, string Początek5, string Początek6, string Początek7, string Środek1, string Środek2, string Środek3, string Środek4, string Środek5, string Środek6, string Środek7, string Koniec1, string Koniec2, string Koniec3, string Koniec4, string Koniec5, string Koniec6, string Koniec7, string ileWagonówWSkładzie, string PSO, string stacjaWRJ)
        {
            Początek1 = SyntezatorNumer.NumerWagonu(Początek1);
            Początek2 = SyntezatorNumer.NumerWagonu(Początek2);
            Początek3 = SyntezatorNumer.NumerWagonu(Początek3);
            Początek4 = SyntezatorNumer.NumerWagonu(Początek4);
            Początek5 = SyntezatorNumer.NumerWagonu(Początek5);
            Początek6 = SyntezatorNumer.NumerWagonu(Początek6);
            Początek7 = SyntezatorNumer.NumerWagonu(Początek7);

            Środek1 = SyntezatorNumer.NumerWagonu(Środek1);
            Środek2 = SyntezatorNumer.NumerWagonu(Środek2);
            Środek3 = SyntezatorNumer.NumerWagonu(Środek3);
            Środek4 = SyntezatorNumer.NumerWagonu(Środek4);
            Środek5 = SyntezatorNumer.NumerWagonu(Środek5);
            Środek6 = SyntezatorNumer.NumerWagonu(Środek6);
            Środek7 = SyntezatorNumer.NumerWagonu(Środek7);

            Koniec1 = SyntezatorNumer.NumerWagonu(Koniec1);
            Koniec2 = SyntezatorNumer.NumerWagonu(Koniec2);
            Koniec3 = SyntezatorNumer.NumerWagonu(Koniec3);
            Koniec4 = SyntezatorNumer.NumerWagonu(Koniec4);
            Koniec5 = SyntezatorNumer.NumerWagonu(Koniec5);
            Koniec6 = SyntezatorNumer.NumerWagonu(Koniec6);
            Koniec7 = SyntezatorNumer.NumerWagonu(Koniec7);

            if (CzyRezerwacja == true)
            {
                if (PSO == "Odjedzie" || stacjaWRJ == "Końcowa")
                {
                    return "";
                }
                else
                {
                    const string start = ". Pociąg objęty jest obowiązkową rezerwacją miejsc. ";
                    if (ileWagonówWSkładzie == "1")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "2")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "3")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagon numer " + Środek1 + " znajduje się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "4")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + " znajdują się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "5")
                    {
                        return start + "Wagon numer " + Początek1 + " znajduje się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagon numer " + Koniec1 + " znajduje się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "6")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "7")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "8")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "9")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "10")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "11")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "12")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "13")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "14")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "15")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "16")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "17")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "18")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "19")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "20")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + ", " + Początek7 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + " znajdują się na końcu składu pociągu";
                    }
                    else if (ileWagonówWSkładzie == "21")
                    {
                        return start + "Wagony numer " + Początek1 + ", " + Początek2 + ", " + Początek3 + ", " + Początek4 + ", " + Początek5 + ", " + Początek6 + ", " + Początek7 + " znajdują się na początku składu, wagony numer " + Środek1 + ", " + Środek2 + ", " + Środek3 + ", " + Środek4 + ", " + Środek5 + ", " + Środek6 + ", " + Środek7 + " znajdują się w środku składu, wagony numer " + Koniec1 + ", " + Koniec2 + ", " + Koniec3 + ", " + Koniec4 + ", " + Koniec5 + ", " + Koniec6 + ", " + Koniec7 + " znajdują się na końcu składu pociągu";
                    }
                    else
                    {
                        return "";
                    }
                }
            }
            else
            {
                return "";
            }
        }
    }
    class SyntezatorNumer
    {
        public static string PodmianaNumerToru(string numer, string PSO)
        {
            string jedności;
            string dziesiątki;
            string setek;

            if (numer.EndsWith("1") || numer.EndsWith("2") || numer.EndsWith("3") || numer.EndsWith("4") || numer.EndsWith("5") || numer.EndsWith("6") || numer.EndsWith("7") || numer.EndsWith("8") || numer.EndsWith("9") || numer.EndsWith("0"))
            {
                numer = numer.PadLeft(4, '0');

                if (PSO == "Przyjedzie")
                {
                    if (numer.EndsWith("1") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "pierwszy";
                    }
                    else if (numer.EndsWith("2") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "drugi";
                    }
                    else if (numer.EndsWith("3") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "trzeci";
                    }
                    else if (numer.EndsWith("4") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "czwarty";
                    }
                    else if (numer.EndsWith("5") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "piąty";
                    }
                    else if (numer.EndsWith("6") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "szósty";
                    }
                    else if (numer.EndsWith("7") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "siódmy";
                    }
                    else if (numer.EndsWith("8") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "ósmy";
                    }
                    else if (numer.EndsWith("9") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "dziewiąty";
                    }
                    else
                    {
                        jedności = "";
                    }

                    if (numer.Length >= 2)
                    {
                        if (numer[numer.Length - 2] == '1')
                        {
                            if (numer[numer.Length - 1] == '1')
                            {
                                dziesiątki = "jedenasty";
                            }
                            else if (numer[numer.Length - 1] == '2')
                            {
                                dziesiątki = "dwunasty";
                            }
                            else if (numer[numer.Length - 1] == '3')
                            {
                                dziesiątki = "trzynasty";
                            }
                            else if (numer[numer.Length - 1] == '4')
                            {
                                dziesiątki = "czternasty";
                            }
                            else if (numer[numer.Length - 1] == '5')
                            {
                                dziesiątki = "piętnasty";
                            }
                            else if (numer[numer.Length - 1] == '6')
                            {
                                dziesiątki = "szesnasty";
                            }
                            else if (numer[numer.Length - 1] == '7')
                            {
                                dziesiątki = "siedemnasty";
                            }
                            else if (numer[numer.Length - 1] == '8')
                            {
                                dziesiątki = "osiemnasty";
                            }
                            else if (numer[numer.Length - 1] == '9')
                            {
                                dziesiątki = "dziewiętnasty";
                            }
                            else
                            {
                                dziesiątki = "dziesiąty";
                            }
                        }
                        else if (numer[numer.Length - 2] == '2')
                        {
                            dziesiątki = "dwudziesty";
                        }
                        else if (numer[numer.Length - 2] == '3')
                        {
                            dziesiątki = "trzydziesty";
                        }
                        else if (numer[numer.Length - 2] == '4')
                        {
                            dziesiątki = "czterdziesty";
                        }
                        else if (numer[numer.Length - 2] == '5')
                        {
                            dziesiątki = "pięćdziesiąty";
                        }
                        else if (numer[numer.Length - 2] == '6')
                        {
                            dziesiątki = "dześćdziesiąty";
                        }
                        else if (numer[numer.Length - 2] == '7')
                        {
                            dziesiątki = "siedemdziesiąty";
                        }
                        else if (numer[numer.Length - 2] == '8')
                        {
                            dziesiątki = "osiemdziesiąty";
                        }
                        else if (numer[numer.Length - 2] == '9')
                        {
                            dziesiątki = "dziewięćdziesiąty";
                        }
                        else
                        {
                            dziesiątki = "";
                        }
                    }
                    else
                    {
                        dziesiątki = "";
                    }

                    if (numer.Length >= 3)
                    {
                        if (numer[numer.Length - 3] == '1')
                        {
                            setek = "sto";
                        }
                        else if (numer[numer.Length - 3] == '2')
                        {
                            setek = "dwieście";
                        }
                        else if (numer[numer.Length - 3] == '3')
                        {
                            setek = "trzysta";
                        }
                        else if (numer[numer.Length - 3] == '4')
                        {
                            setek = "czterysta";
                        }
                        else if (numer[numer.Length - 3] == '5')
                        {
                            setek = "pięćset";
                        }
                        else if (numer[numer.Length - 3] == '6')
                        {
                            setek = "dześćset";
                        }
                        else if (numer[numer.Length - 3] == '7')
                        {
                            setek = "siedemset";
                        }
                        else if (numer[numer.Length - 3] == '8')
                        {
                            setek = "osiemset";
                        }
                        else if (numer[numer.Length - 3] == '9')
                        {
                            setek = "dziewięćset";
                        }
                        else
                        {
                            setek = "";
                        }
                    }
                    else
                    {
                        setek = "";
                    }
                }
                else if (PSO == "Stoi")
                {
                    if (numer.EndsWith("1") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "pierwszym";
                    }
                    else if (numer.EndsWith("2") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "drugim";
                    }
                    else if (numer.EndsWith("3") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "trzecim";
                    }
                    else if (numer.EndsWith("4") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "czwartym";
                    }
                    else if (numer.EndsWith("5") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "piątym";
                    }
                    else if (numer.EndsWith("6") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "szóstym";
                    }
                    else if (numer.EndsWith("7") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "siódmym";
                    }
                    else if (numer.EndsWith("8") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "ósmym";
                    }
                    else if (numer.EndsWith("9") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "dziewiąty";
                    }
                    else
                    {
                        jedności = "";
                    }

                    if (numer.Length >= 2)
                    {
                        if (numer[numer.Length - 2] == '1')
                        {
                            if (numer[numer.Length - 1] == '1')
                            {
                                dziesiątki = "jedenastym";
                            }
                            else if (numer[numer.Length - 1] == '2')
                            {
                                dziesiątki = "dwunastym";
                            }
                            else if (numer[numer.Length - 1] == '3')
                            {
                                dziesiątki = "trzynastym";
                            }
                            else if (numer[numer.Length - 1] == '4')
                            {
                                dziesiątki = "czternastym";
                            }
                            else if (numer[numer.Length - 1] == '5')
                            {
                                dziesiątki = "piętnastym";
                            }
                            else if (numer[numer.Length - 1] == '6')
                            {
                                dziesiątki = "szesnastym";
                            }
                            else if (numer[numer.Length - 1] == '7')
                            {
                                dziesiątki = "siedemnastym";
                            }
                            else if (numer[numer.Length - 1] == '8')
                            {
                                dziesiątki = "osiemnastym";
                            }
                            else if (numer[numer.Length - 1] == '9')
                            {
                                dziesiątki = "dziewiętnastym";
                            }
                            else
                            {
                                dziesiątki = "dziesiątym";
                            }
                        }
                        else if (numer[numer.Length - 2] == '2')
                        {
                            dziesiątki = "dwudziestym";
                        }
                        else if (numer[numer.Length - 2] == '3')
                        {
                            dziesiątki = "trzydziestym";
                        }
                        else if (numer[numer.Length - 2] == '4')
                        {
                            dziesiątki = "czterdziestym";
                        }
                        else if (numer[numer.Length - 2] == '5')
                        {
                            dziesiątki = "pięćdziesiątym";
                        }
                        else if (numer[numer.Length - 2] == '6')
                        {
                            dziesiątki = "dześćdziesiątym";
                        }
                        else if (numer[numer.Length - 2] == '7')
                        {
                            dziesiątki = "siedemdziesiątym";
                        }
                        else if (numer[numer.Length - 2] == '8')
                        {
                            dziesiątki = "osiemdziesiątym";
                        }
                        else if (numer[numer.Length - 2] == '9')
                        {
                            dziesiątki = "dziewięćdziesiątym";
                        }
                        else
                        {
                            dziesiątki = "";
                        }
                    }
                    else
                    {
                        dziesiątki = "";
                    }

                    if (numer.Length >= 3)
                    {
                        if (numer[numer.Length - 3] == '1')
                        {
                            setek = "sto";
                        }
                        else if (numer[numer.Length - 3] == '2')
                        {
                            setek = "dwieście";
                        }
                        else if (numer[numer.Length - 3] == '3')
                        {
                            setek = "trzysta";
                        }
                        else if (numer[numer.Length - 3] == '4')
                        {
                            setek = "czterysta";
                        }
                        else if (numer[numer.Length - 3] == '5')
                        {
                            setek = "pięćset";
                        }
                        else if (numer[numer.Length - 3] == '6')
                        {
                            setek = "dześćset";
                        }
                        else if (numer[numer.Length - 3] == '7')
                        {
                            setek = "siedemset";
                        }
                        else if (numer[numer.Length - 3] == '8')
                        {
                            setek = "osiemset";
                        }
                        else if (numer[numer.Length - 3] == '9')
                        {
                            setek = "dziewięćset";
                        }
                        else
                        {
                            setek = "";
                        }
                    }
                    else
                    {
                        setek = "";
                    }
                }
                else
                {
                    if (numer.EndsWith("1") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "pierwszego";
                    }
                    else if (numer.EndsWith("2") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "drugiego";
                    }
                    else if (numer.EndsWith("3") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "trzeciego";
                    }
                    else if (numer.EndsWith("4") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "czwartego";
                    }
                    else if (numer.EndsWith("5") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "piątego";
                    }
                    else if (numer.EndsWith("6") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "szóstego";
                    }
                    else if (numer.EndsWith("7") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "siódmego";
                    }
                    else if (numer.EndsWith("8") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "ósmego";
                    }
                    else if (numer.EndsWith("9") && numer[numer.Length - 2] != '1')
                    {
                        jedności = "dziewiątego";
                    }
                    else
                    {
                        jedności = "";
                    }

                    if (numer.Length >= 2)
                    {
                        if (numer[numer.Length - 2] == '1')
                        {
                            if (numer[numer.Length - 1] == '1')
                            {
                                dziesiątki = "jedenastego";
                            }
                            else if (numer[numer.Length - 1] == '2')
                            {
                                dziesiątki = "dwunastego";
                            }
                            else if (numer[numer.Length - 1] == '3')
                            {
                                dziesiątki = "trzynastego";
                            }
                            else if (numer[numer.Length - 1] == '4')
                            {
                                dziesiątki = "czternastego";
                            }
                            else if (numer[numer.Length - 1] == '5')
                            {
                                dziesiątki = "piętnastego";
                            }
                            else if (numer[numer.Length - 1] == '6')
                            {
                                dziesiątki = "szesnastego";
                            }
                            else if (numer[numer.Length - 1] == '7')
                            {
                                dziesiątki = "siedemnastego";
                            }
                            else if (numer[numer.Length - 1] == '8')
                            {
                                dziesiątki = "osiemnastego";
                            }
                            else if (numer[numer.Length - 1] == '9')
                            {
                                dziesiątki = "dziewiętnastego";
                            }
                            else
                            {
                                dziesiątki = "dziesiątego";
                            }
                        }
                        else if (numer[numer.Length - 2] == '2')
                        {
                            dziesiątki = "dwudziestego";
                        }
                        else if (numer[numer.Length - 2] == '3')
                        {
                            dziesiątki = "trzydziestego";
                        }
                        else if (numer[numer.Length - 2] == '4')
                        {
                            dziesiątki = "czterdziestego";
                        }
                        else if (numer[numer.Length - 2] == '5')
                        {
                            dziesiątki = "pięćdziesiątego";
                        }
                        else if (numer[numer.Length - 2] == '6')
                        {
                            dziesiątki = "dześćdziesiątego";
                        }
                        else if (numer[numer.Length - 2] == '7')
                        {
                            dziesiątki = "siedemdziesiątego";
                        }
                        else if (numer[numer.Length - 2] == '8')
                        {
                            dziesiątki = "osiemdziesiątego";
                        }
                        else if (numer[numer.Length - 2] == '9')
                        {
                            dziesiątki = "dziewięćdziesiątego";
                        }
                        else
                        {
                            dziesiątki = "";
                        }
                    }
                    else
                    {
                        dziesiątki = "";
                    }

                    if (numer.Length >= 3)
                    {
                        if (numer[numer.Length - 3] == '1')
                        {
                            setek = "sto";
                        }
                        else if (numer[numer.Length - 3] == '2')
                        {
                            setek = "dwieście";
                        }
                        else if (numer[numer.Length - 3] == '3')
                        {
                            setek = "trzysta";
                        }
                        else if (numer[numer.Length - 3] == '4')
                        {
                            setek = "czterysta";
                        }
                        else if (numer[numer.Length - 3] == '5')
                        {
                            setek = "pięćset";
                        }
                        else if (numer[numer.Length - 3] == '6')
                        {
                            setek = "dześćset";
                        }
                        else if (numer[numer.Length - 3] == '7')
                        {
                            setek = "siedemset";
                        }
                        else if (numer[numer.Length - 3] == '8')
                        {
                            setek = "osiemset";
                        }
                        else if (numer[numer.Length - 3] == '9')
                        {
                            setek = "dziewięćset";
                        }
                        else
                        {
                            setek = "";
                        }
                    }
                    else
                    {
                        setek = "";
                    }
                }
            }
            else
            {
                return numer;
            }

            return " " + setek + " " + dziesiątki + " " + jedności;
        }
        public static string PodmianaNumerPeronu(string peron)
        {
            return PodmianaNumerToru(peron, "Stoi");
        }
        public static string GodzinaZmiana(string godzina)
        {
            if (godzina == "00")
            {
                return "24";
            }
            else
            {
                return godzina;
            }
        }
        public static string NumerWagonu(string numer)
        {
            numer = numer.PadLeft(2, '0');
            string jedności;
            string dziesiątki;
            string setek;
            if (numer.EndsWith("1") && numer[numer.Length - 2] != '1')
            {
                jedności = "jeden";
            }
            else if (numer.EndsWith("2") && numer[numer.Length - 2] != '1')
            {
                jedności = "dwa";
            }
            else if (numer.EndsWith("3") && numer[numer.Length - 2] != '1')
            {
                jedności = "trzy";
            }
            else if (numer.EndsWith("4") && numer[numer.Length - 2] != '1')
            {
                jedności = "cztery";
            }
            else if (numer.EndsWith("5") && numer[numer.Length - 2] != '1')
            {
                jedności = "pięć";
            }
            else if (numer.EndsWith("6") && numer[numer.Length - 2] != '1')
            {
                jedności = "sześć";
            }
            else if (numer.EndsWith("7") && numer[numer.Length - 2] != '1')
            {
                jedności = "siedem";
            }
            else if (numer.EndsWith("8") && numer[numer.Length - 2] != '1')
            {
                jedności = "osiem";
            }
            else if (numer.EndsWith("9") && numer[numer.Length - 2] != '1')
            {
                jedności = "dziewięć";
            }
            else
            {
                jedności = "";
            }

            if (numer.Length >= 2)
            {
                if (numer[numer.Length - 2] == '1')
                {
                    if (numer[numer.Length - 1] == '1')
                    {
                        dziesiątki = "jedenaście";
                    }
                    else if (numer[numer.Length - 1] == '2')
                    {
                        dziesiątki = "dwanaście";
                    }
                    else if (numer[numer.Length - 1] == '3')
                    {
                        dziesiątki = "trzynaście";
                    }
                    else if (numer[numer.Length - 1] == '4')
                    {
                        dziesiątki = "czternaście";
                    }
                    else if (numer[numer.Length - 1] == '5')
                    {
                        dziesiątki = "piętnaście";
                    }
                    else if (numer[numer.Length - 1] == '6')
                    {
                        dziesiątki = "szesnaście";
                    }
                    else if (numer[numer.Length - 1] == '7')
                    {
                        dziesiątki = "siedemnaście";
                    }
                    else if (numer[numer.Length - 1] == '8')
                    {
                        dziesiątki = "osiemnaście";
                    }
                    else if (numer[numer.Length - 1] == '9')
                    {
                        dziesiątki = "dziewiętnaście";
                    }
                    else
                    {
                        dziesiątki = "dziesięć";
                    }
                }
                else if (numer[numer.Length - 2] == '2')
                {
                    dziesiątki = "dwadzieścia";
                }
                else if (numer[numer.Length - 2] == '3')
                {
                    dziesiątki = "trzydzieści";
                }
                else if (numer[numer.Length - 2] == '4')
                {
                    dziesiątki = "czterdzieści";
                }
                else if (numer[numer.Length - 2] == '5')
                {
                    dziesiątki = "pięćdziesiąt";
                }
                else if (numer[numer.Length - 2] == '6')
                {
                    dziesiątki = "dześćdziesiąt";
                }
                else if (numer[numer.Length - 2] == '7')
                {
                    dziesiątki = "siedemdziesiąt";
                }
                else if (numer[numer.Length - 2] == '8')
                {
                    dziesiątki = "osiemdziesiąt";
                }
                else if (numer[numer.Length - 2] == '9')
                {
                    dziesiątki = "dziewięćdziesiąt";
                }
                else
                {
                    dziesiątki = "";
                }
            }
            else
            {
                dziesiątki = "";
            }

            if (numer.Length >= 3)
            {
                if (numer[numer.Length - 3] == '1')
                {
                    setek = "sto";
                }
                else if (numer[numer.Length - 3] == '2')
                {
                    setek = "dwieście";
                }
                else if (numer[numer.Length - 3] == '3')
                {
                    setek = "trzysta";
                }
                else if (numer[numer.Length - 3] == '4')
                {
                    setek = "czterysta";
                }
                else if (numer[numer.Length - 3] == '5')
                {
                    setek = "pięćset";
                }
                else if (numer[numer.Length - 3] == '6')
                {
                    setek = "dześćset";
                }
                else if (numer[numer.Length - 3] == '7')
                {
                    setek = "siedemset";
                }
                else if (numer[numer.Length - 3] == '8')
                {
                    setek = "osiemset";
                }
                else if (numer[numer.Length - 3] == '9')
                {
                    setek = "dziewięćset";
                }
                else
                {
                    setek = "";
                }
            }
            else
            {
                setek = "";
            }
            return " " + setek + " " + dziesiątki + " " + jedności;
        }
    }
}
