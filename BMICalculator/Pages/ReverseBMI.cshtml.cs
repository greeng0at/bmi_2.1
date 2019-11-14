using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BMICalculator.Pages
{
    public class ReverseBMIModel : PageModel
    {
        [BindProperty]
        public ReverseBMI ReverseBMI { get; set; }
    }
}