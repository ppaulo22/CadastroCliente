using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks; 

namespace CadastroCliente2.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Apelido { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        
        [StringLength(100)]
        public string Endereco { get; set; }
        
        [StringLength(100)]
        public string Bairro { get; set; }
        
        [StringLength(100)]
        public string Cidade { get; set; }

        [StringLength(100)]
        public string Estado { get; set; }

        [StringLength(100)]
        public string Observacoes { get; set; }
        
        public int SituacaoId { get; set; }

        [Range(0, 100, ErrorMessage = "A idade é um campo obrigatório.")]
        public int? Idade { get; set; }

        public Situacoes Situacao { get; set; }







}
}
