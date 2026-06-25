using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class Status
    {
        public int ID {  get; set; }
        public string Name { get; set; }

        public Status()
        {
            ID = 0;
        }
        public Status (int id, string name)
        {
            ID= id;
            Name = name;
        }

        public Status(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;
            string[] val = info.Split('|');
            if (val.Length > 0)
            {
                int.TryParse(val[0].Trim(), out int parsedId);
                ID = parsedId;
            }

            if (val.Length >= 1)
            {
                this.Name = val[1].Trim();
            }
        }
    }
}
