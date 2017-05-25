using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApplication7
{
    class MyViewModel
    {
        public ICommand buttonCmd { set; get; }

        public ListBox listbox { set; get; }

        public MyViewModel(ListBox listbox)
        {
            this.listbox = listbox;

            buttonCmd = new RoutedCommand();
            CommandManager.RegisterClassCommandBinding(listbox.GetType(), new CommandBinding(buttonCmd, clickHandler));
        }

        private void clickHandler(object sender, ExecutedRoutedEventArgs e)
        {
            //var button = sender as Button;

            MessageBox.Show(sender.GetType().FullName);
        }
    }
}
