using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class AdCompany
    {
        public enum AdSpaceSize
        {
            Size_4X4, Size_4X5 
        }
        public int ID { get; set; }
        public String CompanyName { get; set; }
        public DateTime ContractLength { get; set; }
        public AdSpaceSize AdSpaceSizes { get; set; }
        public virtual ICollection<AdPicture> AdPictures { get; set; }
    }
}