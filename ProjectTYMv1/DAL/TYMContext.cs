using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjectTYMv1.Models;

namespace ProjectTYMv1.DAL
{
    public class TYMContext : DbContext
    {
        public TYMContext():base("TYMContext")
        {}
        public DbSet<AdCompany> AdCompanies { get; set; }
        public DbSet<AdPicture> AdPictures { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Contributor> Contributors { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}