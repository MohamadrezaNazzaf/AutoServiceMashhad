using AutoServiceMashhad.Core.Services.Interfaces;
using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoServiceMashhad.Web.Pages.ServiceTypes
{
    public class IndexModel : PageModel
    {
        private IServices _services;
        public IndexModel(IServices services)
        {
            _services = services;
        }
        public IList<IServiceType> ServiceTypes { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ServiceTypes = await _services.GetAllServiceTypes().ToListAsync();
            return Page();
        }
    }
}
