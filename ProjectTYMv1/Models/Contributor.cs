using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Contributor
    {
        public int ID { get; set; }
        public int age { get; set; }
        public String nationality { get; set; }
        public String PictureUri { get; set; }
        public String ShortDescription { get; set; }
        public virtual ICollection<SocialMediaLinks> SocialMediaLinks{ get; set;}
        public virtual ICollection<Content> Contents { get; set; } 
    }

    public class SocialMediaLinks
    {
        public enum SocialMediaLinkType
        {
            Facebook,GooglePlus,Twitter,Instagram
        }
        public int ID { get; set; }
        public int ContributorID { get; set; }
        public SocialMediaLinkType SoclaLinkType { get; set; }
        public String Link { get; set; }
        public virtual Contributor Contributor { get; set; }
    }
}