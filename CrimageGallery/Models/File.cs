using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrimageGallery.Models
{
    public class File
    {
        public virtual int FileId { get; set; }

        public virtual string FileName { get; set; }

        public virtual string ContentType { get; set; }

        public virtual byte[] Content { get; set; }
    }
}