// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public static partial class BasedOn
    {
        private static void OnSolidColorBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var brush = (SolidColorBrush) d;
            var value = (SolidColorBrush) e.NewValue;

            if (brush.Color.A == 0)
            {
                brush.Color = value.Color;
            }

            if (brush.Opacity >= 1)
            {
                brush.Opacity = value.Opacity;
            }
        }
    }
}