using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listy
{
    public partial class MainPage : ContentPage
    {
        List<string> pliki = new List<string> { };
        public MainPage()
        {
            InitializeComponent();
            // elementy dla Picker stałe wypisane w kodzie c# mogą być też wstawione do xamla
            /*
            pickerPliki.ItemsSource = new string[]
            {
            "aa.txt",
            "bb.txt",
            "monotouch",
            "monorail",
            "monodevelop",
            "monotone",
            "monopoly",
            "monomodal",
            "mononucleosis"
            };
            */
            OdczytajPliki();
        }
        public void OdczytajPliki()
        {
            pliki = new List<string>();
            foreach (var file in System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)))
            {
                Console.WriteLine(Path.GetFileName(file.ToString())); // Wyświetlenie dostępnych plików w konsoli / Path.GetFileName / usuwa ścieżkę zostawiając sam plik
                pliki.Add(Path.GetFileName(file.ToString())); // budowanie listy do Picker
            }
            pickerPliki.ItemsSource = pliki; // wstawienie listy z plikami to kontrolki picker
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex != -1)
            {
                otworz_2(picker.Items[selectedIndex]);
                Console.WriteLine(picker.Items[selectedIndex]);
                nazwa.Text = picker.Items[selectedIndex];
            }
        }
        public void otworz_2(string nazwa)
        {
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nazwa);
            if (File.Exists(_filename))
            {
                editor.Text = File.ReadAllText(_filename);
            }
        }
        public void zapisz(object sender, EventArgs e)
        {
            string nazwa_pliku = nazwa.Text;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nazwa_pliku);
            pliki.Add(nazwa_pliku);
            File.WriteAllText(_filename, editor.Text);
            OdczytajPliki();
        }
        public void usun(object sender, EventArgs e)
        {
            string nazwa_pliku = nazwa.Text;
            string _filename = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), nazwa_pliku);
            if (File.Exists(_filename))
            {
                File.Delete(_filename);
            }
            editor.Text = string.Empty;
            OdczytajPliki();
        }
    }
}