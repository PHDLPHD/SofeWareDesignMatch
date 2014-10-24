using System;
using System.Collections.Generic;
using SDM.DTO;

namespace SDM.Model.Models
{
    public partial class SDM_IOPSituation:Entity
    {
        public int ID { get; set; }
        public int IAPTID { get; set; }
        public decimal IOPMoney { get; set; }
        public System.DateTime IOPTime { get; set; }
        public string Remark { get; set; }
    }
}
