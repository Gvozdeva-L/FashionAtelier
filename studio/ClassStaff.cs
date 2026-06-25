using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studio
{
    public class ClassStaff
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; } 
        public string PassportNum { get; set; }
        public string PhoneNum { get; set; }
        public string Position { get; set; }

        public ClassStaff() { ID = 0; }

        public ClassStaff(int id, string name, DateTime birthDate, string passportNum, string phoneNum, string position)
        {
            ID = id;
            Name = name;
            BirthDate = birthDate;
            PassportNum = passportNum;
            PhoneNum = phoneNum;
            Position = position;
        }

        //private string LoadPosition()
        //{
        //    try
        //    {
        //        List<Position> positions = new List<Position>();

        //        string sql = "SELECT p.id_position, p.position_name " +
        //                             "FROM Position p " +
        //                             "JOIN Employee e ON e.position_id = p.id_position " +
        //                             "WHERE e.id_employee = " + this.ID;

        //        ClassDataBase db = new ClassDataBase();
        //        db.Execute("studio", sql, ref positions);

        //        return positions.Count > 0 ? positions[0].Name : "Не вказано";
        //    }
        //    catch { return "Помилка завантаження"; }
        //}//прив'язати через заит

        public ClassStaff(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;

            string[] values = info.Split('|');
            if (values.Length < 5) return; 
            if (values.Length >= 1)
            {
                int.TryParse(values[0].Trim(), out int id);
                ID = id;
            }
            Name = values[1];

            //int.TryParse(values[2], out int year);//ПЕРЕВІРКА
            if (DateTime.TryParse(values[2], out DateTime date))
                BirthDate = date;
            else
                BirthDate = DateTime.MinValue;
            PassportNum = values[3];
            PhoneNum = values[4];
            Position = values[5];
        }
    }
}
