using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbProgrammProduct.Models
{
    public class Programm //Класс для взаимодействия с базой данных
    {
        public int Id { get; set; } //Переменная Id для взаимодействия со столбцом Id
        public string Title { get; set; } //Переменная Title для взаимодействия со столбцом Title
        public string Number { get; set; } //Переменная Number для взаимодействия со столбцом Number
        public string Name { get; set; } //Переменная Name для взаимодействия со столбцом Name
        public string Date { get; set; } //Переменная Date для взаимодействия со столбцом Date
    }
}
