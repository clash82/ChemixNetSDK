using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

/// <summary>
/// Przestrzeń wymagana, aby poprawnie załadować moduł.
/// </summary>
namespace chxModul
{
    /// <summary>
    /// Klasa za pomocą, której można uzyskać dostęp do metod zaimplementowanych w programie (niewymagana).
    /// </summary>
    public static class chxOperacje
    {
        /// <summary>
        /// Wyświetla okno pomocy dla danego kontekstu.
        /// </summary>
        /// <param name="Kontekst">Kontekst pomocy w bazie danych</param>
        /// <param name="PokazSkorowidz">Czy pokazywać również skorowidz z tematami?</param>
        public static void chxPokazPomoc(string Kontekst, bool PokazSkorowidz)
        {
            object[] arg = new object[2];
            arg[0] = Kontekst;
            arg[1] = PokazSkorowidz;
            chxPobierzMetode("chxPokazPomoc", arg);
        }

        /// <summary>
        /// Drukuje dokument w formacie HTML.
        /// </summary>
        /// <param name="Zawartosc">Treść dokumentu w formacie HTML (wyłącznie zawartość tagu BODY)</param>
        public static void chxDrukujDokument(string Zawartosc)
        {
            object[] arg = new object[1];
            arg[0] = Zawartosc;
            chxPobierzMetode("chxDrukujDokument", arg);
        }
        
        /// <summary>
        /// Wyświetla okno umożliwiające dostosowanie wyglądu dokumentu lub wczytuje same ustawienia.
        /// </summary>
        /// <param name="Forma">Forma</param>
        /// <param name="Dostosuj">Czy pokazywać okno wyboru?</param>
        public static string chxDostosujDokument(Form Forma, bool Dostosuj)
        {
            object[] arg = new object[2];
            arg[0] = Forma;
            arg[1] = Dostosuj;
            return Convert.ToString(chxPobierzMetode("chxDostosujDokument", arg));
        }
        
        /// <summary>
        /// Zapisuje położenie okna (powinna być uruchomiona podczas zamykania okna).
        /// </summary>
        /// <param name="Forma">Forma aktywnego okna</param>
        public static void chxZapiszPolozenieOkna(Form Forma)
        {
           object[] arg = new object[1];
           arg[0] = Forma;
           chxPobierzMetode("chxZapiszPolozenieOkna", arg);
        }
        
        /// <summary>
        /// Wczytuje położenie okna (powinna być uruchamiana podczas otwierania okna)
        /// </summary>
        /// <param name="Forma">Forma aktywnego okna</param>
        /// <returns></returns>
        public static void chxWczytajPolozenieOkna(Form Forma)
        {
            object[] arg = new object[1];
            arg[0] = Forma;
            chxPobierzMetode("chxWczytajPolozenieOkna", arg);
        }

        /// <summary>
        /// Wczytuje wartość typu Integer z rejestru.
        /// </summary>
        /// <param name="Nazwa">Nazwa zmiennej</param>
        /// <param name="WartoscDomyslna">Wartość domyślna zwracana w przypadku błędu lub braku</param>
        /// <param name="Utworz">Czy utworzyć wartość w przypadku jej braku?</param>
        /// <returns></returns>
        public static int chxCzytajInt(string Nazwa, int WartoscDomyslna, bool Utworz)
        {
            object[] arg = new object[4];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            arg[2] = WartoscDomyslna;
            arg[3] = Utworz;
            return Convert.ToInt32(chxPobierzMetode("chxCzytajInt", arg));
        }

        /// <summary>
        /// Wczytuje wartość typu String z rejestru.
        /// </summary>
        /// <param name="Nazwa">Nazwa zmiennej</param>
        /// <param name="WartoscDomyslna">Wartość domyślna zwracana w przypadku błędu lub braku</param>
        /// <param name="Utworz">Czy utworzyć wartość w przypadku jej braku?</param>
        /// <returns></returns>
        public static string chxCzytajString(string Nazwa, string WartoscDomyslna, bool Utworz)
        {
            object[] arg = new object[4];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            arg[2] = WartoscDomyslna;
            arg[3] = Utworz;
            return Convert.ToString(chxPobierzMetode("chxCzytajString", arg));
        }

        /// <summary>
        /// Zapisuje wartość typu Integer w rejestrze.
        /// </summary>
        /// <param name="Nazwa">Nazwa zmiennej</param>
        /// <param name="Wartosc">Wartość</param>
        public static void chxZapiszInt(string Nazwa, int Wartosc)
        {
            object[] arg = new object[3];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            arg[2] = Wartosc;
            chxPobierzMetode("chxZapiszInt", arg);
        }

        /// <summary>
        /// Zapisuje wartość typu String w rejestrze.
        /// </summary>
        /// <param name="Nazwa">Nazwa zmiennej</param>
        /// <param name="Wartosc">Wartość</param>
        public static void chxZapiszString(string Nazwa, string Wartosc)
        {
            object[] arg = new object[3];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            arg[2] = Wartosc;
            chxPobierzMetode("chxZapiszString", arg);
        }

        /// <summary>
        /// Usuwa zawartość klucza w rejestrze (wszystkie zgromadzone wpisy).
        /// </summary>
        /// <param name="Nazwa">Nazwa klucza</param>
        public static void chxWyczyscKlucz(string Nazwa)
        {
            object[] arg = new object[2];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            chxPobierzMetode("chxWyczyscKlucz", arg);
        }

        /// <summary>
        /// Pobiera całą zawartość klucza z rejestru.
        /// </summary>
        /// <param name="Nazwa">Nazwa klucza</param>
        /// <returns></returns>
        public static List<string> chxWczytajWartosciKlucza(string Nazwa)
        {
            object[] arg = new object[2];
            arg[0] = chxInformacje.chxNazwaModulu();
            arg[1] = Nazwa;
            return (List<string>)chxPobierzMetode("chxWczytajWartosciKlucza", arg);
        }

        /// <summary>
        /// Pobiera ustawienie programu Chemix .NET i zwraca zawartość jako String.
        /// </summary>
        /// <param name="Nazwa">Nazwa</param>
        /// <param name="sWartosc">Wartość domyślna zwracana w przypadku błędu lub braku</param>
        /// <returns></returns>
        public static string chxPobierzUstawienia(string Nazwa, string WartoscDomyslna)
        {
            object[] arg = new object[2];
            arg[0] = Nazwa;
            arg[1] = WartoscDomyslna;
            object oOdpowiedz = chxPobierzMetode("chxPobierzUstawieniaProgramu", arg);
            if (oOdpowiedz != null)
                return Convert.ToString(oOdpowiedz);
            else
                return "";
        }

        /// <summary>
        /// Pobiera ustawienie programu Chemix .NET i zwraca zawartość jako Integer.
        /// </summary>
        /// <param name="Nazwa">Nazwa</param>
        /// <param name="iWartosc">Wartość domyślna zwracana w przypadku błędu lub braku</param>
        /// <returns></returns>
        public static int chxPobierzUstawienia(string Nazwa, int WartoscDomyslna)
        {
            object[] arg = new object[2];
            arg[0] = Nazwa;
            arg[1] = WartoscDomyslna;
            object oOdpowiedz = chxPobierzMetode("chxPobierzUstawieniaProgramu", arg);
            if (oOdpowiedz != null)
                return Convert.ToInt32(oOdpowiedz);
            else
                return -1;
        }

        /// <summary>
        /// Wykonuje zapytanie do bazy danych inne niż SELECT.
        /// </summary>
        /// <param name="Zapytanie">Zapytanie SQL</param>
        /// <param name="Parametry">Lista parametrów</param>
        /// <returns></returns>
        public static Int64 chxZapytanie(string Zapytanie, List<string> Parametry)
        {
            object[] arg = new object[2];
            arg[0] = Zapytanie;
            arg[1] = Parametry;
            return Convert.ToInt64(chxPobierzMetode("chxZapytanie", arg));
        }

        /// <summary>
        /// Pobiera pojedyńczy rekord z bazy danych.
        /// </summary>
        /// <param name="Zapytanie">Zapytanie SQL</param>
        /// <param name="Parametry">Lista parametrów</param>
        /// <returns></returns>
        public static string chxPobierzRekord(string Zapytanie, List<string> Parametry)
        {            
            object[] arg = new object[2];
            arg[0] = Zapytanie;
            arg[1] = Parametry;
            return Convert.ToString(chxPobierzMetode("chxPobierzRekord", arg));
        }

        /// <summary>
        /// Pobiera kolumnę z bazy danych.
        /// </summary>
        /// <param name="Zapytanie">Zapytanie SQL</param>
        /// <param name="Parametry">Lista parametrów</param>
        /// <returns></returns>
        public static List<string> chxPobierzKolumne(string Zapytanie, List<string> Parametry)
        {
            object[] arg = new object[2];
            arg[0] = Zapytanie;
            arg[1] = Parametry;
            return (List<string>)chxPobierzMetode("chxPobierzKolumne", arg);
        }

        /// <summary>
        /// Pobiera cały wiersz z bazy danych.
        /// </summary>
        /// <param name="Zapytanie">Zapytanie SQL</param>
        /// <param name="Parametry">Lista parametrów</param>
        /// <returns></returns>
        public static SortedList<string, string> chxPobierzWiersz(string Zapytanie, List<string> Parametry)
        {
            object[] arg = new object[2];
            arg[0] = Zapytanie;
            arg[1] = Parametry;
            return (SortedList<string, string>)(chxPobierzMetode("chxPobierzWiersz", arg));
        }

        /// <summary>
        /// Pobiera wszystkie kolumny z bazy danych.
        /// </summary>
        /// <param name="Zapytanie">Zapytanie SQL</param>
        /// <param name="Parametry">Lista parametrów</param>
        /// <returns></returns>
        public static List<SortedList<string, string>> chxPobierzWszystko(string Zapytanie, List<string> Parametry)
        {
            object[] arg = new object[2];
            arg[0] = Zapytanie;
            arg[1] = Parametry;
            return (List<SortedList<string, string>>)(chxPobierzMetode("chxPobierzWszystko", arg));
        }

        /// <summary>
        /// Wyświetla okno raportujące wyjątek programu.
        /// </summary>
        /// <param name="Wyjatek">Wyjątek, który wystąpił</param>
        public static void chxPokazWyjatek(Exception Wyjatek)
        {
            object[] arg = new object[1];
            arg[0] = Wyjatek;
            chxPobierzMetode("chxPokazWyjatek", arg);
        }

        /// <summary>
        /// Usuwa wszystkie tagi HTML z ciągu.
        /// </summary>
        /// <param name="Zawartosc">Tekst w formacie HTML</param>
        /// <returns></returns>
        public static string chxUsunTagiHTML(string Zawartosc)
        {
            object[] arg = new object[1];
            arg[0] = Zawartosc;
            return chxPobierzMetode("chxUsunTagiHTML", arg).ToString();
        }

        /// <summary>
        /// Dodaje obrazy do dokumenty HTML zakodowane w BASE64 i pobrane z bazy danych.
        /// </summary>
        /// <param name="Zawartosc">Tekst w formacie HTML</param>
        /// <param name="Tabela">Tabela w bazie danych, z której będą pobierane obrazy</param>
        /// <param name="Ramka">Czy rysować ramkę wokół zdjęcia?</param>
        /// <returns></returns>
        public static string chxParsujZmienne(string Zawartosc, string Tabela, bool Ramka)
        {
            object[] arg = new object[3];
            arg[0] = Zawartosc;
            arg[1] = Tabela;
            arg[2] = Ramka;
            return chxPobierzMetode("chxParsujZmienne", arg).ToString();
        }

        /// <summary>
        /// Pobiera metodę statyczną.
        /// </summary>
        /// <param name="Metoda">Nazwa metody statycznej zaimplementowanej w programie</param>
        /// <param name="Argumenty">Lista argumentów</param>
        /// <returns></returns>
        private static object chxPobierzMetode(string Metoda, object[] Argumenty)
        {
            try
            {
                Assembly Asm = Assembly.Load("Chemix");
                Type Typ = Asm.GetType("Chemix.chxOperacje");
                if (Typ != null)
                {
                    MethodInfo asmMetoda = Typ.GetMethod(Metoda);
                    if (asmMetoda != null)
                        return asmMetoda.Invoke(null, Argumenty);
                }
                return "-1";
            }
            catch (Exception eW)
            {
                MessageBox.Show("Wystąpił błąd podczas dostępu do metody zaimplementowanej w programie. Prawdopodobnie ten moduł został napisany dla starszej wersji programu niż obecna. Wyjątek błędu:\n\n"+eW.ToString(), "Błąd wewnętrzny modułu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
