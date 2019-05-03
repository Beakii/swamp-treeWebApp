using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learning.Pages
{
    public class TestPageModel : PageModel
    {
        public string Message { get; private set; } = "This message was set in the model.";

        public void OnGet()
        {
            Message += $" Last updated on { DateTime.Now }.";
        }
    }
}