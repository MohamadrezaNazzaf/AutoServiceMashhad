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
        public IServiceType ServiceType { get; set; }
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
