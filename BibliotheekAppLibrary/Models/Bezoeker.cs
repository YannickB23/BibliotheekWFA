using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekAppLibrary.Models
{
    public class Bezoeker
    {
        public string Voornaam { get; private set; }
        public string Familienaam { get; private set; }
        public Bezoeker(string voornaam, string familienaam)
        {
            Voornaam = voornaam;
            Familienaam = familienaam;
        }
        public void RegistreerAlsLid(DateTime geboortedatum)
        {
            CollectieBib.Leden.Add(new Lid(Voornaam, Familienaam, geboortedatum));
        }
        public Item ZoekItem(int itemId)
        {
            return CollectieBib.ItemsInCollectie.Find(x => x.ItemId == itemId);
        }
        public Item ZoekItem(string itemTitel)
        {
            return CollectieBib.ItemsInCollectie.Find(x => x.Titel == itemTitel );
        }
    }
}
