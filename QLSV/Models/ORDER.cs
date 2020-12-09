namespace QLSV.Models
{
    using System;

    public partial class ORDER
    {
        
        public int OrderID { get; set; }

        public DateTime? OrderDate { get; set; }

        public decimal? Total { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

        public int? OrderStatusID { get; set; }

        public int? CustomerID { get; set; }
    }
}
