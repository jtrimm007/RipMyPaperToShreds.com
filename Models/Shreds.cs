using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models
{
    public class Shreds
    {
        public int ID { get; set; }
        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }
        [ForeignKey("AspNetUser")]
        public string ShredyId { get; set; }
        public bool Fixed { get; set; }
        public string Shred { get; set; }
        public DateTime Date { get; set; }

    }
}
