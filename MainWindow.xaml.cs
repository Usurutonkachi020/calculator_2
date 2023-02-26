using System;
using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement elem in MainWiew.Children)
            {
                if (elem is Button)
                {
                    ((Button)elem).Click += Button_Click;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string st = (string)((Button)e.OriginalSource).Content;

            if (st == "C")
                strLabel.Text = "";
            else if(st == "=")
            {
                string value = new DataTable().Compute(strLabel.Text,null).ToString();
                strLabel.Text = value;
            }
            else
            strLabel.Text += st;

        }
    }
}
