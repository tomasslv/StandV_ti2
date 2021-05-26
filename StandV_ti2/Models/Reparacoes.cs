using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StandV_ti2.Models
{
    public class Reparacoes
    {

        /// <summary>
        /// Identificador da Reparação
        /// </summary>
        [Key]
        public int IdReparacao { get; set; }

        //###########################################################################

        /// <summary>
        /// FK para o identificador do Funcionario que vai fazer a reparação
        /// </summary>
        [ForeignKey(nameof(Funcionario))]
        public int IdFuncionario { get; set; }
        public Funcionarios Funcionario { get; set; }

        /// <summary>
        /// Identificador do Veiculo que vai ser reparado
        /// </summary>
        [ForeignKey(nameof(Veiculo))]
        public int IdVeiculo { get; set; }
        public Veiculos Veiculo { get; set; }

        /// <summary>
        /// FK para o identificador do Gestor
        /// </summary>
        [ForeignKey(nameof(Gestor))]
        public int IdGestor { get; set; }
        public Gestores Gestor { get; set; }

        //##########################################################################

        /// <summary>
        /// Tipo de Avaria
        /// </summary>
        public string TipoAvaria { get; set; }

        /// <summary>
        /// Data da Reparação
        /// </summary>
        [Display(Name = "Data da Reparação")]
        public DateTime DataRepar { get; set; }

        /// <summary>
        /// Peças para Reparação
        /// </summary>
        [StringLength(20, ErrorMessage = "Não pode ter mais de 20 caracteres.")]
        [Display(Name = "Peças")]
        public string Pecas { get; set; }

        /// <summary>
        /// Estado da Reparação ("Em reparação" ou "Concluido")
        /// </summary>
        [Display(Name = "Estado")]
        public string Estado { get; set; }

    }
}
