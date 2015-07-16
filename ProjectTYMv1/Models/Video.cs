using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTYMv1.Models
{
    public class Video
    {
        public enum VideoGalleryType
        {
            DownloadableResource,TYMGallery
        }
        public int ID { get; set; }
        public String Uri { get; set; }
        public String Caption { get; set; }
        public VideoGalleryType VideoGalleryTypes { get; set; }
    }
}