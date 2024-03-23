using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }


        [Display(Name = "Primer Nombre")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        public string FirstName { get; set; }


        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(50, ErrorMessage = "No puede superar los 50 caracteres")]
        public string LastName { get; set; }


        [Display(Name = "Documento de identidad")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(13, ErrorMessage = "No puede superar los 13 dígitos")]

        public string Document { get; set; }



        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Este campo es obliogatorio")]
        [MaxLength(100, ErrorMessage = "No puede superar los 100 caracteres")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string Email { get; set; }



        [Display(Name = "Teléfono fijo")]
      
        [MaxLength(10, ErrorMessage = "No puede superar los 10 caracteres")]
        public string FixedPhone { get; set; }


        [Display(Name = "Teléfono Móvil")]

        [MaxLength(10, ErrorMessage = "No puede superar los 10 caracteres")]
        public string CellPhone { get; set; }


        [Display(Name = "Dirección de residencia")]

        [MaxLength(100, ErrorMessage = "No puede superar los 100 caracteres")]
        public string Direccion { get; set; }


        public string FullName => $"{FirstName} {LastName}";




        public ICollection<Agenda> Agendas { get; set; }

    }






}

