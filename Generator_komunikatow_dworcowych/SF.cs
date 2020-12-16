using System.Net;

namespace insideSF
{
    class SF
    {
        public static string KategoriaAPrzewoźnik(string kategoria, string przewoźnik)
        {
            if (przewoźnik == "PKP INTERCITY")
            {
                if (kategoria == "TLK" || kategoria == "IC" || kategoria == "EIC")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else if (przewoźnik == "KD" || przewoźnik == "KM" || przewoźnik == "KMŁ" || przewoźnik == "KŚ" || przewoźnik == "KW" || przewoźnik == "ŁKA" )
            {
                if (kategoria == "Osobowy" || kategoria == "Os. Przyspieszony")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else if (przewoźnik == "SKM" && kategoria == "Osobowy")
            {
                return "0";
            }
            else if (przewoźnik == "POLREGIO")
            {
                if (kategoria == "Osobowy" || kategoria == "interREGIO" || kategoria == "superREGIO")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else
            {
                return "1";
            }
        }
        public static string koniecTylkoPrzyjazd(string stacjaWRJ, string PSO)
        {
            if (stacjaWRJ == "Końcowa" && PSO == "Przyjedzie")
            {
                return "0";
            }
            else if (stacjaWRJ == "Początkowa" || stacjaWRJ == "Pośrednia")
            {
                return "0";
            }
            else
            {
                return "1";
            }
        }
    }

    class Actual
    {
        public static void Aktualizacje()
        {
            const string strona = "https://api.github.com/repos/xMrbar/Generator-komunikatow-dworcowych/releases/latest";
            const string wersja = "0.5.1a";

            var request = HttpWebRequest.CreateHttp(strona);
            request.Method = WebRequestMethods.Http.Get;
            request.Accept = "application/json";
        }
    }
}
