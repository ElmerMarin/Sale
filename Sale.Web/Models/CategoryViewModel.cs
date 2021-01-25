using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sale.Web.Models
{
    public class CategoryViewModel
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
