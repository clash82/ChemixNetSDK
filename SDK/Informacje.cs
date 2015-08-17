/// <summary>
/// Przestrzeń wymagana, aby poprawnie załadować moduł.
/// </summary>
namespace chxModul
{
    /// <summary>
    /// Klasa zawierająca podstawowe informacje na temat modułu (wymagana).
    /// </summary>
    sealed class chxInformacje
    {
        /// <summary>
        /// Nazwa modułu wyświetlana na liście.
        /// </summary>
        public static string chxNazwaModulu()
        {
            return "Mój pierwszy moduł";
        }

        /// <summary>
        /// Wersja modułu.
        /// </summary>
        public static string chxWersjaModulu()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// Informacje na temat autora modułu.
        /// </summary>
        public static string chxAutorModulu()
        {
            return "Rafał Toborek";
        }

        /// <summary>
        /// Krótki opis modułu.
        /// </summary>
        public static string chxOpisModulu()
        {
            return "To jest mój pierwszy moduł.";
        }

        /// <summary>
        /// Strona internetowa modułu.
        /// </summary>
        public static string chxAdresModulu()
        {
            return "http://chemix.toborek.info";
        }

        /// <summary>
        /// Grupa, do której przypisano moduł.
        /// </summary>
        public static string chxGrupaModulu()
        {
            return "Moja grupa";
        }
    }
}
