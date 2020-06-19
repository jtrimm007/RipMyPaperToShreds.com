using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models
{
    public class Papers
    {
        public int ID { get; set; }

        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }
        [Required]
        public string Paper { get; set; }
        public ICollection<HashTags> HashTags { get; set; }
        public bool Draft { get; set; }

        
    }
}
