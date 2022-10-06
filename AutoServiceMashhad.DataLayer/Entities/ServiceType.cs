using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.DataLayer.Entities
{
    public class IServiceType
    {
        public int Id { get; set; }

        [DisplayName("نام سرویس")]
        [Required(ErrorMessage = "لطفا نام سرویس را وارد کنید.")]
        [MaxLength(500)]
        public string Name { get; set; }

        [DisplayName("قیمت سرویس")]
        [Required(ErrorMessage = "لطفا قیمت سرویس را وارد کنید.")]
        public double Price { get; set; }

    }
}
