using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StandV_ti2.Models
{
    public class Veiculos
    {

        /// <summary>
        /// Identificador do Veiculo
        /// </summary>
        [Key]
        public int IdVeiculo { get; set; }

        /// <summary>
        /// Marca do Veiculo
        /// </summary>
        [Required(ErrorMessage = "A marca do veiculo é de preenchimento obrigatório")]
        public string Marca { get; set; }

        /// <summary>
        /// Modelo do Veiculo
        /// </summary>
        [Required(ErrorMessage = "O modelo do veiculo é de preenchimento obrigatório")]
        public string Modelo { get; set; }

        /// <summary>
        /// Ano do Veiculo
        /// </summary>
        [Display(Name = "Ano do Veiculo")]
        public DateTime AnoVeiculo { get; set; }

        /// <summary>
        /// Tipo de combustivel do Veiculo
        /// </summary>
        [Display(Name = "Combustivel")]
        public string Combustivel { get; set; }

        /// <summary>
        /// Matrícula do Veiculo
        /// </summary>
        [Display(Name = "Matrícula")]
        public string Matricula { get; set; }

        /// <summary>
        /// Potencia do Veiculo
        /// </summary>
        [Display(Name = "Potencia")]
        public string Potencia { get; set; }

        /// <summary>
        /// Potencia do Veiculo
        /// </summary>
        [Display(Name = "Cilindrada")]
        public string Cilindrada { get; set; }

        /// <summary>
        /// Numero de Kms do Veiculo
        /// </summary>
        [Display(Name = "Nº de Kms do Veiculo")]
        public int Km { get; set; }

        /// <summary>
        /// Tipo de condução do Veiculo (automatico/manual)
        /// </summary>
        [Display(Name = "Tipo de condução do Veiculo")]
        public int TipoConducao { get; set; }

        //********************************************************************************

        /// <summary>
        /// FK para identificar o CLiente
        /// </summary>
        [ForeignKey(nameof(Cliente))]
        public int IdCliente { get; set; }
        public Clientes Cliente { get; set; }


    }
}
