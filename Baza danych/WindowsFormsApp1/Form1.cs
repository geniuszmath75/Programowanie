using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tworzymy połączenie z bazą danych
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from Towar in db.Towar
                    select Towar
                ).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();

            //Procedura dodawania elementów
            //1. Utwórz nowy element
            Towar towar = new Towar();
            //2. Wypełnij towar danymi
            towar.Kod = "509534834";
            towar.Nazwa = "Bułka";
            towar.StawkaVatZakupu = 23;
            towar.StawkaVatSprzedazy = 23;
            towar.Marża = 10;
            towar.CzyAktywny = true;
            //3. Dodajemy utworzonego pracownika do lokalnej kolekcji
            db.Towar.Add(towar);
            //4. Wysyłamy zmiany do bazy danych
            db.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            //Procedura modyfikacji elementu
            //1. Odzukujemy modyfikowany element
            var modified = db.Towar.Find(1);
            //2. Zmieniamy wybrane dane
            modified.Nazwa = "Wędlina";
            //3. Zapisujemy zmiany do bazy danych
            db.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            //Procedura usuwania elementu
            var deleted = db.Towar.Find(5);
            //1. Kasowanie elementu z lokalnej kolekcji
            db.Towar.Remove(deleted);
            //2. Zapisujemy zmiany w bazie
            db.SaveChanges();

        }

        private void Take_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource = 
                (
                    from Faktura in db.Faktura
                    select Faktura
                ).Take(2).ToList();
        }

        private void Skip_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from Kontrahent in db.Kontrahent
                    orderby Kontrahent.IdKontrahenta
                    select Kontrahent
                ).Skip(2).ToList();
        }

        private void Join_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            var query =
                from SposobPlatnosci in db.SposobPlatnosci
                join Faktura in db.Faktura
                on SposobPlatnosci.IdSposobuPlatnosci
                equals Faktura.IdSposobuPlatnosci
                select new
                {
                    SposobPlatnosci.Nazwa,
                    Faktura.Numer,
                    Faktura.DataWystawienia,
                    Faktura.IdKontrahenta,
                    Faktura.TerminPlatnosci,
                    SposobPlatnosci.IdSposobuPlatnosci,
                };
            dataGridView1.DataSource = query.ToList();
        }

        private void Concat_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            var query =
                (from PozycjaFaktury in db.PozycjaFaktury
                 select PozycjaFaktury.IdFaktury) 
                .Concat
                (from Faktura in db.Faktura
                 select Faktura.IdKontrahenta);

            dataGridView1.DataSource = query.ToList();
        }

        private void Union_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            var query =
                (from PozycjaFaktury in db.PozycjaFaktury
                 select PozycjaFaktury.IdFaktury)
                .Union
                (from Faktura in db.Faktura
                 select Faktura.IdKontrahenta);

            dataGridView1.DataSource = query.ToList();
        }

        private void Distinct_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from Towar in db.Towar
                    select new
                    {
                        Towar.Nazwa
                    }
                ).Distinct().ToList();
        }

        private void Except_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from Kontrahent in db.Kontrahent
                    select Kontrahent
                ).Except
                (
                    from Kontrahent in db.Kontrahent
                    where Kontrahent.IdKontrahenta == 2
                    select Kontrahent
                ).ToList();
        }

        private void Intersect_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource = 
                (
                    from Kontrahent in db.Kontrahent
                    select Kontrahent
                ).Intersect
                (
                    from Kontrahent in db.Kontrahent
                    where Kontrahent.IdKontrahenta == 2
                    select Kontrahent
                ).ToList();
        }

        private void OrderBy_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from PozycjaFaktury in db.PozycjaFaktury
                    orderby PozycjaFaktury.Cena
                    select PozycjaFaktury
                ).ToList();
        }

        private void OrderByDescending_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    from PozycjaFaktury in db.PozycjaFaktury
                    orderby PozycjaFaktury.Cena descending
                    select PozycjaFaktury
                ).ToList();
        }

        private void SelectMany_Click(object sender, EventArgs e)
        {
            FakturyEntities db = new FakturyEntities();
            dataGridView1.DataSource =
                (
                    db.Kontrahent.Where(k => k.Nazwa.Contains("sp. z.o.o.")).SelectMany(k => k.Faktura, (k, f) => 
                    new
                    {
                        k.Nazwa,
                        f.IdFaktury,
                        f.DataWystawienia
                    })
                ).ToList();
        }
    }
}
