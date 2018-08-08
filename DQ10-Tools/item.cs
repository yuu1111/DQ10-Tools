using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10_Tools
{
    public class Item
    {
        public string itemName;        //名前
        public int itemID;             //アイテムID
        public ItemType itemType;      //アイテムの種類

        //アイテムタイプも同じくenum      
        public enum ItemType
        {
            Weapon,
            Aromor,
            Stone
        }
        //ここでリスト化時に渡す引数をあてがいます   
        public Item(string name, int id ,ItemType type)
        {
            itemName = name;
            itemID = id;
            itemType = type;
        }

    }
}