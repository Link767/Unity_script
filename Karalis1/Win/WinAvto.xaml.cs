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

namespace Karalis1.Win
{
    /// <summary>
    /// Логика взаимодействия для WinAvto.xaml
    /// </summary>
    public partial class WinAvto : Window
    {
        public WinAvto()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            WinReg winReg = new WinReg();
            winReg.Show();
            this.Close();
        }

        private void Entrance_Click(object sender, RoutedEventArgs e)
        {
            WinGo winGo = new WinGo();
            winGo.Show();
            this.Close();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
