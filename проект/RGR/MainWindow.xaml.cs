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

namespace RGR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Переменная для обзначения этажа
        int floor = 1;
        bool isFirst = true;
        string enter;
        string exit;
        public MainWindow()
        {
            InitializeComponent();
        }

        //1 этаж
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            floor = 1;
            imgMain1.Visibility = Visibility.Visible;
            imgMain2.Visibility = Visibility.Collapsed;
            imgMain3.Visibility = Visibility.Collapsed;
        }

        //2 этаж
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            floor = 2;
            imgMain1.Visibility = Visibility.Collapsed;
            imgMain2.Visibility = Visibility.Visible;
            imgMain3.Visibility = Visibility.Collapsed;
        }

        //3 этаж
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            floor = 3;
            imgMain1.Visibility = Visibility.Collapsed;
            imgMain2.Visibility = Visibility.Collapsed;
            imgMain3.Visibility = Visibility.Visible;
        }

        //Маршрут
        private void btnSetM_Click(object sender, RoutedEventArgs e)
        {

        }

        //Нажали на кнопку
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (isFirst)
            {
                enter = GetInfo(e, "Вход");
                
                //MessageBox.Show("");
                isFirst = false;
            }
            else
            {
                exit = GetInfo(e, "Выход");
            }
        }

        public string GetInfo(RoutedEventArgs e, string data)
        {
            if (e.OriginalSource == r1)
            {
                r1.Content = "Вход";
                return (data);
            }
            if (e.OriginalSource == r2)
            {
                r2.Content = data;
                return "r2";
            }
            if (e.OriginalSource == r3)
            {
                r3.Content = data;
                return "r3";
            }
            if (e.OriginalSource == r4)
            {
                r4.Content = data;
                return "r4";
            }
            if (e.OriginalSource == r5)
            {
                r5.Content = data;
                return "r5";
            }
            if (e.OriginalSource == r6)
            {
                r6.Content = data;
                return "r6";
            }
            if (e.OriginalSource == r7)
            {
                r7.Content = data;
                return "r7";
            }
            if (e.OriginalSource == r8)
            {
                r8.Content = data;
                return "r8";
            }
            if (e.OriginalSource == r9)
            {
                r9.Content = data;
                return "r9";
            }
            if (e.OriginalSource == r10)
            {
                r10.Content = data;
                return "r10";
            }
            if (e.OriginalSource == r11)
            {
                r11.Content = data;
                return "r11";
            }
            if (e.OriginalSource == r12)
            {
                r12.Content = data;
                return "r12";
            }
            if (e.OriginalSource == r13)
            {
                r13.Content = data;
                return "r13";
            }
            if (e.OriginalSource == r14)
            {
                r14.Content = data;
                return "r14";
            }
            if (e.OriginalSource == r15)
            {
                r15.Content = data;
                return "r15";
            }
            if (e.OriginalSource == r16)
            {
                r16.Content = data;
                return "r16";
            }
            if (e.OriginalSource == r17)
            {
                r17.Content = data;
                return "r17";
            }
            if (e.OriginalSource == r18)
            {
                r18.Content = data;
                return "r18";
            }
            if (e.OriginalSource == r19)
            {
                r19.Content = data;
                return "r19";
            }
            if (e.OriginalSource == r20)
            {
                r20.Content = data;
                return "r20";
            }
            if (e.OriginalSource == r21)
            {
                r21.Content = data;
                return "r21";
            }
            if (e.OriginalSource == r22)
            {
                r22.Content = data;
                return "r22";
            }
            if (e.OriginalSource == r23)
            {
                r23.Content = data;
                return "r23";
            }
            if (e.OriginalSource == r24)
            {
                r24.Content = data;
                return "r24";
            }
            if (e.OriginalSource == r25)
            {
                r25.Content = data;
                return "r25";
            }
            if (e.OriginalSource == r26)
            {
                r26.Content = data;
                return "r26";
            }
            if (e.OriginalSource == r27)
            {
                r27.Content = data;
                return "r27";
            }
            if (e.OriginalSource == r28)
            {
                r28.Content = data;
                return "r28";
            }
            if (e.OriginalSource == r29)
            {
                r29.Content = data;
                return "r29";
            }
            if (e.OriginalSource == r30)
            {
                r30.Content = data;
                return "r30";
            }
            if (e.OriginalSource == r31)
            {
                r31.Content = data;
                return "r31";
            }
            if (e.OriginalSource == r32)
            {
                r32.Content = data;
                return "r32";
            }
            if (e.OriginalSource == r33)
            {
                r33.Content = data;
                return "r33";
            }
            if (e.OriginalSource == r34)
            {
                r34.Content = data;
                return "r34";
            }
            if (e.OriginalSource == r35)
            {
                r35.Content = data;
                return "r35";
            }
            if (e.OriginalSource == r36)
            {
                r36.Content = data;
                return "r36";
            }
            if (e.OriginalSource == r37)
            {
                r37.Content = data;
                return "r37";
            }
            if (e.OriginalSource == r38)
            {
                r38.Content = data;
                return "r38";
            }
            if (e.OriginalSource == r39)
            {
                r39.Content = data;
                return "r39";
            }
            if (e.OriginalSource == r40)
            {
                r40.Content = data;
                return "r40";
            }
            if (e.OriginalSource == r41)
            {
                r41.Content = data;
                return "r41";
            }
            if (e.OriginalSource == r42)
            {
                r42.Content = data;
                return "r42";
            }
            if (e.OriginalSource == r43)
            {
                r43.Content = data;
                return "r43";
            }
            if (e.OriginalSource == r44)
            {
                r44.Content = data;
                return "r44";
            }
            if (e.OriginalSource == r45)
            {
                r45.Content = data;
                return "r45";
            }
            if (e.OriginalSource == r46)
            {
                r46.Content = data;
                return "r46";
            }
            return "null";
        }
    }
}
