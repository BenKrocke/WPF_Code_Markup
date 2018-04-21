using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPF_Practice
{
    class CommandTheButton : Window
    {

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new CommandTheButton());
        }
        public CommandTheButton()
        {
            Title = "Bind the button";

            Button btn = new Button();
            btn.ToolTip = "This is my tooltip";
            btn.Content = "Show alert";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.Command = ApplicationCommands.Paste;
            btn.Content = ApplicationCommands.Paste.Text;
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, OnPasteExecuted, CanPasteExecute));
            Content = btn;
        }

        private void OnPasteExecuted(object sender, ExecutedRoutedEventArgs args)
        {
            Title = Clipboard.GetText();
        }
        
        private void CanPasteExecute(object sender, CanExecuteRoutedEventArgs args)
        {
            args.CanExecute = Clipboard.ContainsText();
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Title = "Command the button";
        }
    }
}
