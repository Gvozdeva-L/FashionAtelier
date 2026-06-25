using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studio
{
    public class ClassService
    {
        private int id;
        private double? maxprice;
       private double minprice;
        public int ID { get; set; }
       public string Discription { get; set; }
        public string Name { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Timetodo { get; set; }

        public double? Maxprice { get; set; }
        public double Minprice { get; set; }

        public string Material { get; set; }

        public ClassService() { }

        public ClassService(int id,string name, int categoryId, string timetodo, double? maxprice, double minprice, string material, string discription = "")
        {
            this.id = id;
            Name = name;
            CategoryId = categoryId;
            Timetodo = timetodo;
            Maxprice = maxprice;
            Minprice = minprice;
            Material = material;
            Discription = discription;
        }
        #region LoadInfoFromDB
        #region Price
        private void LoadPrice()
        {
            List<Price> prices = new List<Price>();
            string sql ="SELECT p.id_price, p.min_price, p.max_price " + "FROM Price p WHERE p.service_id = " + this.id;


            ClassDataBase db = new ClassDataBase();
            db.Execute("studio", sql, ref prices);

            if (prices.Count > 0)
            {
                this.Maxprice = prices[0].Maxprise;
                this.Minprice = prices[0].Minprise;
            }



        }


        //  властивості  для відображення в таблиці 
        public string DisplayMinPrice
        {
            get
            {
                return Minprice > 0 ? Minprice.ToString() + " грн" : "-";
            }
        }

        public string DisplayMaxPrice
        {
            get
            {
                // Якщо maxprice порожній (null) або дорівнює 0
                if (Maxprice == null || Maxprice == 0) return "Договірна";
                return Maxprice.ToString() + " грн";
            }
        }
        #endregion
        private string LoadCategory()
        {
            List<Category> categories = new List<Category>();

            string sql = "SELECT ca.id_category, ca.name " +"FROM Category ca " + "JOIN Service s ON ca.id_category = s.category_id " +"WHERE s.id_service = " + this.id;

            ClassDataBase db = new ClassDataBase();
            db.Execute("studio", sql, ref categories);
            if (categories.Count > 0)
            {
                this.CategoryName = categories[0].Name;
                this.CategoryId = categories[0].Id;
                return categories[0].Name;
            }

            return  "";
        }


        private string LoadMaterial()
        {
            List<ClassMaterials> materials = new List<ClassMaterials>();
            string result = "";

            string sql =
                "SELECT m.id_material, m.name, m.unit, m.quantity, m.cost " +"FROM Material m " + "JOIN ServiceMaterial sm ON m.id_material = sm.material_id " +"WHERE sm.service_id = " + this.id; 

            ClassDataBase db = new ClassDataBase();
            db.Execute("studio", sql, ref materials);

            foreach (ClassMaterials m in materials)
                result += m.Name + ", ";

            if (result.Length > 0)
                result = result.Remove(result.Length - 2);

            return result;
        }

        #endregion
        public ClassService(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;

            string[] values = info.Split('|');

            int.TryParse(values[0], out int tempId);
            this.id = tempId;
            this.ID = tempId;
            Name = values[1];
            Timetodo = values[2];

            if (values.Length > 4) 
                Discription = values[4];
            else
                Discription = "";

            LoadPrice();
            LoadCategory();
            Material = LoadMaterial();
        }
    }
}
