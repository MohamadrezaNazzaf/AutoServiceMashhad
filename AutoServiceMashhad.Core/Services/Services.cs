using AutoServiceMashhad.Core.Services.Interfaces;
using AutoServiceMashhad.DataLayer.Context;
using AutoServiceMashhad.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.Core.Services
{
    public class Services : IServices
    {
        private AutoServiceContext _context;
        public Services(AutoServiceContext context)
        {
            _context = context;
        }

        public void AddService(ServiceType serviceType)
        {
            _context.ServiceTypes.Add(serviceType);
            _context.SaveChanges();
        }

        public IQueryable<ServiceType> GetAllServiceTypes()
        {
            return _context.ServiceTypes;
        }
    }
}
