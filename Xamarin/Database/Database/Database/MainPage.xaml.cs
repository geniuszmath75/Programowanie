using SQLite;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Subscribed { get; set; }
    }
    public partial class Baza : ContentPage
    {
        private readonly SQLiteAsyncConnection _database; // obiekt odpowiedzialny za połączenie z bazą danych
        public Baza()
        {
            InitializeComponent();
            _database = new
            SQLiteAsyncConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"people.db3")); // incjalizacja obiektu ścieżka + nazwa folderu

            Console.WriteLine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)));
            //Miejsce zapisu bazy – wyświetli lokalizację pliku z bazą
            
            _database.CreateTableAsync<Person>(); // Tworzenie tabeli Person
        }

        protected override async void OnAppearing() // funkcja uruchamia się po każdej zmianie widoku
        {
            base.OnAppearing();
            collectionView.ItemsSource = await GetPeopleAsync(); // pobranie danych do obiektu colectionView
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameEntry.Text))
            {
                await SavePersonAsync(new Person
                {
                    Name = nameEntry.Text,
                    Subscribed = subscribed.IsChecked
                });
                nameEntry.Text = string.Empty;
                subscribed.IsChecked = false;
                collectionView.ItemsSource = await GetPeopleAsync(); // pobranie danych do obiektu colectionView
            }
        }
        public Task<List<Person>> GetPeopleAsync() // Uruchomiemie zadania odczytu
        {
            return _database.Table<Person>().ToListAsync();
        }
        public Task<int> SavePersonAsync(Person person) // Uruchomiemie zadania zapisu
        {
            return _database.InsertAsync(person);
        }

    }
}
