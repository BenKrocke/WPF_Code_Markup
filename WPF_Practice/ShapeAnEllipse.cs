using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;


namespace WPF_Practice
{
    class ShapeAnEllipse : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ShapeAnEllipse());
        }

        public ShapeAnEllipse()
        {
            Title = "Shape an Ellipse";

            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.AliceBlue;
            ellipse.StrokeThickness = 24;
            ellipse.Stroke = new LinearGradientBrush(Colors.CadetBlue, Colors.Chocolate, new Point(1, 0), new Point(0, 1));
            ellipse.Width = 300;
            ellipse.Height = 300;
            Content = ellipse;
        }

    }
}
