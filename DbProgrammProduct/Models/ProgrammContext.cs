using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DbProgrammProduct.Models
{
    public class ProgrammContext : DbContext //Создание класса контекста
    {
        public ProgrammContext() : base("UchPraktikaEntities")
        {

        }
        public DbSet<Programm> Programms { get; set; }
    }
}
