namespace APIBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;

    public partial class ORDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
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
