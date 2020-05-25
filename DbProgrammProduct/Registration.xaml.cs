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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Page
    {
        UserContext db; //Контекст данных
        public Registration()
        {
            InitializeComponent();
            db = new UserContext();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Autorization.xaml", UriKind.Relative)); //Возвращение назад
        }

        private void Regin_Click(object sender, RoutedEventArgs e) //Регистрация нового пользователя
        {
            User user = new User();
            string userlogin = user.Login;
            if (tb_name.Text.Length>0) //Проверка введения имени
            {
                if (tb_familia.Text.Length>0) //Проверка введения фамилии
                {
                    if (tb_reginlog.Text.Length>0 & tb_reginlog.Text!=userlogin) //Проверка введения логина и отсутствия повторения логина
                    {
                        if (pb_reginpass.Password.Length>0) //Проверка введения пароля
                        {
                            if (regtype.Text.Length>0) //Проверка выбора типа пользователя
                            {
                                user.Name = tb_name.Text; //Получение имени
                                user.Familia = tb_familia.Text; //Получение фамилии
                                user.Login = tb_reginlog.Text; //Получение логина
                                user.Password = pb_reginpass.Password; //Получение пароля
                                user.TypeUser = regtype.Text; //Получения типа пользователя
                                db.Users.Add(user); //Добавление в базу данных
                                db.SaveChanges(); //Сохранение изменений
                                SearchWindow searchWindow = new SearchWindow();
                                searchWindow.Show();
                                Application.Current.MainWindow.Close(); //Переход ко второму окну
                            }
                            else //Не выбран тип учётной записи
                            {
                                MessageBoxResult result = MessageBox.Show("Выберите тип учётной записи!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                                if (result == MessageBoxResult.OK)
                                {
                                    return;
                                }
                            }
                        }
                        else //Не введён пароль
                        {
                            MessageBoxResult result = MessageBox.Show("Введите пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            if (result == MessageBoxResult.OK)
                            {
                                return;
                            }
                        }
                    }
                    else //Не введён пароль или логин занят
                    {
                        MessageBoxResult result = MessageBox.Show("Логин уже занят или пустое поле!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        if (result == MessageBoxResult.OK)
                        {
                            return;
                        }
                    }
                }
                else //Не введена фамилия
                {
                    MessageBoxResult result = MessageBox.Show("Введите фамилию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    if (result == MessageBoxResult.OK)
                    {
                        return;
                    }
                }
            }
            else //Не введено имя
            {
                MessageBoxResult result = MessageBox.Show("Введите имя!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                if (result == MessageBoxResult.OK)
                {
                    return;
                }
            }
        }
    }
}
