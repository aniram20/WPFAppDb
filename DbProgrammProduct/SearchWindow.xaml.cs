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
using System.Windows.Shapes;
using DbProgrammProduct.Models;
using System.Data.Entity;

namespace DbProgrammProduct
{
    /// <summary>
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        ProgrammContext db; //Контекст данных
        public SearchWindow()
        {
            InitializeComponent();
            db = new ProgrammContext();
            db.Programms.Load();
            this.Closing += SearchWindow_Closing; //Реакция на закрытие окна
        }

        private void SearchWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) //Метод для реакции на закрытие окна
        {
            db.Dispose();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) //Перемещение окна мышью
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e) //Выход
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите выйти из приложения?",
                                          "Подтверждение действия",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
            else
            {
                return;
            }
        }
    }
}
