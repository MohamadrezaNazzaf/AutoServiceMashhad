using AutoServiceMashhad.Core.Services.Interfaces;
using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoServiceMashhad.Web.Pages.ServiceTypes
{
    public class CreateModel : PageModel
    {
        private IServices _services;
        public CreateModel(IServices services)
        {
            _services = services;
        }


        [BindProperty]
<<<<<<< HEAD
        public IServiceType ServiceType { get; set; }
=======
        public ServiceType ServiceType { get; set; }
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _services.AddService(ServiceType);
            return RedirectToPage("Index");
        }
    }
}
