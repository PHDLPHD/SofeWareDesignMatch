using System;
using System.Collections.Generic;
using SDM.DTO;

namespace SDM.Model.Models
{
    public partial class SDM_Users:Entity
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public string MacAddress { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> isValid { get; set; }
        public string LastLoginIpAddress { get; set; }
    }
}
