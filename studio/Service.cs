using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace studio
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        ClassDataBase db = new ClassDataBase();
        public List <ClassService> services = new List <ClassService>();
        public List <Category> categories = new List <Category>();
        public List <ClassMaterials> materials = new List <ClassMaterials>();

        

        #region another page& close
        private void Service_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderService_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders frm = new Orders();
            frm.ShowDialog();
        }

        private void btnMaterialService_Click(object sender, EventArgs e)
        {
                this.Hide();
                Materials frm = new Materials();
                frm.ShowDialog();
        }

        private void btnStuffService_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff frm = new Staff();
            frm.ShowDialog();
        }

        #endregion
        #region Valid & Exist
        bool ExistService()
        {
            var service = services.Where(s => s.Name == tbNameService.Text.Trim() && s.CategoryName == cbCategoryService.Text.Trim() && s.Material== clbMaterialService.Text).Select (p=>p).ToList();
            if (service.Count > 0) return true;
            return false;
        }

        bool IsValide()
        {
            if (string.IsNullOrWhiteSpace(tbNameService.Text))
            {
                MessageBox.Show("Введіть назву!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (string.IsNullOrWhiteSpace(tbMinCostService.Text))
            {
                MessageBox.Show("Введіть мінімальну ціну!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (cbCategoryService.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть категорію!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (clbMaterialService.CheckedItems.Count == 0)
            {
                 MessageBox.Show("Оберіть матеріал який необхідний для цієї послгуи!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return false;
            }


            return true; 
        }
        #endregion
        void LoadData()
        {
            try
            {
                services.Clear();
                string sql = "SELECT id_service, name, execution_time, category_id, description FROM Service";

                db.Execute<ClassService>("studio", sql, ref services);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                string sql = "select id_category, name from Category";
                db.Execute<Category>("studio", sql, ref categories);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                string sql = "select id_material, name, unit, quantity, cost from Material";
                db.Execute<ClassMaterials>("studio", sql, ref materials);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }


        #region ShoData to Controls

        void ShowMaterial (ref List<ClassMaterials> materials, ref CheckedListBox checkedListBox)
        {
            checkedListBox.Items.Clear();
            if (materials.Count > 0)
            {
                foreach (ClassMaterials mat in materials)
                {
                    checkedListBox.Items.Add(mat.Name);
                }
            }
        }

        void ShowCategory(ref List<Category> categories, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (categories != null)
            {
                foreach (Category c in categories)
                {
                    comboBox.Items.Add(c.Name);
                }
            }
        }

        void ShowService(ref List <ClassService> services, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (ClassService service in services)
            {
                dataGrid.Rows.Add(service.Name, service.CategoryName, service.Timetodo, service.DisplayMinPrice, service.DisplayMaxPrice, service.Material, service.Discription);
            }
        }

        void ShowData()
        {
            ShowService(ref services, ref dgvService);
            ShowCategory(ref categories, ref cbCategoryService);
            ShowMaterial(ref materials, ref clbMaterialService);
        }
        #endregion
        private void Service_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }
        #region Insert info
        string SelectMaterials(ref CheckedListBox checkedList)
        {
            if (checkedList.CheckedItems.Count == 0) return "";

            string selectedMaterials = "";
            foreach (var item in checkedList.CheckedItems)
            {
                selectedMaterials += item.ToString() + ",";
            }
            return selectedMaterials.TrimEnd(',');
        }
        ClassService InsertSerise(ref ClassService classService)
        {
            if (classService == null) return null;

            string r = "INSERT INTO Service (name, category_id, execution_time, description) values ('" + classService.Name + "' ,'" + classService.CategoryId + "' ,'" +
            classService.Timetodo + "' ,'" + classService.Discription + "' )";
            db.ExecuteNonQuery("studio", r);


            object lastId = db.ExecuteScalar("studio", "SELECT last_insert_rowid();");
            int generatedId = Convert.ToInt32(lastId);

            // Подготовка цен
            string minP = classService.Minprice.ToString().Replace(',', '.');
            string maxP = (classService.Maxprice.HasValue) ? classService.Maxprice.Value.ToString().Replace(',', '.') : "NULL";

            string sqlPrice = "INSERT INTO Price (service_id, min_price, max_price, currency) VALUES (" + generatedId + ", " + minP + ", " + maxP + ", 'грн')";
            db.ExecuteNonQuery("studio", sqlPrice);

            //материал
            ClassService newService = classService;
            newService.ID = generatedId;

            string selectmaterials = SelectMaterials(ref clbMaterialService);
            newService.Material = selectmaterials;

            if (!string.IsNullOrEmpty(selectmaterials))
            {
                string[] varArray = selectmaterials.Split(new char[] { ',' });
                foreach (string mName in varArray)
                {
                    string trimmedName = mName.Trim();
                    var material = materials.FirstOrDefault(p => p.Name == trimmedName);
                    if (material != null)
                    {
                        string sqlMat = "INSERT INTO ServiceMaterial (service_id, material_id) VALUES (" +
                            newService.ID + ", " + material.ID + ")";
                        db.ExecuteNonQuery("studio", sqlMat);
                    }
                }
            }
            return newService;
        }
        //ClassService InsertSerise(ref ClassService classService)
        //{
        //    if (classService == null) return null;
        //    List<ClassService> services = new List<ClassService>();
        //    string r = "INSERT INTO Service (name, category_id, execution_time, description) values ('";
        //    r += classService.Name + "' ,'" + classService.CategoryId + "' ,'" + classService.Timetodo + "' ,'" + classService.Discription + "' )";
        //    db.ExecuteNonQuery("studio", r);

        //    r = "SELECT id_service, name, execution_time, category_id, description FROM Service WHERE name = '" +
        //        classService.Name + "' AND execution_time = '" + classService.Timetodo + "'";
        //    db.Execute("studio", r, ref services);

        //    ClassService newService = services[0];

        //    string minP = classService.Minprice.ToString().Replace(',', '.'); // Для SQL крапка важлива

        //    string maxP = (classService.Maxprice.HasValue) ? classService.Maxprice.ToString().Replace(',', '.') : "NULL";

        //    string sqlPrice = "INSERT INTO Price (id_price, service_id, min_price, max_price, currency)   VALUES (" + newService.ID + ", " + maxP + ", " + minP + ", "+ "'грн' "+ ")";

        //    db.ExecuteNonQuery("studio", sqlPrice);



        //    string selectmaterials = SelectMaterials(ref clbMaterialService);
        //    newService.Material = selectmaterials;

        //    if (selectmaterials.Length > 0)
        //    {
        //        string[] var = selectmaterials.Split(new char[] { ',' });
        //        foreach (string var2 in var)
        //        { 
        //            int material_id = materials.Where(p=>p.Name ==  var2).Select(p=>p.ID).First();
        //            r = "INSERT INTO ServiceMaterial (service_id, material_id) VALUES (" +
        //            newService.ID.ToString() + ", " + material_id.ToString() + ")";
        //            db.ExecuteNonQuery("studio",r);
        //        }
        //    }
        //    return newService;

        //}
        #endregion

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                if (!ExistService())
                {
                    ClassService service = new ClassService();
                    service.Name = tbNameService.Text.Trim();
                    service.Timetodo = tbTimeService.Text.Trim();
                    service.Discription = tbDescribeService.Text.Trim();

                    var selectedCat = categories.FirstOrDefault(c => c.Name == cbCategoryService.Text);
                    if (selectedCat != null)
                        service.CategoryId = selectedCat.Id;

                    //  ціни
                    double.TryParse(tbMinCostService.Text.Replace('.', ','), out double minP);
                    service.Minprice = minP;

                    if (!string.IsNullOrEmpty(tbMaxCostService.Text))
                    {
                        double.TryParse(tbMaxCostService.Text.Replace('.', ','), out double maxP);
                        service.Maxprice = maxP;
                    }

                    ClassService currentService = InsertSerise(ref service);

                    if (currentService != null)
                    {
                        LoadData();
                        ShowData();
                        MessageBox.Show("Послугу успішно додано!");
                    }
                }
                else { MessageBox.Show("Така послуга вже існує!"); }
            }
        }

        private void btnCleanOrder_Click(object sender, EventArgs e)
        {
            tbNameService.Text = "";
            tbTimeService.Text = "";
            tbMaxCostService.Text = "";
            tbMinCostService.Text = "";
            cbCategoryService.SelectedIndex = -1;
            for (int i = 0; i < clbMaterialService.Items.Count; i++)
            {
                clbMaterialService.SetItemChecked(i, false); // Знімає галочку з кожного елемента
            }
        }

        private void btnServiceService_Click(object sender, EventArgs e)
        {

        }
    }
}
