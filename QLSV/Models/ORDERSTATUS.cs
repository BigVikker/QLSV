using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    class ORDERSTATUS
    {
        public int StatusID { get; set; }
        public string StatusName { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
