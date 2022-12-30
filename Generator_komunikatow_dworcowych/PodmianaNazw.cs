using GeneratorKomunikatów;
using System;

namespace PodmianaNazw
{
    class Podmiana
    {
        public static string Kategoria(string kategoriaWprowadzona, bool opóźnienie, string Przewoźnik, string nazwaSkładu, string PSO, string stacjaWRJ, bool czyCzas)
        {
            if (nazwaSkładu.Length == 0)
            {
                return StringSet.KategoriaSet(kategoriaWprowadzona, opóźnienie, Przewoźnik, PSO, stacjaWRJ, czyCzas);
            }
            else
            {
                return StringSet.KategoriaSet(kategoriaWprowadzona, opóźnienie, Przewoźnik, PSO, stacjaWRJ, czyCzas) + nazwaSkładu + " ";
            }
        }

        public static string Relacja(string początek, string koniec, string przez, string stacjaWRJ, string PSO, bool czyOpóźniony, bool czyCzas)
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
                else if (czyOpóźniony && PSO != "Przyjedzie")
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
                    if (!czyOpóźniony)
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
                        if (!czyCzas)
                        {
                            return "ze stacji " + początek + " do stacji " + koniec + ",";
                        }
                        else
                        {
                            return "ze stacji " + początek + " do stacji " + koniec + ", przez stacje: " + przez;
                        }
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

        public static string torIPeron(string PSO, string peron, string tor, bool czyOpóźniony, string stacjaWRJ, string kategoriaPociagu, bool czyCzas)
        {
            return StringSet.TorIPeronSet(PSO, peron, tor, czyOpóźniony, stacjaWRJ, kategoriaPociagu, czyCzas);
        }

        public static string torIPeronMowa(string PSO, string peron, string tor, bool czyOpóźniony, string stacjaWRJ, string kategoriaPociagu, bool czyCzas)
        {
            tor = SyntezatorNumer.PodmianaNumerToru(tor, PSO, stacjaWRJ);
            peron = SyntezatorNumer.PodmianaNumerPeronu(peron);

            return StringSet.TorIPeronSet(PSO, peron, tor, czyOpóźniony, stacjaWRJ, kategoriaPociagu, czyCzas);
        }

        public static string godzina(string godzinaOdj, string godzinaPrz, string minutaOdj, string minutaPrz, bool czyOpóźniony, string PSO, string stacjaWRJ, string czasOpóźnienia, bool czyCzas)
        {
            godzinaOdj = godzinaOdj.PadLeft(2, '0');
            godzinaPrz = godzinaPrz.PadLeft(2, '0');
            minutaOdj = minutaOdj.PadLeft(2, '0');
            minutaPrz = minutaPrz.PadLeft(2, '0');

            return StringSet.GodzinaSet(godzinaOdj, godzinaPrz, minutaOdj, minutaPrz, czyOpóźniony, PSO, stacjaWRJ, czasOpóźnienia, czyCzas);
        }

        public static string godzinaMowa(string godzinaOdj, string godzinaPrz, string minutaOdj, string minutaPrz, bool czyOpóźniony, string PSO, string stacjaWRJ, string czasOpóźnienia, bool czyCzas)
        {
            godzinaOdj = godzinaOdj.PadLeft(2, '0');
            godzinaPrz = godzinaPrz.PadLeft(2, '0');
            minutaOdj = minutaOdj.PadLeft(2, '0');
            minutaPrz = minutaPrz.PadLeft(2, '0');

            godzinaOdj = SyntezatorNumer.GodzinaZmiana(godzinaOdj);
            godzinaPrz = SyntezatorNumer.GodzinaZmiana(godzinaPrz);

            if (czyOpóźniony)
            {
                czasOpóźnienia = SyntezatorNumer.CzasOpoznienia(czasOpóźnienia);
            }


            return StringSet.GodzinaSet(godzinaOdj, godzinaPrz, minutaOdj, minutaPrz, czyOpóźniony, PSO, stacjaWRJ, czasOpóźnienia, czyCzas);
        }

        public static string Rezerwacja(bool czyRezerwacja, string Początek1, string Początek2, string Początek3, string Początek4, string Początek5, string Początek6, string Początek7, string Środek1, string Środek2, string Środek3, string Środek4, string Środek5, string Środek6, string Środek7, string Koniec1, string Koniec2, string Koniec3, string Koniec4, string Koniec5, string Koniec6, string Koniec7, string ileWagonówWSkładzie, string PSO, string stacjaWRJ)
        {
            return StringSet.RezerwacjaSet(czyRezerwacja, Początek1, Początek2, Początek3, Początek4, Początek5, Początek6, Początek7, Środek1, Środek2, Środek3, Środek4, Środek5, Środek6, Środek7, Koniec1, Koniec2, Koniec3, Koniec4, Koniec5, Koniec6, Koniec7, ileWagonówWSkładzie, PSO, stacjaWRJ);
        }

        public static string RezerwacjaMowa(bool czyRezerwacja, string Początek1, string Początek2, string Początek3, string Początek4, string Początek5, string Początek6, string Początek7, string Środek1, string Środek2, string Środek3, string Środek4, string Środek5, string Środek6, string Środek7, string Koniec1, string Koniec2, string Koniec3, string Koniec4, string Koniec5, string Koniec6, string Koniec7, string ileWagonówWSkładzie, string PSO, string stacjaWRJ)
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

            return StringSet.RezerwacjaSet(czyRezerwacja, Początek1, Początek2, Początek3, Początek4, Początek5, Początek6, Początek7, Środek1, Środek2, Środek3, Środek4, Środek5, Środek6, Środek7, Koniec1, Koniec2, Koniec3, Koniec4, Koniec5, Koniec6, Koniec7, ileWagonówWSkładzie, PSO, stacjaWRJ);
        }
    }

    class StringSet
    {
        public static string KategoriaSet(string kategoriaWprowadzona, bool opoznienie, string przewoznik, string PSO, string stacjaWRJ, bool czyCzas)
        {
            if (!opoznienie)
            {
                if (kategoriaWprowadzona == "TLK")
                {
                    return "Pociąg TLK ";
                }
                else if (kategoriaWprowadzona == "IC")
                {
                    return "Pociąg Intercity ";
                }
                else if (kategoriaWprowadzona == "EIC")
                {
                    return "Pociąg Express Intercity ";
                }
                else if (kategoriaWprowadzona == "Osobowy")
                {
                    if (przewoznik == "Polregio")
                    {
                        return "Pociąg REGIO ";
                    }
                    else if (przewoznik == "Szybka Kolej Miejska")
                    {
                        return "Pociąg SKM ";
                    }
                    else if (przewoznik == "Koleje Dolnośląskie")
                    {
                        return "Pociąg Kolei Dolnośląskich ";
                    }
                    else if (przewoznik == "Koleje Mazowieckie")
                    {
                        return "Pociąg Kolei Mazowieckich ";
                    }
                    else if (przewoznik == "Koleje Małopolskie")
                    {
                        return "Pociąg Kolei Małopolskich ";
                    }
                    else if (przewoznik == "Koleje Śląskie")
                    {
                        return "Pociąg Kolei Śląskich ";
                    }
                    else if (przewoznik == "Koleje Wielkopolskie")
                    {
                        return "Pociąg Kolei Wielkopolskich ";
                    }
                    else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                    {
                        return "Pociąg Łódzkiej Kolei Aglomeracyjnej ";
                    }
                    else
                    {
                        return "BŁĄD PODCZAS GENEROWANIA";
                    }
                }
                else if (kategoriaWprowadzona == "Os. Przyspieszony")
                {
                    if (przewoznik == "Koleje Dolnośląskie")
                    {
                        return "Przyspieszony pociąg Kolei Dolnośląskich ";
                    }
                    else if (przewoznik == "Koleje Mazowieckie")
                    {
                        return "Przyspieszony pociąg Kolei Mazowieckich ";
                    }
                    else if (przewoznik == "Koleje Małopolskie")
                    {
                        return "Przyspieszony pociąg Kolei Małopolskich ";
                    }
                    else if (przewoznik == "Koleje Śląskie")
                    {
                        return "Przyspieszony pociąg Kolei Śląskich ";
                    }
                    else if (przewoznik == "Koleje Wielkopolskie")
                    {
                        return "Przyspieszony pociąg Kolei Wielkopolskich ";
                    }
                    else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                    {
                        return "Przyspieszony pociąg Łódzkiej Kolei Aglomeracyjnej ";
                    }
                    else if (przewoznik == "Polregio")
                    {
                        return "Przyspieszony pociąg REGIO ";
                    }
                    else
                    {
                        return "BŁĄD PODCZAS GENEROWANIA";
                    }
                }
                else if (kategoriaWprowadzona == "Sprinter")
                {
                    if (przewoznik == "Koleje Dolnośląskie")
                    {
                        return "Pociąg KD Sprinter ";
                    }
                    else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                    {
                        return "Pociąg ŁKA Sprinter ";
                    }
                    else
                    {
                        return "BŁĄD PODCZAS GENEROWANIA";
                    }
                }
                else if (kategoriaWprowadzona == "interREGIO")
                {
                    return "Pociąg INTERREGIO ";
                }
                else if (kategoriaWprowadzona == "superREGIO")
                {
                    return "Pociąg SUPERREGIO ";
                }
                else
                {
                    return "NIEOBSŁUGIWANY WYJĄTEK!";
                }
            }
            else
            {
                if (PSO == "Przyjedzie")
                {
                    if (stacjaWRJ == "Początkowa")
                    {
                        if (kategoriaWprowadzona == "TLK")
                        {
                            return "Pociąg TLK ";
                        }
                        else if (kategoriaWprowadzona == "IC")
                        {
                            return "Pociąg Intercity ";
                        }
                        else if (kategoriaWprowadzona == "EIC")
                        {
                            return "Pociąg Express Intercity ";
                        }
                        else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                        {
                            if (przewoznik == "Polregio")
                            {
                                return "Pociąg regio ";
                            }
                            else if (przewoznik == "Szybka Kolej Miejska")
                            {
                                return "Pociąg SKM ";
                            }
                            else if (przewoznik == "Koleje Dolnośląskie")
                            {
                                return "Pociąg Kolei Dolnośląskich ";
                            }
                            else if (przewoznik == "Koleje Mazowieckie")
                            {
                                return "Pociąg Kolei Mazowieckich ";
                            }
                            else if (przewoznik == "Koleje Małopolskie")
                            {
                                return "Pociąg Kolei Małopolskich ";
                            }
                            else if (przewoznik == "Koleje Śląskie")
                            {
                                return "Pociąg Kolei Śląskich ";
                            }
                            else if (przewoznik == "Koleje Wielkopolskie")
                            {
                                return "Pociąg Kolei Wielkopolskich ";
                            }
                            else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                            {
                                return "Pociąg Łódzkiej Kolei Aglomeracyjnej ";
                            }
                            else
                            {
                                return "BŁĄD PODCZAS GENEROWANIA";
                            }
                        }
                        else if (kategoriaWprowadzona == "Sprinter")
                        {
                            if (przewoznik == "Koleje Dolnośląskie")
                            {
                                return "Pociąg KD Sprinter ";
                            }
                            else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                            {
                                return "Pociąg ŁKA Sprinter ";
                            }
                            else
                            {
                                return "BŁĄD PODCZAS GENEROWANIA";
                            }
                        }
                        else if (kategoriaWprowadzona == "superREGIO")
                        {
                            return "Pociąg SUPERREGIO ";
                        }
                        else if (kategoriaWprowadzona == "interREGIO")
                        {
                            return "Pociąg INTERREGIO ";
                        }
                        else
                        {
                            return "NIEOBSŁUGIWANY WYJĄTEK!";
                        }
                    }
                    else
                    {
                        if (!czyCzas)
                        {
                            if (kategoriaWprowadzona == "TLK")
                            {
                                return "UWAGA! Pociąg TLK ";
                            }
                            else if (kategoriaWprowadzona == "IC")
                            {
                                return "UWAGA! Pociąg Intercity ";
                            }
                            else if (kategoriaWprowadzona == "EIC")
                            {
                                return "UWAGA! Pociąg Express Intercity ";
                            }
                            else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                            {
                                if (przewoznik == "Polregio")
                                {
                                    return "UWAGA! Pociąg regio ";
                                }
                                else if (przewoznik == "Szybka Kolej Miejska")
                                {
                                    return "UWAGA! Pociąg SKM ";
                                }
                                else if (przewoznik == "Koleje Dolnośląskie")
                                {
                                    return "UWAGA! Pociąg Kolei Dolnośląskich ";
                                }
                                else if (przewoznik == "Koleje Mazowieckie")
                                {
                                    return "UWAGA! Pociąg Kolei Mazowieckich ";
                                }
                                else if (przewoznik == "Koleje Małopolskie")
                                {
                                    return "UWAGA! Pociąg Kolei Małopolskich ";
                                }
                                else if (przewoznik == "Koleje Śląskie")
                                {
                                    return "UWAGA! Pociąg Kolei Śląskich ";
                                }
                                else if (przewoznik == "Koleje Wielkopolskie")
                                {
                                    return "UWAGA! Pociąg Kolei Wielkopolskich ";
                                }
                                else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                                {
                                    return "UWAGA! Pociąg Łódzkiej Kolei Aglomeracyjnej ";
                                }
                                else
                                {
                                    return "BŁĄD PODCZAS GENEROWANIA";
                                }
                            }
                            else if (kategoriaWprowadzona == "Sprinter")
                            {
                                if (przewoznik == "Koleje Dolnośląskie")
                                {
                                    return "UWAGA! Pociąg KD Sprinter ";
                                }
                                else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                                {
                                    return "UWAGA! Pociąg ŁKA Sprinter ";
                                }
                                else
                                {
                                    return "BŁĄD PODCZAS GENEROWANIA";
                                }
                            }
                            else if (kategoriaWprowadzona == "superREGIO")
                            {
                                return "Uwaga! Pociąg SUPERREGIO ";
                            }
                            else if (kategoriaWprowadzona == "interREGIO")
                            {
                                return "Uwaga! Pociąg INTERREGIO ";
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
                                return "Opóźniony pociąg TLK ";
                            }
                            else if (kategoriaWprowadzona == "IC")
                            {
                                return "Opóźniony pociąg Intercity ";
                            }
                            else if (kategoriaWprowadzona == "EIC")
                            {
                                return "Opóźniony pociąg Express Intercity ";
                            }
                            else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                            {
                                if (przewoznik == "Polregio")
                                {
                                    return "Opóźniony pociąg regio ";
                                }
                                else if (przewoznik == "Szybka Kolej Miejska")
                                {
                                    return "Opóźniony pociąg SKM ";
                                }
                                else if (przewoznik == "Koleje Dolnośląskie")
                                {
                                    return "Opóźniony pociąg Kolei Dolnośląskich ";
                                }
                                else if (przewoznik == "Koleje Mazowieckie")
                                {
                                    return "Opóźniony pociąg Kolei Mazowieckich ";
                                }
                                else if (przewoznik == "Koleje Małopolskie")
                                {
                                    return "Opóźniony pociąg Kolei Małopolskich ";
                                }
                                else if (przewoznik == "Koleje Śląskie")
                                {
                                    return "Opóźniony pociąg Kolei Śląskich ";
                                }
                                else if (przewoznik == "Koleje Wielkopolskie")
                                {
                                    return "Opóźniony pociąg Kolei Wielkopolskich ";
                                }
                                else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                                {
                                    return "Opóźniony pociąg Łódzkiej Kolei Aglomeracyjnej ";
                                }
                                else
                                {
                                    return "BŁĄD PODCZAS GENEROWANIA";
                                }
                            }
                            else if (kategoriaWprowadzona == "Sprinter")
                            {
                                if (przewoznik == "Koleje Dolnośląskie")
                                {
                                    return "Opóźniony pociąg KD Sprinter ";
                                }
                                else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                                {
                                    return "Opóźniony pociąg ŁKA Sprinter ";
                                }
                                else
                                {
                                    return "BŁĄD PODCZAS GENEROWANIA";
                                }
                            }
                            else if (kategoriaWprowadzona == "superREGIO")
                            {
                                return "Opóźniony pociąg SUPERREGIO ";
                            }
                            else if (kategoriaWprowadzona == "interREGIO")
                            {
                                return "Opóźniony pociąg INTERREGIO ";
                            }
                            else
                            {
                                return "NIEOBSŁUGIWANY WYJĄTEK!";
                            }
                        }
                    }
                }
                else
                {
                    if (kategoriaWprowadzona == "TLK")
                    {
                        return "Opóźniony pociąg TLK ";
                    }
                    else if (kategoriaWprowadzona == "IC")
                    {
                        return "Opóźniony pociąg Intercity ";
                    }
                    else if (kategoriaWprowadzona == "EIC")
                    {
                        return "Opóźniony pociąg Express Intercity ";
                    }
                    else if (kategoriaWprowadzona == "Osobowy" || kategoriaWprowadzona == "Os. Przyspieszony")
                    {
                        if (przewoznik == "Polregio")
                        {
                            return "Opóźniony pociąg ";
                        }
                        else if (przewoznik == "Szybka Kolej Miejska")
                        {
                            return "Opóźniony pociąg SKM ";
                        }
                        else if (przewoznik == "Koleje Dolnośląskie")
                        {
                            return "Opóźniony pociąg Kolei Dolnośląskich ";
                        }
                        else if (przewoznik == "Koleje Mazowieckie")
                        {
                            return "Opóźniony pociąg Kolei Mazowieckich ";
                        }
                        else if (przewoznik == "Koleje Małopolskie")
                        {
                            return "Opóźniony pociąg Kolei Małopolskich ";
                        }
                        else if (przewoznik == "Koleje Śląskie")
                        {
                            return "Opóźniony pociąg Kolei Śląskich ";
                        }
                        else if (przewoznik == "Koleje Wielkopolskie")
                        {
                            return "Opóźniony pociąg Kolei Wielkopolskich ";
                        }
                        else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                        {
                            return "Opóźniony pociąg Łódzkiej Kolei Aglomeracyjnej ";
                        }
                        else
                        {
                            return "BŁĄD PODCZAS GENEROWANIA";
                        }
                    }
                    else if (kategoriaWprowadzona == "Sprinter")
                    {
                        if (przewoznik == "Koleje Dolnośląskie")
                        {
                            return "Opóźniony pociąg KD Sprinter ";
                        }
                        else if (przewoznik == "Łódzka Kolej Aglomeracyjna")
                        {
                            return "Opóźniony pociąg ŁKA Sprinter ";
                        }
                        else
                        {
                            return "BŁĄD PODCZAS GENEROWANIA";
                        }
                    }
                    else if (kategoriaWprowadzona == "interREGIO")
                    {
                        return "Opóźniony pociąg INTERREGIO ";
                    }
                    else if (kategoriaWprowadzona == "superREGIO")
                    {
                        return "Opóźniony pociąg SUPERREGIO ";
                    }
                    else
                    {
                        return "NIEOBSŁUGIWANY WYJĄTEK!";
                    }
                }
            }
        }

        public static string TorIPeronSet(string PSO, string peron, string tor, bool czyOpóźniony, string stacjaWRJ, string kategoriaPociagu, bool czyCzas)
        {
            if (czyOpóźniony && PSO == "Przyjedzie")
            {
                if (czyCzas && stacjaWRJ.Equals("Pośrednia"))
                {
                    return ", wjedzie na tor " + tor + " przy peronie " + peron + ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu";
                }
                else if(czyCzas && stacjaWRJ.Equals("Końcowa"))
                {
                    return ", wjedzie na tor " + tor + " przy peronie " + peron + ". Pociąg kończy bieg. Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu";
                }
                return "";
            }
            else if (stacjaWRJ == "Końcowa" && PSO == "Stoi")
            {
                return " wjechał na tor " + tor + " przy peronie " + peron;
            }
            else
            {
                if (PSO == "Przyjedzie")
                {
                    if ((kategoriaPociagu == "Sprinter" || kategoriaPociagu == "interREGIO") && stacjaWRJ != "Końcowa")
                    {
                        return ", wjedzie na tor " + tor + " przy peronie " + peron + ". Pociąg zatrzymuje się na niektórych stacjach";
                    }
                    return ", wjedzie na tor " + tor + " przy peronie " + peron;
                }
                else if (PSO == "Stoi")
                {
                    if (kategoriaPociagu == "Sprinter" || kategoriaPociagu == "interREGIO")
                    {
                        return ", stoi na torze " + tor + " przy peronie " + peron + ". Pociąg zatrzymuje się na niektórych stacjach";
                    }
                    return ", stoi na torze " + tor + " przy peronie " + peron;
                }
                else
                {
                    if (kategoriaPociagu == "Sprinter" || kategoriaPociagu == "interREGIO")
                    {
                        return ", odjedzie z toru " + tor + " przy peronie " + peron + ". Pociąg zatrzymuje się na niektórych stacjach";
                    }
                    return ", odjedzie z toru " + tor + " przy peronie " + peron;
                }
            }
        }

        public static string GodzinaSet(string godzinaOdj, string godzinaPrz, string minutaOdj, string minutaPrz, bool czyOpóźniony, string PSO, string stacjaWRJ, string czasOpóźnienia, bool czyCzas)
        {
            if (!czyOpóźniony)
            {
                if (stacjaWRJ == "Końcowa")
                {
                    if (PSO == "Przyjedzie")
                    {
                        return ". Pociąg kończy bieg. Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu.";
                    }
                    else
                    {
                        return ". Pociąg skończył bieg.";
                    }
                }
                else if (PSO == "Przyjedzie" && stacjaWRJ == "Pośrednia")
                {
                    return ". Prosimy zachować ostrożność i nie zbliżać się do krawędzi peronu";
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
                        return ", odjeżdżający o godzinie " + godzinaOdj + ":" + minutaOdj + " z przyczyn technicznych zostanie podstawiony z opóźnieniem około " + czasOpóźnienia + " minut";
                    }
                    else
                    {
                        return ", planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
                else if (stacjaWRJ == "Końcowa" && PSO == "Stoi")
                {
                    return "";
                }
                else
                {
                    if (PSO == "Przyjedzie")
                    {
                        if (!czyCzas)
                        {
                            return " planowy przyjazd o godzinie " + godzinaPrz + ":" + minutaPrz + ", przyjedzie z opóźnieniem około " + czasOpóźnienia + " minut. Opóźnienie może ulec zmianie. Prosimy o zwracanie uwagi na komunikaty";
                        }
                        else
                        {
                            return ", planowy przyjazd o godzinie " + godzinaPrz + ":" + minutaPrz;
                        }
                    }
                    else
                    {
                        return ", planowy odjazd o godzinie " + godzinaOdj + ":" + minutaOdj;
                    }
                }
            }
        }

        public static string RezerwacjaSet(bool czyRezerwacja, string Początek1, string Początek2, string Początek3, string Początek4, string Początek5, string Początek6, string Początek7, string Środek1, string Środek2, string Środek3, string Środek4, string Środek5, string Środek6, string Środek7, string Koniec1, string Koniec2, string Koniec3, string Koniec4, string Koniec5, string Koniec6, string Koniec7, string ileWagonówWSkładzie, string PSO, string stacjaWRJ)
        {
            if (czyRezerwacja)
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
        public static string PodmianaNumerToru(string numer, string PSO, string naszaStacja)
        {
            string jedności;
            string dziesiątki;
            string setek;

            if (numer.EndsWith("1") || numer.EndsWith("2") || numer.EndsWith("3") || numer.EndsWith("4") || numer.EndsWith("5") || numer.EndsWith("6") || numer.EndsWith("7") || numer.EndsWith("8") || numer.EndsWith("9") || numer.EndsWith("0"))
            {
                numer = numer.PadLeft(4, '0');

                if (PSO == "Przyjedzie" || (PSO == "Stoi" && naszaStacja == "Końcowa"))
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
                            dziesiątki = "sześćdziesiąty";
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
                            setek = "sześćset";
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
                        jedności = "dziewiątym";
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
                            dziesiątki = "sześćdziesiątym";
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
                            setek = "sześćset";
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
                            dziesiątki = "sześćdziesiątego";
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
                            setek = "sześćset";
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
            return PodmianaNumerToru(peron, "Stoi", "A");
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
                    dziesiątki = "sześćdziesiąt";
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
                    setek = "sześćset";
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

        public static string CzasOpoznienia(string czas)
        {
            string wynik = "";

            //cyfra setek
            if (czas.Length > 2)
            {
                if (czas[2] == '0')
                {
                    wynik += "";
                }
                else if (czas[2] == '1')
                {
                    wynik += "stu";
                }
                else if (czas[2] == '2')
                {
                    wynik += "dwustu";
                }
                else if (czas[2] == '3')
                {
                    wynik += "trzystu";
                }
                else if (czas[2] == '4')
                {
                    wynik += "czterystu";
                }
                else if (czas[2] == '5')
                {
                    wynik += "pięciuset";
                }
                else if (czas[2] == '6')
                {
                    wynik += "sześciuset";
                }
                else if (czas[2] == '7')
                {
                    wynik += "siedmiuset";
                }
                else if (czas[2] == '8')
                {
                    wynik += "ośmióset";
                }
                else
                {
                    wynik += "dziewiąciuset";
                }
            }

            //cyfra dziesiatek
            if (czas.Length > 1)
            {
                if (czas[1] == '0')
                {
                    wynik += "";
                }
                else if (czas[1] == '1')
                {
                    if (czas[0] == '0')
                    {
                        wynik += "dziesięciu";
                    }
                    else if (czas[0] == '1')
                    {
                        wynik += "jedenastu";
                    }
                    else if (czas[0] == '2')
                    {
                        wynik += "dwunastu";
                    }
                    else if (czas[0] == '3')
                    {
                        wynik += "trzynastu";
                    }
                    else if (czas[0] == '4')
                    {
                        wynik += "czternatu";
                    }
                    else if (czas[0] == '5')
                    {
                        wynik += "piętnastu";
                    }
                    else if (czas[0] == '6')
                    {
                        wynik += "szesnastu";
                    }
                    else if (czas[0] == '7')
                    {
                        wynik += "siedemnastu";
                    }
                    else if (czas[0] == '8')
                    {
                        wynik += "osiemnastu";
                    }
                    else
                    {
                        wynik += "dziewiętnastu";
                    }

                    return wynik;
                }
                else if (czas[1] == '2')
                {
                    wynik += "dwudziestu";
                }
                else if (czas[1] == '3')
                {
                    wynik += "trzydziestu";
                }
                else if (czas[1] == '4')
                {
                    wynik += "czterdziestu";
                }
                else if (czas[1] == '5')
                {
                    wynik += "pięćdziesięciu";
                }
                else if (czas[1] == '6')
                {
                    wynik += "sześćdziesięciu";
                }
                else if (czas[1] == '7')
                {
                    wynik += "siedemdziesięciu";
                }
                else if (czas[1] == '8')
                {
                    wynik += "osiemdziesięciu";
                }
                else
                {
                    wynik += "dziewiędziesięciu";
                }
            }

            //cyfra jedności
            if (true)
            {
                if (czas[0] == '0')
                {
                    wynik += "";
                }
                else if (czas[0] == '1')
                {
                    wynik += "jeden";
                }
                else if (czas[0] == '2')
                {
                    wynik += "dwóch";
                }
                else if (czas[0] == '3')
                {
                    wynik += "trzech";
                }
                else if (czas[0] == '4')
                {
                    wynik += "czterech";
                }
                else if (czas[0] == '5')
                {
                    wynik += "pięciu";
                }
                else if (czas[0] == '6')
                {
                    wynik += "sześciu";
                }
                else if (czas[0] == '7')
                {
                    wynik += "siedmiu";
                }
                else if (czas[0] == '8')
                {
                    wynik += "ośmiu";
                }
                else
                {
                    wynik += "dziewięciu";
                }
            }

            return wynik;
        }
    }
}
