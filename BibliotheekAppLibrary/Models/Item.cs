using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotheekAppLibrary.Models
{
    public enum SoortItem { Boek, Stripverhaal, DVD, CD }
    public class Item
    {
        public SoortItem SoortItem { get; set; }
        public int ItemId { get; set; }
        public string Titel { get; set; }
        public string Creator { get; set; }
        public int Jaartal { get; set; }
        public bool Uitgeleend { get; set; }
        public bool Afgevoerd { get; set; }
        public Item(int itemId)
        {
            ItemId = itemId;
            itemId++;
        }
        public Item(string titel, SoortItem soortItem,string creator, int jaartal,bool uitgeleend, bool afgevoerd)
        {
            Titel = titel;
            SoortItem = soortItem;
            Jaartal = jaartal;
            Creator = creator;
            Uitgeleend = uitgeleend;
            Afgevoerd = afgevoerd;
        }
        public string Beschikbaarheid()
        {
            if (Uitgeleend)
            {
                return "Item is uitgeleend!";
            }
            else if (Afgevoerd)
            {
                return "Item is afgevoerd";
            }
                return "Item is beschikbaar";
        }
        public override string ToString()
        {
            return $"{ItemId}/t{Titel}/t{SoortItem}/t{Creator}/t{Jaartal}/t{Beschikbaarheid()}";
        }
    }
}
