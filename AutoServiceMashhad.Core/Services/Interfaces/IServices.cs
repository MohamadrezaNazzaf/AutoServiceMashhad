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
        IQueryable<ServiceType> GetAllServiceTypes();
        void AddService(ServiceType serviceType);
    }
}
