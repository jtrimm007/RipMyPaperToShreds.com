using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    public class PaperShredsCommentsVM
    {
        public Papers Paper { get; set; }
        public ICollection<ShredCommentsVM> ShredsAndComments { get; set; } = new List<ShredCommentsVM>();
    }
}
