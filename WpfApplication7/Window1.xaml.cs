using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace WpfApplication7
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {

        /*
        //方式一，自己顶一个一个继承自DependencyObject的类，然后定义依赖项属性Name
        public Student s
        {
            set;get;
        }

        public Window1()
        {
            this.s = new Student()
            {
                Name = "zhangsan"
            };
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            s.Name = "lisi";
        }

    */

        //方式二，所有的wpf控件，包含Window和Page继承自DependencyObject,可以直接定义依赖项属性

        public Window1()
        {
            InitializeComponent();

            Name1 = "zhangsan";
        }


        public static readonly DependencyProperty dpName = DependencyProperty.
            Register("Name1", typeof(string), typeof(Window1));

        public string Name1
        {
            set
            {
                SetValue(dpName, value);
            }

            get
            {
                return (string)GetValue(dpName);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Name1 = "lisi";
        }
    }
}
