using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StandV_ti2.Models
{
    public class Gestores
    {

        /// <summary>
        /// Identificador do Gestor
        /// </summary>
        [Key]
        public int IdGestor { get; set; }

        /// <summary>
        /// Nome do Gestor
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "O Nome não pode ter mais de 60 caracteres.")]
        public string Nome { get; set; }

        /// <summary>
        /// Morada do Gestor
        /// </summary>
        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório")]
        [StringLength(60, ErrorMessage = "A morada não pode ter mais de 60 caracteres.")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do Gestor
        /// </summary>
        [Required(ErrorMessage = "Deve escrever o código postal")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O código postal deve ter entre 30 e 8 caracteres.")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Numero de telemóvel do Gestor
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O número deve ter entre 9 e 14 caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, por favor, um nº de telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional.")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do Gestor
        /// </summary>
        [StringLength(50, ErrorMessage = "O gmail não pode ter mais de 50 caracteres.")]
        [EmailAddress(ErrorMessage = "O email introduzido não é válido.")]
        [RegularExpression("([a-z]+(([a-z]|[0-9])*)@gmail.com",
                           ErrorMessage = "Só são aceites emails da google.")]
        public string Email { get; set; }

        /// <summary>
        /// NIF do Gestor
        /// </summary>
        [StringLength(8, ErrorMessage = "O número deve conter 8 caracteres.")]
        [RegularExpression("([0-9]{8})", ErrorMessage = "Escreva, por favor, um NIF válido.")]
        [Display(Name = "NIF")]
        public string NIF { get; set; }

    }
}
