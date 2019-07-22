using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QxHOracleLoader.Models
{
    public class Item
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
        public string ShowDate { get; set; }
        public string ShowCd { get; set; }

        [NotMapped]
        public bool CheckboxAnswer { get; set; }
    }
}
