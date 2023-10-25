using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterDataSQL
{
    public class Character
    {

        public int ID { get; set; }

        public string Character_Name { get; set; }

        public string Type { get; set; }

        public string Map_Location { get; set; }

        //hasValue
        //.value
        public bool? OriginalCharacter { get; set; }

        public bool? SwordFighter { get; set; }

        public bool? MagicUser { get; set; }



        public Character(int id, string char_Name, string type, string map, string OG_Char, string Sword, string Magic)
        {
            ID = id;
            Character_Name = char_Name;
            Type = type;
            Map_Location = map;
            OriginalCharacter = isNull(OG_Char);
            SwordFighter = isNull(Sword);
            MagicUser = isNull(Magic);
        }



        public bool isNull(string x)
        {
            bool? i;
            bool result;
            if (!bool.TryParse(x, out result))
            {
                result = false; 
                i = result;
                i = null;            
            }
            else
                return bool.Parse(x);
            return result;
           
        }

    }
}