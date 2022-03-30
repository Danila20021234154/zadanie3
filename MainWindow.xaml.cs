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
using System.Runtime;


namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



 
        

       
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
             void Main(string[] args)
            {
                string login = "апаарре";
                if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Неверная длина логина (не менее 2 и не более 10 символов");
                }

                if (Char.IsDigit(login[0]))
                {
                    Console.WriteLine("Неверный формат ввода логина");
                }
                bool flag = true;
                for (int i = 0; i < login.Length; i++)
                {
                    if (!Char.IsLetterOrDigit(login[i]))
                    {
                        flag = false;
                        Console.WriteLine("Введены недопустимые символы");
                        Console.ReadKey();
                        break;


                    }
                    if (flag)
                        Console.WriteLine("Логин корректен");
                    Console.ReadKey();



                }

            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            string symb = "ABCDEFGHIJKLMNOPRSTUVWXYZ123456789!\"#$%&'()*+,-./::<=>?@[\\]:_{|}";
            if (PasswordBox.IndexOfAny(symb.ToCharArray()) == -1)
                Console.Write("Пароль неверный");
        }
    }
}
       

 