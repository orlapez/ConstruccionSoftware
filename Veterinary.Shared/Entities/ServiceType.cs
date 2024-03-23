using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class ServiceType
    {

        public int Id { get; set; }



        [Display(Name = "Tipo de Servicio")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        public string Name { get; set; }



        public ICollection<History> Histories { get; set; }

    }
}
