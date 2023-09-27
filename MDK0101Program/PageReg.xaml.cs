using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace MDK0101Program
{
    /// <summary>
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
        }

        private void Reg_Btn(object sender, RoutedEventArgs e)
        {
            string surname = TB_Surname.Text.Trim();
            string name = TB_Name.Text.Trim();
            string otch = TB_Otch.Text.Trim();
            string login = TB_Login.Text.Trim();
            string password = PB_Password.Password.Trim();
            string pol = CB_Pol.Text.Trim();
            var DateBirthday = Convert.ToDateTime(DP_Date.SelectedDate);
            string role = CB_Role.Text.Trim();

            Regex pass1 = new Regex("[A-Z]");
            Regex pass2 = new Regex("[a-z]");
            Regex pass3 = new Regex("[0-9]");
            Regex pass4 = new Regex(@"[!@#$%^&*()_+{}\[\]:;<>,.?~\\-]");
            Regex pass5 = new Regex(".");

            if (pass1.IsMatch(PB_Password.Password) == false)
            {
                PB_Password.ToolTip = "Это поле введено не корректно";
                PB_Password.Background = Brushes.LightCoral;
                MessageBox.Show("Пароль должен содержать хотя бы 1 заглавную латискую букву");
            }
            else if (pass2.Matches(PB_Password.Password).Count < 3)
            {
                PB_Password.ToolTip = "Это поле введено не корректно";
                PB_Password.Background = Brushes.LightCoral;
                MessageBox.Show("Пароль должен содержать не менее 3 прописных латинских символов");
            }
            else if (pass3.Matches(PB_Password.Password).Count < 2)
            {
                PB_Password.ToolTip = "Это поле введено не корректно";
                PB_Password.Background = Brushes.LightCoral;
                MessageBox.Show("Пароль должен содержать минимум 2 цифры");
            }
            else if (pass4.IsMatch(PB_Password.Password) == false)
            {
                PB_Password.ToolTip = "Это поле введено не корректно";
                PB_Password.Background = Brushes.LightCoral;
                MessageBox.Show("Пароль должен содержать хотя бы 1 спецсимвол");
            }
            else if (pass5.Matches(PB_Password.Password).Count < 8)
            {
                PB_Password.ToolTip = "Это поле введено не корректно";
                PB_Password.Background = Brushes.LightCoral;
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
            }
            else if(true)
            {
                PB_Password.ToolTip = "";
                PB_Password.Background = Brushes.Transparent;
                MessageBox.Show("Вы зарегистрировались!");
            }
           // if(true)
            //else if (addUser.fio != null && addUser.login != null && addUser.password != null && addUser.idGender != 0 && addUser.dataBirthday != null)
            //{
            //    BaseClass.EM.Users.Add(addUser);
            //    BaseClass.EM.SaveChanges();
            //    MessageBox.Show("Регистрация прошла успешно");
            //    FrameClass.FrameProject.Navigate(new MainPage());
            //}
           // else MessageBox.Show("Пожалуйста, заполните все поля!");
        }
        //User newUser = new User()
        //{

        //    Name = TBName.Text,
        //    Surname = TBSurname.Text,
        //    DateBirthday = Convert.ToDateTime(DPdate.SelectedDate),
        //    Role = ((UserRole)CBRole.SelectedItem).id, // определяем роль
        //    Login = TBLogin.Text,
        //    Password = PBPass.Password.GetHashCode()
        //};
        //Base.dataBase.User.Add(newUser);
        //Base.dataBase.SaveChanges();
       // MessageBox.Show("Пользователь добавлен");
        }
    }

