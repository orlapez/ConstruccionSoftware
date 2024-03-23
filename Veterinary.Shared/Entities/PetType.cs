using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class PetType
    {

        public int Id { get; set; }



        [Display(Name = "Tipo Mascota")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        public string Name { get; set; }    
    }
}
