using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgrammProduct.Models
{
    public class User //Класс для взаимодействия с базой данных
    {
        public int Id { get; set; } //Переменная Id для взаимодействия со столбцом Id
        public string Name { get; set; } //Переменная Name для взаимодействия со столбцом Name
        public string Familia { get; set; }  //Переменная Familia для взаимодействия со столбцом Familia
        public string Login { get; set; } //Переменная Login для взаимодействия со столбцом Login
        public string Password { get; set; } //Переменная Password для взаимодействия со столбцом Password
        public string TypeUser { get; set; } //Переменная TypeUser для взаимодействия со столбцом TypeUser
    }
}
