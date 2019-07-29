using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QxHOrderSystem.Models
{
    public class USA
    {
        [Key]
        public int ItemId { get; set; }
        public int PlanSeqId { get; set; }
        public string ItemDescription { get; set; }
        public int OrderQuantity { get; set; }
        public int OrderSldTdy { get; set; }
        public int PlannedMinutesQty { get; set; }
        public int ActualMinutesQty { get; set; }
        public int NetworkId { get; set; }
        public int CompanyId { get; set; }
        public int AvaiForSaleQty { get; set; }
        public DateTime ShowDate { get; set; }
        public string ShowCd { get; set; }
        [NotMapped]
        public int InputQty { get; set; } 
    }
}
