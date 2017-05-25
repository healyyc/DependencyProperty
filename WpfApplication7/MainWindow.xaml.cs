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

namespace WpfApplication7
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.listbox.ItemsSource = new List<string>()
            {
                "zhangsan",
                "zhangsan",
                "zhangsan",
                "zhangsan",
                "zhangsan",
                "zhangsan",
                "zhangsan"
            };

            //ICommand buttonClick = new RoutedCommand();

            //CommandManager.RegisterClassCommandBinding(this.GetType(), new CommandBinding(buttonClick, clickHandler));

            this.listbox.DataContext = new MyViewModel(this.listbox);
        }

        //private void clickHandler(object sender, ExecutedRoutedEventArgs e)
        //{
        //    var button = sender as Button;

        //    MessageBox.Show(button.Tag.ToString());
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    var button = sender as Button;

        //    MessageBox.Show(button.Tag.ToString());
        //}
    }
}
