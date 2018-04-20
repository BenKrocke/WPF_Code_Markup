using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Practice
{
    public class ReplaceMainWindow : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ReplaceMainWindow());
        }

        public ReplaceMainWindow()
        {
            Title = "Render the graphic";

            SimpleEllipse elips = new SimpleEllipse();
            Content = elips;
        }
    }
}
