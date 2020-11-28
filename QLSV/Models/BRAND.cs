namespace APIBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;

    public partial class BRAND
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public string BrandURL { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
