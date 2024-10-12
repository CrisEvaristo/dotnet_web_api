using System;
using System.ComponentModel.DataAnnotations;//Servem para especificar funcionalidades extras como o uso de uma chave primária, quantidade de informações de um campo, etc...
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Pessoa
    { 
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }    
        public string Cidade{get; set; }
        public int Idade{get; set; }

    }
}