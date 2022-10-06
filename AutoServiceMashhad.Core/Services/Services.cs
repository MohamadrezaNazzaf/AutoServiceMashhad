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


        public IQueryable<IServiceType> GetAllServiceTypes()
        {
            return _context.ServiceTypes;
        }

        public IServiceType GetServiceById(int serviceId)
        {
            return _context.ServiceTypes.FirstOrDefault(s => s.Id == serviceId);
        }

        public void AddService(IServiceType serviceType)
        {
            _context.ServiceTypes.Add(serviceType);
            _context.SaveChanges();
        }

        public void EditService(IServiceType serviceType)
        {
            _context.Entry(serviceType).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteService(IServiceType serviceType)
        {
            _context.Entry(serviceType).State = EntityState.Deleted;
            _context.SaveChanges();
        }
    }
}
