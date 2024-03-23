using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public  class Agenda
    {

        public int Id { get; set; }


        [Display(Name = "Fecha cita")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }


        [Display(Name = "Reseña")]
        [MaxLength(100, ErrorMessage = "No puede superar los 100  caracteres")]

        public string Remarks { get; set; }



        [Display(Name = "Hora cita")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal => Date.ToLocalTime();


        [Display(Name = "Disponibilidad")]
        public bool IsAvailable { get; set; }


        public Owner Owners { get; set; }

        public Pet Pets { get; set; }    
    }
}
