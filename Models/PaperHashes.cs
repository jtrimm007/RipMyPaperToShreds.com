using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models
{
    
    public class PaperHashes
    {
        [ForeignKey("Papers")]
        public int PaperId { get; set; }
        [ForeignKey("HashTags")]
        public int HashTagId { get; set; }
    }
}
