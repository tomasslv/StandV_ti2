using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StandV_ti2.Models
{
    public class ReparFunc
    {

        /// <summary>
        /// PK para a tabela do relacionamento entre Reparadores e Funcionários
        /// </summary>
        [Key]
        public int Id { get; set; }

        //******************************************************************************************

        /// <summary>
        /// FK para a Reparação
        /// </summary>
        [ForeignKey(nameof(Reparacao))]
        public int ReparFK { get; set; }
        public Reparacoes Reparacao { get; set; }


        /// <summary>
        /// FK para o(s) Funcionário(s)
        /// </summary>
        [ForeignKey(nameof(Funcionario))]
        public int FuncionarioFK { get; set; }
        public Funcionarios Funcionario { get; set; }

    }
}
