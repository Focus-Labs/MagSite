using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Content
    {
        public int ID { get; set; }
        public enum ContentType
        {
            Stories,Poetry,ArtistReview,AskJ,Interview,Feature
        }
        public int? ContributorID { get; set; }
        public String ContentUri { get; set; }
        public String Title { get; set; }
        public ContentType ContentTypes { get; set; }
        public virtual Contributor Contributor { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Like> Likes { get; set; } 
    }

}