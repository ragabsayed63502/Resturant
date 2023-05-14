using System;
using System.Collections.Generic;
using System.Text;

namespace Resturant
{
    class Cashier : Employee
    {
        private TimeSpan startTime;
        private TimeSpan endTime;
        public string StartTime
        {
            get
            {
                return startTime.ToString();
            }
            set
            {
                startTime = DateTime.Parse(value).TimeOfDay;
            }
        }
        public string EndTime
        {
            get
            {
                return endTime.ToString();
            }
            set
            {
                endTime = DateTime.Parse(value).TimeOfDay;
            }
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Cashier()
        {
        }
        public Cashier(string name, int id) : base(name, id)
        {

        }

        public Cashier(string startTime, string endtTime)
        {
            StartTime = DateTime.Parse(startTime).ToLongTimeString();
            EndTime = DateTime.Parse(endtTime).ToLongTimeString();
        }

        public static Cashier? Parse(object? obj)
        {
            if (obj is Employee)
                return (Cashier)obj;
            return null;
        }
    }
}
