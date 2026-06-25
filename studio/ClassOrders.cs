using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class ClassOrders

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Client_name { get; set; } 
        public string Master {  get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDateEnd { get; set; }
        public string Status { get; set;}
        public string Prise {  get; set; }
        public string Description { get; set; }



        public ClassOrders()
        {
            ID = 0;
        }

        public ClassOrders(int id, string name, string phone_number, string client_name, string master, DateTime orderDate, DateTime orderDateEnd,string status, string prise, string description = "")
        {
            ID = id;
            Name = name;
            PhoneNumber = phone_number;
            Client_name = client_name;
            Master = master;
            OrderDate = orderDate;
            OrderDateEnd = orderDateEnd;
            Status = status;
            Prise = prise;
            Description = description;
        }



        private string LoadServise()
        {
            List<ClassService> services = new List<ClassService>();
            string sql = "SELECT s.id_service, s.name, s.execution_time, s.category_id, s.description " +
                "FROM Service s " + "Join ServiceOrder so ON s.id_service = so.service_id " + "where so.order_id = " + this.ID;
            ClassDataBase db = new ClassDataBase();
            db.Execute("studio", sql, ref services);
            return services.Count > 0 ? services[0].Name : "Послугу не знайдено";
        }


        private string LoadMaster()
        {
            List<ClassStaff> classStaff = new List<ClassStaff>();
            string sql = "Select e.id_employee, e.full_name, e.birth_date, e.passport_number,e.phone_number,e.position_id " + "from Employee e " + " join Orders o on e.id_employee = o.employee_id " + "Where o.id_order = " + this.ID;
            ClassDataBase classDataBase = new ClassDataBase();
            classDataBase.Execute ("studio", sql, ref classStaff);
            return classStaff.Count >0 ? classStaff[0].Name: "Майстра не знайдено";


        }

        private string LoadStatus()
        {
            List<Status> status = new List<Status>();
            string sql = "Select s.id_status, s.name from Status s " +
                         "join Orders o on s.id_status = o.status_id " +
                         "Where o.id_order = " + this.ID;
            ClassDataBase classDataBase= new ClassDataBase();
            classDataBase.Execute("studio", sql, ref status);
            return status.Count > 0 ? status[0].Name : "Статус не знайдено";
        }

        public ClassOrders(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;
            string[] val = info.Split('|');

            if (val.Length > 0 && int.TryParse(val[0].Trim(), out int id)) ID = id;

            if (val.Length >= 1) Name = val[1].Trim();

            Master = LoadMaster();
            Status = LoadStatus();

            if (val.Length >= 2) PhoneNumber = val[2].Trim();
            if (val.Length >= 3) Client_name = val[3].Trim();

            if (val.Length > 5 && DateTime.TryParse(val[5], out DateTime date))
                OrderDate = date;
            else
                OrderDate = DateTime.MinValue;
            if (val.Length > 6 && DateTime.TryParse(val[6], out DateTime dateend))
                OrderDateEnd = dateend;
            else
                OrderDateEnd = DateTime.MinValue;

            Prise = (val.Length > 7) ? val[8].Trim() : "0";
            Description = (val.Length > 8) ? val[9].Trim() : "";
        }

    }
}


