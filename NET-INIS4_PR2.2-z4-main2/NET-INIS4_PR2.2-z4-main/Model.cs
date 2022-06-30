using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_INIS4_PR2._2_z4
{
    class Model
    {
        /*Prawdopodobnie brakuje jawnego pola z listą, właściwości jawnie zaimplementowanej i notyfikacji o zmianie*/
        public LinkedList<Osoba> Lista { get; set; } = new LinkedList<Osoba>(new Osoba[] {
            new Osoba() {
                Tytuł = "Szybcy i wściekli 5",
                Reżyser = "Justin Lin",
                Wydawca = "Christian Wagner",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("29.04.2011")
            },
            new Osoba() {
                Tytuł = "Obcy 3",
                Reżyser = "David Fincher",
                Wydawca = "Vesper",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("22.05.1992")
            },
            new Osoba() {
                Tytuł = "Uncharted",
                Reżyser = " Ruben Fleischer",
                Wydawca = "Sony",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("18.02.2022")
            },
            new Osoba() {
                Tytuł = "Kiler",
                Reżyser = "Juliusz Machulski",
                Wydawca = "Leoful",
                Nośnik = "DVD",
                DataNagrania = DateTime.Parse("17.11.1997")
            },
        });

        internal void OtwórzSzczegóły(Osoba wybrany)
        {
            Szczegóły szczegóły = new Szczegóły(wybrany);
            szczegóły.Show();
        }
        internal void DodajNowy()
        {
            Osoba nowa = new Osoba();
            Lista.AddLast(nowa);
            Szczegóły szczegóły = new Szczegóły(nowa);
            szczegóły.Show();
            /*aktualizowanie widoku samej listy*/
        }
    }
}
