using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models.ViewModels
{
    public class PaperUploadVM
    {
       public PaperUpload PaperUpload { get; set; }
        public Papers Paper { get; set; }
    }
}
