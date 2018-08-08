using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10_Tools
{
    class ItemDataBase
    {
        public static List<Item> Material = new List<Item>();
        public void AddItem()
        {

            Material.Add(new Item("どうこうせき", 0, Item.ItemType.Stone));

        }
    }
}