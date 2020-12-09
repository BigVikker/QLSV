namespace QLSV.Models
{
    using System;
    using System.Collections.Generic;

    public partial class BRAND
    {

        public int BrandID { get; set; }
        public string BrandName { get; set; }

        public string BrandURL { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
