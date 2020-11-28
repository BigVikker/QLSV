namespace APIBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;

    public partial class CUSTOMER
    {
        
        public int CustomerID { get; set; }

        public string CustomerUsername { get; set; }

        public string CustomerPassword { get; set; }

        public string CustomerEmail { get; set; }

        
        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerAddress { get; set; }

        public DateTime? CreatedDate { get; set; }

        
    }
}
