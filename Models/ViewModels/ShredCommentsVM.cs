using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    public class ShredCommentsVM
    {
        public Shreds Shred { get; set; }
        public ICollection<SubShreds> SubShreds { get; set; } = new List<SubShreds>();

    }
}
