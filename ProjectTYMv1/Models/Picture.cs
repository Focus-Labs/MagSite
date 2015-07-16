using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Picture
    {
        public enum GalleryType
        {
            ArtSection,DownloadableResource,TYMGallery,Content
        }
        public int ID { get; set; }
        public String Uri { get; set; }
        public String Caption { get; set; }
        public GalleryType GalleryTypes { get; set; }
    }
}