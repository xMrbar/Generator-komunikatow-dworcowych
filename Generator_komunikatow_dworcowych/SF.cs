using System.Net;

namespace insideSF
{
    class SF
    {
        public static string KategoriaAPrzewoźnik(string kategoria, string przewoźnik)
        {
            if (przewoźnik == "PKP Intercity")
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
            else if (przewoźnik == "Koleje Mazowieckie" || przewoźnik == "Koleje Małopolskie" || przewoźnik == "Koleje Śląskie" || przewoźnik == "Koleje Wielkopolskie")
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
            else if(przewoźnik == "Koleje Dolnośląskie" || przewoźnik == "Łódzkie Koleje Aglomeracyjne")
            {
                if (kategoria == "Osobowy" || kategoria == "Os. Przyspieszony" || kategoria == "Sprinter")
                {
                    return "0";
                }
                else
                {
                    return "1";
                }
            }
            else if (przewoźnik == "Szybka Kolej Miejska" && kategoria == "Osobowy")
            {
                return "0";
            }
            else if (przewoźnik == "Polregio")
            {
                if (kategoria == "Osobowy" || kategoria == "interREGIO" || kategoria == "superREGIO" || kategoria == "Os. Przyspieszony")
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
            if (stacjaWRJ == "Końcowa" && (PSO == "Przyjedzie" || PSO == "Stoi"))
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
}
