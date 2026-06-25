using System;
using System.Windows.Markup;

namespace studio
{
    public class Price
    {
        private int id;
        //private double? maxprise;
        //private double minprise;

        public int ID { get { return id; } }
        public double? Maxprise { get; set; }
        public double Minprise { get; set; }

        public Price()
        {
            id = 0;
        }

        public Price(int id, double? maxprise, double minprise)
        {
            this.id = id;
            Maxprise = maxprise;
            Minprise = minprise;
        }

        public Price(string info)
        {
            if (string.IsNullOrWhiteSpace(info)) return;
            string[] val = info.Split('|');

            if (val.Length >= 1) int.TryParse(val[0].Trim(), out id);

            if (val.Length >= 2 && !string.IsNullOrWhiteSpace(val[1]))
            {
                string sMin = val[1].Trim().Replace('.', ',');
                if (double.TryParse(sMin, out double min))
                    Minprise = min;
            }

            if (val.Length >= 3 && !string.IsNullOrWhiteSpace(val[2]))
            {
                string sMax = val[2].Trim().Replace('.', ',');
                if (double.TryParse(sMax, out double max))
                    Maxprise = max;
            }

        }


    }
}
