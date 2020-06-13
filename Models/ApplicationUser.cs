using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string ScreenName { get; set; }
    }
}
