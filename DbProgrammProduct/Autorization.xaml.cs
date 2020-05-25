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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Page 
    {
        UserContext db;    //Использование контекста данных
        public Autorization()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); //Выход из приложения
        }

        private void RegUser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Registration.xaml", UriKind.Relative)); //Переход к другой странице
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (tb_login.Text.Length > 0) //Проверка введения логина
            {
                if (pb_password.Password.Length > 0) //Проверка введения пароля
                {
                    User user = new User();
                    if(tb_login.Text==user.Login) //Проверка соответствия логина
                    {
                        if(pb_password.Password==user.Password) //Проверка соответствия пароля
                        {
                            SearchWindow searchWindow = new SearchWindow();
                            searchWindow.Show();
                            Application.Current.MainWindow.Close(); //Переход к окну SearchWindow
                        }
                        else //Сообщение о неправильном пароле
                        {
                           MessageBoxResult result = MessageBox.Show("Пароль введён неверно!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            if (result==MessageBoxResult.OK)
                            {
                                return;
                            }
                        }
                    }
                    else //Сообщение о неправильном логине
                    {
                        MessageBoxResult result = MessageBox.Show("Введите правильный логин или зарегистрируйтесь!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        if (result==MessageBoxResult.OK)
                        {
                            return;
                        }
                    }
                }
                else //Сообщение об отсутствии пароля
                {
                    MessageBoxResult result = MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    if (result==MessageBoxResult.OK)
                    {
                        return;
                    }
                }
            }
            else //Сообщение об отсутствии логина
            {
                MessageBoxResult result = MessageBox.Show("Введите логин!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result==MessageBoxResult.OK)
                {
                    return;
                }
            }
        }
    }
}
