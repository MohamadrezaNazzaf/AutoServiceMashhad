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
        IQueryable<IServiceType> GetAllServiceTypes();
        IServiceType GetServiceById(int serviceId);
        void AddService(IServiceType serviceType);
        void EditService(IServiceType serviceType);
        void DeleteService(IServiceType serviceType);
    }
}
