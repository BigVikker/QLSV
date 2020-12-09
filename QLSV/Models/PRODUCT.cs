namespace QLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class PRODUCT
    {
        
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Rating { get; set; }

        public string ProductImage { get; set; }

        public int? ProductStock { get; set; }

        public string ProductURL { get; set; }

        public int? Viewcount { get; set; }

        public bool? ProductStatus { get; set; }

        public DateTime? CreatedDate { get; set; }
        
        public int BrandID { get; set; }


        public void showSeft()
        {
            MessageBox.Show("product add: " + ProductID + ProductName + ProductDescription + ProductPrice + PromotionPrice + Rating + ProductImage + ProductStock + ProductURL + Viewcount + ProductStatus);
        }
    }
}
