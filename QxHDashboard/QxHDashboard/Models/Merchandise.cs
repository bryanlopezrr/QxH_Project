using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QxHDashboard.Models
{
    public class Merchandise
    {
        public string Id { get; set; }
        public int PlanSeqId { get; set; }
        public int ItemId { get; set; }
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
    }

    public enum Countries
    {
        USA, EUR, JPN
    }

    public enum ShowCards
    {
        A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z
    }
}
