using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public  class Pet
    {

        public int Id { get; set; }



        [Display(Name = "Nombre Mascota")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50  caracteres")]
        public string Name { get; set; }



        [Display(Name = "Foto Mascota")]

        public string ImageUrl { get; set; }


        [Display(Name = "Raza")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50  caracteres")]

        public string Race { get; set; }


        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Born { get; set; }


        [Display(Name = "Comentarios")]
        [MaxLength(100, ErrorMessage = "No puede superar los 100  caracteres")]

        public string Remarks { get; set; }


        public Owner Owners { get; set; }

        public PetType PetTypes { get; set; }


        public ICollection<Agenda> Agendas { get; set; } 


        public ICollection<History> Histories { get; set; }




    }
}
