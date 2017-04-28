using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimageGallery.Models
{
    public class Image
    {
        public virtual int ImageId { get; set; }

        public virtual string Name { get; set; }

        public virtual UserImageFile UserImage { get; set; }

        public virtual Category Category { get; set; }

        public virtual ApplicationUser UploadedBy { get; set; }
    }
}