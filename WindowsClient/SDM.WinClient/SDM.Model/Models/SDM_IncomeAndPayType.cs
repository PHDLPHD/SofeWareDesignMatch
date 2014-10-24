using System;
using System.Collections.Generic;
using SDM.DTO;

namespace SDM.Model.Models
{
    public partial class SDM_IncomeAndPayType:Entity
    {
        public int ID { get; set; }
        public int IncomeOrPay { get; set; }
        public string IAOName { get; set; }
        public int UserID { get; set; }
        public Nullable<bool> Systematics { get; set; }
    }
}
