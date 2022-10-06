using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
=======
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoServiceMashhad.DataLayer.Entities
{
<<<<<<< HEAD
    public class IServiceType
    {
        public int Id { get; set; }

        [DisplayName("نام سرویس")]
=======
    public class ServiceType
    {
        public int Id { get; set; }

>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
        [Required(ErrorMessage = "لطفا نام سرویس را وارد کنید.")]
        [MaxLength(500)]
        public string Name { get; set; }

<<<<<<< HEAD
        [DisplayName("قیمت سرویس")]
=======
>>>>>>> 737dcf1ad5e982f4d76ccd571d3e9fbcbce6c8a4
        [Required(ErrorMessage = "لطفا قیمت سرویس را وارد کنید.")]
        public double Price { get; set; }

    }
}
