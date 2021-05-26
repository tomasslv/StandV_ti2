using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StandV_ti2.Models
{
    public class Fotos
    {

        /// <summary>
        /// Identificador da Foto
        /// </summary>
        [Key]
        public int IdFoto { get; set; }

        /// <summary>
        /// Nome da Foto
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(45, ErrorMessage = "O Nome não pode ter mais de 45 caracteres.")]
        public string NomeFoto { get; set; }

    }
}
