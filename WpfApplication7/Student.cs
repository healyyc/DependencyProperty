using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication7
{
    public class Student:DependencyObject
    {
        public static readonly DependencyProperty dpName = DependencyProperty.
            Register("Name", typeof(string), typeof(Student));

        public string Name
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
    }
}
