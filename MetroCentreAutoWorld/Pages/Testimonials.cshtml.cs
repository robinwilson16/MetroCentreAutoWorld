using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MetroCentreAutoWorld.Pages
{
    public class TestimonialsModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Reviews from our customers";
        }
    }
}