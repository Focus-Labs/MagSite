using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class AdPicture
    {
        public int ID { get; set; }
        public int AdCompanyID { get; set;}
        public String Uri { get; set; }
        public String AdLink { get; set; }
        public virtual AdCompany AdCompany { get; set; }
    }
}