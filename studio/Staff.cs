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
using System.Xml.Linq;

namespace studio
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        ClassDataBase db = new ClassDataBase();
        List<ClassStaff> staffs = new List<ClassStaff>();
        List<Position> positions = new List<Position>();
        #region Valide&EExist
        bool ExistStaff()
        {
            var service = staffs.Where(s => s.Name == tbFullNameStuff.Text.Trim()  && s.PassportNum == tbPassportNum.Text.Trim()).Select(p => p).ToList();
            if (service.Count > 0) return true;
            return false;
        }

        bool IsValide()
        {
            if (tbFullNameStuff.Text.Trim() == "")
            {
                MessageBox.Show("Поле для ПІБ обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (tbPassportNum.Text.Trim()== "")
            {
                MessageBox.Show("Поле для Номера пасспорта обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if(tbPhoneNum.Text.Trim() == "")
            {
                MessageBox.Show("Поле для Номеру телефона обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if(cbPosition.SelectedValue == null)
            {
                MessageBox.Show("Поле для Посади обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }

            if (string.IsNullOrWhiteSpace(tbPassportNum.Text) || tbPassportNum.Text.Length != 8)
            {
                MessageBox.Show("Номер паспорта повинен бути рівно 8 цифр.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (staffs.Any(stf => stf.PassportNum.ToString() == tbPassportNum.Text.Trim()))
            {
                MessageBox.Show("Цей номер паспорта вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (staffs.Any(stf => stf.PhoneNum.ToString() == tbPhoneNum.Text.Trim()))
            {
                MessageBox.Show("Цей номер телефона вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        #endregion
        #region Close&Anotherform
        private void btnOrderStuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders frm = new Orders();
            frm.ShowDialog();
        }

        private void Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void btnServiceStuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service frm = new Service();
            frm.ShowDialog();
        }

        private void btnMaterialStuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materials frm = new Materials();
            frm.ShowDialog();
        }

        private void btnStuffStuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff frm = new Staff();
            frm.ShowDialog();
        }
        #endregion
        void LoadData()
        {
            try
            {
                staffs.Clear();
                string sql = "select e.id_employee , e.full_name, e.birth_date, e.passport_number, e.phone_number, p.position_name from Employee e JOIN Position p ON e.position_id = p.id_position";
                db.Execute("studio", sql, ref staffs);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try //дл кб
            {
                string sql = "select id_position, position_name from Position";
                db.Execute("studio", sql, ref positions);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        void ShowEmployee(ref List<ClassStaff> staff, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (ClassStaff s in staff)
            {
                dataGrid.Rows.Add(s.Name, s.BirthDate.ToString("dd.MM.yyyy"), s.PassportNum, s.PhoneNum, s.Position);
            }
        }

        #region Show&Load
        void ShowPosition(ref List<Position> categories, ref ComboBox comboBox)
        {
            if (categories != null && categories.Count > 0)
            {
                comboBox.DataSource = null; // Очищуємо старі дані
                comboBox.DataSource = categories;
                comboBox.ValueMember = "ID"; 
                comboBox.DisplayMember = "Name";  
                cbPosition.SelectedIndex = -1;   //  порожній рядок
                cbPosition.Text = "";
            }
        }

        void ShowData()
       {
            ShowEmployee(ref staffs, ref dgvStuff);
            ShowPosition(ref positions, ref cbPosition);
       }
        private void Staff_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
            dtpDateBD.MaxDate = DateTime.Today.AddYears(-17);
        }
        #endregion

        #region Insert&Order_click
        ClassStaff InsertEmployee(ref ClassStaff staff) 
            {
                int posId = (int)cbPosition.SelectedValue;

            if (staff == null || cbPosition.SelectedValue == null) return null; 
            List<ClassStaff> curremp = new List<ClassStaff>();
                string r = "INSERT INTO Employee(full_name, birth_date, passport_number, phone_number, position_id) values('";
                r += staff.Name + "' ,'" + staff.BirthDate.ToString("yyyy-MM-dd") + "' ,'" + staff.PassportNum + "' ,'" + staff.PhoneNum + "' ,'" + posId + "')";
                db.ExecuteNonQuery("studio", r);

                r = "select e.id_employee , e.full_name, e.birth_date, e.passport_number, e.phone_number, p.position_name from Employee e " + "JOIN Position p ON e.position_id = p.id_position " +"WHERE e.full_name = '" + staff.Name + "' " +"AND e.passport_number = '" + staff.PassportNum + "'"; ;
                db.Execute("studio", r, ref curremp);

                ClassStaff temp = curremp[0];
                return temp;


            }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                if(!ExistStaff())
                {
                    int posId = (int)cbPosition.SelectedValue;

                    ClassStaff newStaff = new ClassStaff(0, tbFullNameStuff.Text.Trim(),dtpDateBD.Value.Date, tbPassportNum.Text.Trim(), tbPhoneNum.Text.Trim(),cbPosition.Text.Trim());
                    ClassStaff savedStaff = InsertEmployee(ref  newStaff);
                    if (savedStaff != null)
                    {
                        staffs.Add(savedStaff);
                        ShowEmployee(ref staffs, ref dgvStuff);
                        MessageBox.Show("Співробітника успішно додано!");
                    }
                }
                    else MessageBox.Show("Такий співробітник вже існує!");



            }
            
            
        }
        #endregion

        private void btnCleanOrder_Click(object sender, EventArgs e)
        {
            tbFullNameStuff.Text = "";
            tbPassportNum.Text = "";
            tbPhoneNum.Text = "";
            cbPosition.SelectedValue = -1;
        }
    }
}
