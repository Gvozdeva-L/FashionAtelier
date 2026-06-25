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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }
        public List<ClassOrders> orders = new List<ClassOrders>();
        public List <ClassService> services = new List<ClassService>();
        public List <ClassStaff> staffs = new List<ClassStaff>();
        public List<Status> status = new List<Status>();

        ClassDataBase db = new ClassDataBase();

        bool ExistOrder()
        {
            var order = orders.Where(s => s.Name == cbNameServise.Text.Trim() && s.PhoneNumber == tbClientPhoneNum.Text.Trim() && s.Client_name == tbClientName.Text.Trim()).Select(s =>s).ToList();
            if(order.Count > 0) return true;
            return false;
        }

        bool IsValide()
        {
            if(cbNameServise.SelectedIndex == -1)
            {
                MessageBox.Show("Поле для назви послуги обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }
            if (tbClientPhoneNum.Text.Trim() == "")
            {
                MessageBox.Show("Поле для номеру телефона обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }
            if(tbClientName.Text.Trim() =="")
            {
                MessageBox.Show("Поле для ім'я клієнта обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }

            if(cbMaster.SelectedIndex == -1)
            {
                MessageBox.Show("Поле для майстра обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;
            }
            if (cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Поле для статусу обов'язкове до заповнення!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information); return false;

            }
            return true;

        }
        #region Load & Show Data
        private void cbNameServise_SelectedIndexChanged(object sender, EventArgs e) //відображення максимальної і мінімальної ціни у обранох послуги
        {
            if (cbNameServise.SelectedIndex != -1)
            {
                var selectedService = services.FirstOrDefault(s => s.Name == cbNameServise.Text);

                if (selectedService != null)
                {

                    tbMinPrice.Text = selectedService.DisplayMinPrice; 
                    tbMaxPrice.Text = selectedService.DisplayMaxPrice; 

                    tbCost.Text = selectedService.Minprice.ToString();
                }
            }
        }
        void LoadData()
        {
            try
            {
                orders.Clear();
                string sql = "SELECT o.id_order, so.name, o.client_phone, o.client_name, o.employee_id, o.order_date, o.order_date_end, o.status_id, so.price, so.description " +
               "FROM Orders o " + "LEFT JOIN ServiceOrder so ON o.id_order = so.order_id " + "ORDER BY o.status_id DESC";

                db.Execute<ClassOrders>("studio", sql, ref orders);

            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
            try
            {
                string sql = "select id_service, name, category_id, execution_time, description from Service ";
                db.Execute<ClassService>("studio", sql, ref services);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            try
            {
                string sql = "select id_employee, full_name, birth_date, passport_number, phone_number, position_id from Employee";
                db.Execute<ClassStaff>("studio", sql, ref staffs);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            try
            {
                string sql = " select id_status, name from Status";
                db.Execute<Status>("studio", sql, ref status);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        void ShowOrders(ref List<ClassOrders> orders, ref DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            foreach (ClassOrders item in orders) 
            {
                string dateEndString = (item.OrderDateEnd == DateTime.MinValue) ? "-" : item.OrderDateEnd.ToString("dd.MM.yyyy");
                dataGrid.Rows.Add(item.ID, item.Name,item.PhoneNumber, item.Client_name, item.Master, item.OrderDate.ToString("dd.MM.yyyy"), dateEndString, item.Status, item.Prise,item.Description);
            }
        }
        void ShowService(ref List<ClassService> services, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if (services != null)
            { 
                foreach (ClassService service in services)
                {
                    comboBox.Items.Add(service.Name);
                }
            }
        }
        void ShowEmployee (ref List<ClassStaff> staff, ref ComboBox comboBox)
        {
            comboBox.Items.Clear();
            if(staff != null)
            {
                foreach (ClassStaff s in staff)
                {
                    comboBox.Items.Add(s.Name);
                }
            }
        }

        void ShowStatus(ref List<Status> statuses, ref ComboBox comboBox)
        {
            if (statuses != null)
            {
                foreach (Status stat in statuses)
                {
                    if (stat.ID == 1) continue;

                    comboBox.Items.Add(stat.Name);
                }
            }
        }
        void ShowData()
        {
            ShowOrders(ref orders, ref dgvOrders);
            ShowService(ref services, ref cbNameServise);
            ShowEmployee(ref staffs, ref cbMaster);
            ShowStatus(ref status, ref cbStatus);
            ShowService(ref services, ref cbFilterService);
            ShowEmployee(ref staffs, ref cbFilterMaster);
            ShowStatus(ref status, ref cbFilterStatus);
        }
        private void Orders_Load(object sender, EventArgs e)
        {
            cbNameServise.SelectedIndexChanged += cbNameServise_SelectedIndexChanged;
            dtpDateOrder.MaxDate = DateTime.Today;
            dtpDateOrder.Enabled = false;
            LoadData();
            ShowData();
        }

       

        #endregion

        void IssueOrder(int orderId)
        {
            try
            {
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string sql = "UPDATE Orders " + "SET order_date_end = '" + currentDate + "', " +"status_id = 1 " +"WHERE id_order = " + orderId;

                db.ExecuteNonQuery("studio", sql);

                MessageBox.Show("Замовлення успішно видано!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка видачі: " + ex.Message);
            }
        }

        private void btnOrderEnd_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null || dgvOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть замовлення зі списку, яке потрібно видати.");
                return;
            }

            string idString = dgvOrders.CurrentRow.Cells[0].Value.ToString();

            if (int.TryParse(idString, out int orderId))
            {
                DialogResult dialogResult = MessageBox.Show("Видати замовлення №" + orderId + "?", "Підтвердження", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    IssueOrder(orderId);

                    LoadData();
                    ShowData();
                }
            }
        }
        ClassOrders InsertOrders(ClassOrders classOrders, int serviceId)
        {
            if (classOrders == null) return null;

            try
            {
                string dateEndVal = (classOrders.OrderDateEnd == DateTime.MinValue) ? "NULL" : classOrders.OrderDateEnd.ToString("yyyy-MM-dd");


                string cleanPrice = classOrders.Prise.Replace("грн", "").Trim(); // прибираємо текс лишаю число

                string sqlOrders = "INSERT INTO Orders (name, client_phone, client_name, employee_id, order_date, order_date_end, status_id) " +
                                   "VALUES ('" + classOrders.Name + "' ,'" + classOrders.PhoneNumber  +"' ,'" + classOrders.Client_name + "' ,'" + classOrders.Master + "' ,'" +  classOrders.OrderDate.ToString("yyyy-MM-dd") + "' ,'" +  dateEndVal + "' ,'" + classOrders.Status + "' )";

                db.ExecuteNonQuery("studio", sqlOrders);

                object lastId = db.ExecuteScalar("studio", "SELECT last_insert_rowid()");

                if (lastId != null && lastId != DBNull.Value)
                {
                    int newOrderId = Convert.ToInt32(lastId); 
                    classOrders.ID = newOrderId;

                    string sqlServiceOrder ="INSERT INTO ServiceOrder (service_id, order_id, name, price, description) " + "VALUES ('" + serviceId + "' ,'" + newOrderId + "' ,'" +classOrders.Name + "' ,'" +
                  classOrders.Prise + "' ,'" + classOrders.Description + "' )";


                    db.ExecuteNonQuery("studio", sqlServiceOrder);
                }

                return classOrders;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні: " + ex.Message);
                return null;
            }
        }



        #region Load another page & close Insert & Filtr
        private void Orders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void btnServiceOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Service frm = new Service( );
            frm.ShowDialog();
        }
        private void btnMaterialOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materials frm = new Materials(/*this*/); // передаємо головну форму
            frm.ShowDialog();
        }
        private void btnStuffOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff frm = new Staff( );
            frm.ShowDialog();
        }

        private void btnOrderOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (IsValide())
            {
                if (!ExistOrder()) 
                {
                    //  Знах ID обр послуги та статусу
                    var selectedService = services.FirstOrDefault(s => s.Name == cbNameServise.Text);
                    int serviceId = selectedService != null ? selectedService.ID : 0;

                    var selectedStatus = status.FirstOrDefault(s => s.Name == cbStatus.Text);
                    int statusId = selectedStatus != null ? selectedStatus.ID : 1;
                    string description = string.Join(" ", tbDescribeOrder.Lines);

                    ClassOrders newOrder = new ClassOrders("");
                    newOrder.Name = cbNameServise.Text.Trim();
                    newOrder.PhoneNumber = tbClientPhoneNum.Text.Trim();
                    newOrder.Client_name = tbClientName.Text.Trim();
                    if (cbMaster.SelectedValue != null)
                    {
                        newOrder.Master = cbMaster.SelectedValue.ToString();
                    }
                    else
                    {
                        var m = staffs.FirstOrDefault(s => s.Name == cbMaster.Text);
                        newOrder.Master = m != null ? m.ID.ToString() : "1";
                    }
                    newOrder.OrderDate = dtpDateOrder.Value;
                    newOrder.OrderDateEnd = DateTime.MinValue; // Нове замовлення ще не видане
                    newOrder.Status = statusId.ToString();
                    newOrder.Prise = tbCost.Text.Trim();
                    newOrder.Description = description;

                    ClassOrders result = InsertOrders(newOrder, serviceId);

                    if (result != null)
                    {
                        LoadData();
                        ShowData();
                        MessageBox.Show("Замовлення успішно додано!");
                    }
                }
                else
                {
                    MessageBox.Show("Таке замовлення вже існує в базі!");
                }
            }
            }

        private void btnCleanOrder_Click(object sender, EventArgs e)
        {

            cbNameServise.SelectedIndex = -1;
            tbClientPhoneNum.Text = "";
            tbClientName.Text = "";
            cbMaster.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            tbCost.Text = "";
            tbMinPrice.Text = "";
            tbMaxPrice.Text = "";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbNameServise_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        void UpdateOrderGrid(List<ClassOrders> listToShow)
        {
            dgvOrders.Rows.Clear();
            foreach (ClassOrders item in listToShow)
            {
                string dateEndString = (item.OrderDateEnd == DateTime.MinValue) ? "-" : item.OrderDateEnd.ToString("dd.MM.yyyy");
                dgvOrders.Rows.Add(
                    item.ID,
                    item.Name,
                    item.PhoneNumber,
                    item.Client_name,
                    item.Master,
                    item.OrderDate.ToString("dd.MM.yyyy"),
                    dateEndString,
                    item.Status,
                    item.Prise,
                    item.Description
                );
            }
        }
        private void btnFiltr_Click(object sender, EventArgs e)
        {
            IEnumerable<ClassOrders> filteredOrders = orders;

            // Фільтр за Назвою послуги
            if (!string.IsNullOrWhiteSpace(cbFilterService.Text))
            {
                filteredOrders = filteredOrders.Where(o => o.Name == cbFilterService.Text);
            }

            //  Фільтр за Майстром
            if (!string.IsNullOrWhiteSpace(cbFilterMaster.Text))
            {
                filteredOrders = filteredOrders.Where(o => o.Master == cbFilterMaster.Text);
            }

            // Фільтр за Статусом
            if (!string.IsNullOrWhiteSpace(cbFilterStatus.Text))
            {
                filteredOrders = filteredOrders.Where(o => o.Status == cbFilterStatus.Text);
            }

             UpdateOrderGrid(filteredOrders.ToList());

        }

        private void btnCleanFiltr_Click(object sender, EventArgs e)
        {
            cbFilterService.SelectedIndex = -1;
            cbFilterMaster.SelectedIndex = -1;
            cbFilterStatus.SelectedIndex = -1;
        }

        private void btnOffFiltr_Click(object sender, EventArgs e)
        {
            dgvOrders.Rows.Clear();
            foreach (ClassOrders item in orders)
            {
                string dateEndString = (item.OrderDateEnd == DateTime.MinValue) ? "-" : item.OrderDateEnd.ToString("dd.MM.yyyy");
                dgvOrders.Rows.Add(item.ID, item.Name, item.PhoneNumber, item.Client_name, item.Master, item.OrderDate.ToString("dd.MM.yyyy"), dateEndString, item.Status, item.Prise, item.Description);
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
        
}
        #endregion


    

