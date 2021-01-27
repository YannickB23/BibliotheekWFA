using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekAppLibrary.Models
{
    public class Lid : Bezoeker
    {
        public DateTime Geboortedatum { get; set; }
        public List<Item> UitleenHistoriek { get; set; }
        public List<Item> ItemsUitgeleend { get; set; }
        public List<Item> Reservatie { get; set; }
        public Lid(string voornaam, string familienaam, DateTime geboortedatum) : base(voornaam, familienaam)
        {
            Geboortedatum = geboortedatum;
        }
        public Lid(string voornaam, string familienaam, DateTime geboortedatum, List<Item> uitleenhistoriek, List<Item> itemsUitgeleend, List<Item> reservatie) : base(voornaam, familienaam)
        {
            Geboortedatum = geboortedatum;
            UitleenHistoriek = uitleenhistoriek;
            ItemsUitgeleend = itemsUitgeleend;
            Reservatie = reservatie;
        }
        public void Uitlenen(Item item)
        {
            if (ItemsUitgeleend.Count < 5)
            {
                ItemsUitgeleend.Add(item);
            }
        }
        public void Reserveren(Item item)
        {
            if (Reservatie.Count < 5)
            {
                Reservatie.Add(item);
            }
        }
        public void Terugbrengen(Item item)
        {
            ItemsUitgeleend.Remove(item);
            UitleenHistoriek.Add(item);
        }
        public override string ToString()
        {
            return $"{GetType().Name}/t{Voornaam}/t{Familienaam}/t{Geboortedatum.ToShortDateString()}";
        }
    }
}
