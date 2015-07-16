using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int ContentID { get; set; }
        public int UserID { get; set; }
        public String CommentContent { get; set; }
        public virtual Content Content { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}