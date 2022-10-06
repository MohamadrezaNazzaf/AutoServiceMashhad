using AutoServiceMashhad.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.Core.Services.Interfaces
{
    public interface IServices
    {
<<<<<<< HEAD
        IQueryable<IServiceType> GetAllServiceTypes();
        IServiceType GetServiceById(int serviceId);
        void AddService(IServiceType serviceType);
        void EditService(IServiceType serviceType);
        void DeleteService(IServiceType serviceType);
=======
        IQueryable<ServiceType> GetAllServiceTypes();
        void AddService(ServiceType serviceType);
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
    }
}
