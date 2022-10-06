using AutoServiceMashhad.Core.Services.Interfaces;
using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoServiceMashhad.Web.Pages.ServiceTypes
{
    public class EditModel : PageModel
    {
        private IServices _services;
        public EditModel(IServices service)
        {
            _services = service;
        }

        [BindProperty]
        public IServiceType ServiceType { get; set; }

        public IActionResult OnGet(int id)
        {
            ServiceType = _services.GetServiceById(id);
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _services.EditService(ServiceType);

            return RedirectToPage("Index");
        }
    }
}
