using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekAppLibrary.Models
{
    public class Medewerker : Lid
    {
        public Medewerker(string voornaam, string achternaam, DateTime geboortedatum) : base(voornaam, achternaam, geboortedatum){}

        public void PromoveerLeden(Lid lid)
        {
            CollectieBib.Leden.Remove(lid);
            CollectieBib.Leden.Add(new Medewerker(lid.Voornaam, lid.Familienaam, lid.Geboortedatum));
        }
        public void VoerItemAf(Item item)
        {
            item.Afgevoerd = true;
            CollectieBib.AfgevoerdeItems.Add(item);
            CollectieBib.ItemsInCollectie.Remove(item);
        }
        public void VoegItemToe(Item item)
        {
            item.SoortItem = 0;
            item.ItemId = 0;
            item.Titel = null;
            item.Creator = null;
            item.Jaartal = 0;
            CollectieBib.ItemsInCollectie.Add(item);
        }
    }
}
