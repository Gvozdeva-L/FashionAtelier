using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class Position
    {
        public int ID {get; set; }
        public string Name { get; set; }
        public Position() 
        { 
            ID = 0;
        }

        public Position (int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Position(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;
            string[] val = info.Split('|');
            if (val.Length > 0)
            {
                //ААААААААААААААААААААААААА
                int.TryParse(val[0].Trim(), out int parsedId);
                ID = parsedId;
            }

            if (val.Length >= 1)
            {
                Name = val[1].Trim();
            }
        }


    }
}


