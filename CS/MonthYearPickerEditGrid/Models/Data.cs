using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonthYearPickerEditGrid.Models
{
    public class Data
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderName { get; set; }
        public static List<Data> GetData()
        {
            return Enumerable.Range(0, 1000).Select(i => new Data() { OrderID = i, OrderDate = (new DateTime(2018, 9, 1)).AddDays(i), OrderName = "Order#" + i }).ToList<Data>();
        }
    }
}