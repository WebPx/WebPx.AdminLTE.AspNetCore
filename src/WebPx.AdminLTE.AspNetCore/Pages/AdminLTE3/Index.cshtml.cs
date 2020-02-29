using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebPx.AdminLTE.Pages.AdminLTE3
{
    public class IndexModel : PageModel
    {
        private IHostingEnvironment hostingEnvironement;

        public IndexModel(IHostingEnvironment hostingEnvironment)
        {
            this.hostingEnvironement = hostingEnvironment;
        }

        public ActionResult OnGet()
        {
            if (hostingEnvironement.IsDevelopment())
                return this.Page();
            return this.NotFound();
        }
    }
}
