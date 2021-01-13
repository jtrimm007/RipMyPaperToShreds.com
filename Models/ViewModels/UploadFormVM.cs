using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    public class UploadFormVM
    {
        public string Css { get; set; }
        public int PaperId { get; set; }
        public string UniqueFileName { get; set; }
        public IFormFile File { get; set; }
        public DateTime UploadDate { get; set; }
        public int ID { get; set; }
    }
}
