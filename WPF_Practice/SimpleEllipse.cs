﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace WPF_Practice
{
    //Element
    class SimpleEllipse : FrameworkElement
    {
        //When rendering this class as content get this;
        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawEllipse(Brushes.Blue, new Pen(Brushes.Red, 24), new Point(RenderSize.Width / 2, RenderSize.Height / 2), RenderSize.Width / 2, RenderSize.Height / 2);
        }
    }
}
