using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models
{
    public class SubShreds
    {
        public int ID { get; set; }
        [ForeignKey("AspNetUser")]
        public string ShrederId { get; set; }
        [ForeignKey("Shreds")]
        public int ShredId { get; set; }
        public string SubShred { get; set; }
        public DateTime Date { get; set; }
    }
}
