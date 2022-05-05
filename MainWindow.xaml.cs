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

namespace Задание_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Media.Brush color;
        bool colorFlag = true;
        public MainWindow()
        {
            InitializeComponent();



            Btn1.Click += new RoutedEventHandler(Btn1_Click);
            color = this.Background;
        }

        void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (colorFlag)
                this.Background = Brushes.Purple;
            else
                 this.Background = color;


            colorFlag = !colorFlag;
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
