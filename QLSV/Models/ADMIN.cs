namespace APIBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;

    public partial class ADMIN
    {
        public int UserId { get; set; }
        public string UserUsername { get; set; }

        public string UserPassword { get; set; }

        public string UserName { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
