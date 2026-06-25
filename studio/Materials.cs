using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studio
{
    public partial class Materials : Form
    {
        public Materials()
        {
            InitializeComponent();
        }
        public List<ClassMaterials> materials = new List<ClassMaterials>();
        ClassDataBase db = new ClassDataBase();
        #region valide & exist
        bool ExistMaterial()
        {
            var matrial = materials.Where(s => s.Name == tbNameMaterial.Text.Trim() && s.Measurement == tbVimirMaterial.Text.Trim()).Select(s => s).ToList();
            if (matrial.Count > 0) return true;
            return false;
        }
        bool IsValide()
        {
            if (tbNameMaterial.Text.Trim() == "")
            {
                MessageBox.Show("Поля для назви матеріалу обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }
            
            if (tbCountMaterial.Text.Trim() == "") 
            {
                MessageBox.Show("Поля для кількості матеріалу обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } 
                

             if (tbVimirMaterial.Text.Trim() == "") 
             {
                MessageBox.Show("Поля для одиниці виміру матеріалу обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return false;

             }
            
             if (tbCostMaterial.Text.Trim() == "")
             {
                MessageBox.Show("Поля для ціни матеріалу обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                return false;
             }

            return true;
        }
        #endregion
        #region close&another_pages
        private void Materials_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnOrderMaterial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders frm = new Orders();
            frm.ShowDialog();

        }

        private void btnStuffMaterial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff frm = new Staff();
            frm.ShowDialog();
        }

        private void btnServiceMaterial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service frm = new Service();
            frm.ShowDialog();
        }

        #endregion
        #region Show & Load Data
        void LoadData()
        {
            materials.Clear();
            try
            {
                string sql = "select id_material, name, unit, quantity, cost from Material";
                db.Execute<ClassMaterials>("studio", sql, ref materials);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        void ShowMaterials(ref List<ClassMaterials> materials, ref DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            foreach (ClassMaterials item in materials)
            {
                dataGridView.Rows.Add(item.Name, item.Measurement, item.Count, item.Cost);
            }

        }
        void ShowData()
        {
            ShowMaterials(ref materials, ref dgvMaterials);
        }

        private void Materials_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }
        #endregion
        #region InDB
        ClassMaterials InsertMaterials(ref ClassMaterials materials)
        {
            if (materials == null) return null;
            List<ClassMaterials> currentmaterial = new List<ClassMaterials>();
            string r = "INSERT INTO Material (name, unit, quantity, cost) values ('";
            r += materials.Name + "' ,'" + materials.Measurement + "' ,'" + materials.Count + "' ,'" + materials.Cost + "' )";
            db.ExecuteNonQuery("studio", r);

            r = "Select name, unit, quantity, cost from Material where name = '";
            r += materials.Name + "' and unit ='" + materials.Measurement + "'";
            db.Execute("studio", r, ref currentmaterial);

            ClassMaterials temp = currentmaterial[0];
            return temp;

        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                if (!ExistMaterial())
                {
                    if (int.TryParse(tbCountMaterial.Text.Trim(), out int count))
                    {
                        ClassMaterials material = new ClassMaterials(0, tbNameMaterial.Text.Trim(), tbVimirMaterial.Text.Trim(), count, tbCostMaterial.Text.Trim());
                        ClassMaterials currntmaterial = InsertMaterials(ref material);

                        if (currntmaterial != null)
                        {

                            LoadData(); 
                            ShowData(); 
                            MessageBox.Show("Матеріал успішно додано!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("У полі 'Кількість' має бути число!");
                    }
                }
                else
                {
                    MessageBox.Show("Такий матеріал вже існує!");
                }
            }
        }
        #endregion

        private void btnCleanMaterial_Click(object sender, EventArgs e)
        {
            tbNameMaterial.Text = "";
            tbVimirMaterial.Text = "";
            tbCountMaterial.Text = "";
            tbCostMaterial.Text = "";
        }

        private void dgvMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
