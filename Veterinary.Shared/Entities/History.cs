using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class History
    {

        public int Id { get; set; }


        [Display(Name = "Fecha atención")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd HH:mm}",ApplyFormatInEditMode =true)]
        public DateTime Date { get; set; }


        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(100, ErrorMessage = "No puede superar los 100 caracteres")]
        public string Description  { get; set; }



        [Display(Name = "Observaciones")]
        [MaxLength(500, ErrorMessage = "No puede superar los 500 caracteres")]
        public string Remarks { get; set; }


        [Display(Name = "Hora local")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateLocal =>Date.ToLocalTime(); 



        public ServiceType ServiceTypes { get; set; }

        public Pet Pets { get; set; }   



    }
}
