using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrimageGallery.Models
{
    public class File
    {
        public virtual int FileId { get; set; }
        [StringLength(255)]
        public virtual string FileName { get; set; }
        [StringLength(100)]
        public virtual string ContentType { get; set; }

        public virtual byte[] Content { get; set; }
    }

    public class CategoryImageFile : File { }

    public class UserImageFile : File { }
}