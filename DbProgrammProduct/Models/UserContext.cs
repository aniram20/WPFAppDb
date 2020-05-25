using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DbProgrammProduct.Models
{
    public class UserContext : DbContext //Создание класса контекста базы данных
    {
        public UserContext(): base("UchPraktikaEntities")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
