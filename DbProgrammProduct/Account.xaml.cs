using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DbProgrammProduct.Models;
using System.Data.Entity;

namespace DbProgrammProduct
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        ProgrammContext db; //Контекст данных
        public Account()
        {
            InitializeComponent();
            db = new ProgrammContext();
            db.Programms.Load(); //Загрузка данных
            listProgramms.ItemsSource = db.Programms.Local.ToBindingList(); //Привязка данных к ListView
        }
    }
}
