using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class ClassMaterials
    {
        public int ID { get; set; } // Додаємо ID
        public string Name { get; set; }
        public string Measurement { get; set; }
        public int Count { get; set; }
        public string Cost { get; set; }

        public ClassMaterials()
        {
            Count = 0;
        }

        public ClassMaterials (int id, string name, string measurement, int count, string cost)
        {
            ID = id;
            Name = name;
            Measurement = measurement;
            Count = count;
            Cost = cost;
        }
        public ClassMaterials(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;

            string[] val = info.Split('|');

            if (val.Length >= 1)
            {
                int.TryParse(val[0].Trim(), out int id);
                ID = id;
            }

            if (val.Length >= 2) Name = val[1].Trim();
            if (val.Length >= 3) Measurement = val[2].Trim();

            if (val.Length >= 4)
            {
                int.TryParse(val[3].Trim(), out int count);
                Count = count;
            }

            if (val.Length >= 5) Cost = val[4].Trim();
        }
       

    }

}


