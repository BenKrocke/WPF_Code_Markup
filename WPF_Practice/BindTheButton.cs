using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace WPF_Practice
{

    public class BindTheButton : Window
    {
        private bool isToggled = false;

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new BindTheButton());
        }
        public BindTheButton()
        {
            Title = "Bind the button";

            ToggleButton btn = new ToggleButton();
            btn.ToolTip = "This is my tooltip";
            btn.Content = "Make _Topmost";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.SetBinding(ToggleButton.IsCheckedProperty, "Topmost");
            btn.DataContext = this;
            Content = btn;
        }

        public void MakeBinding()
        {
            Binding binding = new Binding()
        }
    }
        
}
