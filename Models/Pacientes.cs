using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CntNetCore.Models
{
    public class Pacientes
    {
        [Key]
        [StringLength (19, MinimumLength =3,ErrorMessage ="El documento debe tener de 3 a 19 caracteres")]
        public String Documento { get; set; }
        [Required (ErrorMessage ="Campo Requerido")]
        [StringLength (50)]
        public String Nombres { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        [StringLength(50)]
        public String Apellidos { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Edad { get; set; }
        [StringLength(50)]
        public String Direccion { get; set; }
        [StringLength(1)]
        public String Sexo { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Peso { get; set; }
        [Required(ErrorMessage = "Campo Requerido")]
        public int Estatura { get; set; }
        [StringLength(2)]
        public String Fumador { get; set; }
        public int Añosfumador { get; set; }
        [StringLength(2)]
        public String Dieta { get; set; }
        public int PesoEstatura { get; set; }
        [StringLength(10)]
        public String Estado { get; set; }
        public Double Riesgo { get; set; }
        public Double Prioridad { get; set; }
    }
}
