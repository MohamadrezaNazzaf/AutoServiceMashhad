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

<<<<<<< HEAD

        public IQueryable<IServiceType> GetAllServiceTypes()
        {
            return _context.ServiceTypes;
        }

        public IServiceType GetServiceById(int serviceId)
        {
            return _context.ServiceTypes.FirstOrDefault(s => s.Id == serviceId);
        }

        public void AddService(IServiceType serviceType)
=======
        public void AddService(ServiceType serviceType)
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
        {
            _context.ServiceTypes.Add(serviceType);
            _context.SaveChanges();
        }

<<<<<<< HEAD
        public void EditService(IServiceType serviceType)
        {
            _context.Entry(serviceType).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteService(IServiceType serviceType)
        {
            _context.Entry(serviceType).State = EntityState.Deleted;
            _context.SaveChanges();
=======
        public IQueryable<ServiceType> GetAllServiceTypes()
        {
            return _context.ServiceTypes;
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
        }
    }
}
