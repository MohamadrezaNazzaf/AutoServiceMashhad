using AutoServiceMashhad.Core.Services.Interfaces;
using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AutoServiceMashhad.Web.Pages.ServiceTypes
{
    public class DetailModel : PageModel
    {
        private IServices _services;
        public DetailModel(IServices services)
        {
            _services = services;
        }

        public IServiceType ServiceType { get; set; }
        public void OnGet(int id)
        {
            ServiceType = _services.GetServiceById(id);
        }
    }
}
