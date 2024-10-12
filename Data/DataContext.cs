using System;
using api.Models;//Importar todos os modelos 
using Microsoft.EntityFrameworkCore;// Responsavel pelas funções de base de dados
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {}
        public DbSet<Pessoa> pessoa { get; set;}
    }
}