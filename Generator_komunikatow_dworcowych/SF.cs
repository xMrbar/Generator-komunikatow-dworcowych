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
}
