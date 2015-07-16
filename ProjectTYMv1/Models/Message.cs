using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Message
    {
        public enum SenderType
        {
            Leader,User
        }
        public int ID { get; set; }
        public int? UserID { get; set; }
        public SenderType SenderTypes { get; set; }
        public String Content { get; set; }
        public DateTime SentTime { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}