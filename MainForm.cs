using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Text.RegularExpressions;

/// <summary>
/// Przestrzeń wymagana, aby poprawnie załadować moduł.
/// </summary>
namespace chxModul
{
    public partial class MainForm : Form, chxInterface
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PomocButton_Click(object sender, EventArgs e)
        {
            chxOperacje.chxPokazPomoc("chx_glowne", false);
        }

        private void DrukujButton_Click(object sender, EventArgs e)
        {
            chxOperacje.chxDrukujDokument("Tekst, który <b>chcesz</b> wydrukować.");
        }

        private void DostosujButton_Click(object sender, EventArgs e)
        {
            string Ustawienia = chxOperacje.chxDostosujDokument(this, true);

            if (Ustawienia != string.Empty)
            {
                MessageBox.Show(Ustawienia);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            chxOperacje.chxZapiszPolozenieOkna(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chxOperacje.chxWczytajPolozenieOkna(this);
        }

        private void WczytajLiczbeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chxOperacje.chxCzytajString("MojaNazwaKlucza", "Niczego jeszcze nie zapisałeś", false));
        }

        private void ZapiszTekstButton_Click(object sender, EventArgs e)
        {
            chxOperacje.chxZapiszString("MojaNazwaKlucza", "Dowolny tekst");
            MessageBox.Show("Tekst został zapisany do rejestru, teraz możesz go odczytać");
        }

        private void WyjatekButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wywołanie wyjątku spowoduje zamknięcie aplikacji, czy chcesz kontynuować?",
                "Czy na pewno wywołać wyjątek?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    object n = null;
                    int i = (int)n;
                }
                catch (Exception Ex)
                {
                    chxOperacje.chxPokazWyjatek(Ex);
                }
            }
        }

        private void UstawieniaButton_Click(object sender, EventArgs e)
        {
            int i = chxOperacje.chxPobierzUstawienia("IloscUruchomien", 5);
            MessageBox.Show(i.ToString());
        }

        private void BazaPobierzRekordButton_Click(object sender, EventArgs e)
        {
            List<string> Parametry = new List<string>();
            Parametry.Add("8");
            string Addycja = chxOperacje.chxPobierzRekord("SELECT opis FROM slownik_chemiczny_dane WHERE id=?", Parametry);
            MessageBox.Show(string.Format("Addycja to {0}", Addycja));
        }

        private void BazaPobierzKolumneButton_Click(object sender, EventArgs e)
        {
            List<string> Parametry = new List<string>();
            Parametry.Add("3");
            List<string> Lista = chxOperacje.chxPobierzKolumne("SELECT nazwa FROM tablice_chemiczne_dane LIMIT ?", Parametry);
            MessageBox.Show(string.Format("Ciekawi ludzie to {0}", string.Join(", ", Lista.ToArray())));
        }

        private void BazaPobierzWiersz_Click(object sender, EventArgs e)
        {
            List<string> Parametry = new List<string>();
            Parametry.Add("*");
            Parametry.Add("113");
            SortedList<string, string> Lista = chxOperacje.chxPobierzWiersz("SELECT ? FROM slownik_chemiczny_dane WHERE id=?", Parametry);
            MessageBox.Show(string.Format("{0} to {1}", Lista["nazwa"], Lista["opis"]));
        }

        private void BazaPobierzWszystko_Click(object sender, EventArgs e)
        {
            List<string> Parametry = new List<string>();
            Parametry.Add("*");
            Parametry.Add("kolejnosc");
            List<SortedList<string, string>> Lista = chxOperacje.chxPobierzWszystko("SELECT ? FROM uop_kolumny ORDER BY ? DESC", Parametry);
            MessageBox.Show(string.Format("{0} zapisujemy jako [{1}]", Lista[11]["pelna_nazwa"], Lista[11]["przyrostek"]));
        }

        private void UsunTagiButton_Click(object sender, EventArgs e)
        {
            string Oryginal = "<b>to</b> jest <i>przykładowy</i> <u>tekst</u>";
            string Przetworzony = chxOperacje.chxUsunTagiHTML(Oryginal);
            MessageBox.Show(string.Format("Oryginalny tekst: {0}\r\n\r\nPrzetworzony tekst: {1}", Oryginal, Przetworzony));
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://chemix.toborek.info/sdk/");
        }
    }
}
