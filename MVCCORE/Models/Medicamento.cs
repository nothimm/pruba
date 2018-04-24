using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCORE.Models
{
    public class Medicamento
    {
        public  int MedicamentoId { get; set; }
        //campo requerido con mensaje personalizado
        [Required(ErrorMessage ="El nombre del medicamento es requerido")]
        //mostrar
        [Display(Name ="Nombre de Medicamento")]
        //definir el largo de caracteres max y minimo y mensaje de error
        [StringLength(220,MinimumLength =3,ErrorMessage ="El nombre del medicamento tiene que tener minimo 3 caracteries y maximo 220")]
        public string NombreMedicamiento { get; set; }

        [Required(ErrorMessage = "la fecha de expiracion es requerido")]
        [Display(Name = "Fecha de expiracion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Expira { get; set; }

        [Required(ErrorMessage = "la fecha de fabricacion es requerido")]
        [Display(Name = "Fecha de fabricacion")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_fabricado { get; set; }

        [Required(ErrorMessage = "la fecha de ingreso es requerido")]
        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha_Ingreso { get; set; }
        public int miquilo { get; set; }
        public int miquilo { get; set; }
        public int MyProperty { get; set; }
    }
}
