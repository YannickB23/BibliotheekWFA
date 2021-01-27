using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BibliotheekAppLibrary.Models
{
    public class CollectieBib
    {
        private static string path = @"C:\Users\beter\source\repos\BibliotheekWFA\Files";

        public static List<Item> ItemsInCollectie = new List<Item>();
        public static List<Item> AfgevoerdeItems = new List<Item>();
        public static List<Lid> Leden = new List<Lid>();

        public static List<Lid> GetItemsInCollectie()
        {
            string fileName = "Collectie.txt";
            string filePath = $@"{path}-{fileName}";

        }
    }
}
