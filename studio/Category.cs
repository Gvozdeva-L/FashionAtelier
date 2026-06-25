using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Category(string info)
        {
            if (!string.IsNullOrEmpty(info))
            {
                {
                    string[] val = info.Split('|');

                    if (val.Length > 0)
                    {
                        
                        int.TryParse(val[0].Trim(), out int tempId);
                        Id = tempId;
                    }

                    if (val.Length > 1)
                    {
                        Name = val[1].Trim();
                    }
                    else if (val.Length == 1 && Id == 0)
                    {
                        //  запасний варіант 
                        Name = val[0].Trim();
                    }
                }
            }
        }

    }

}
