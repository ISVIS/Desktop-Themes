// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public static partial class BasedOn
    {
        /// <summary>
        /// Identifies the SolidColorBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty SolidColorBrushProperty =
            DependencyProperty.RegisterAttached(
                "SolidColorBrush",
                typeof (SolidColorBrush),
                typeof (BasedOn),
                new PropertyMetadata(OnSolidColorBrushChanged));

        /// <summary>
        /// Gets the SolidColorBrush dependency property.
        /// </summary>
        public static SolidColorBrush GetSolidColorBrush(SolidColorBrush element)
        {
            return (SolidColorBrush) element.GetValue(SolidColorBrushProperty);
        }

        /// <summary>
        /// Sets the SolidColorBrush dependency property.
        /// </summary>
        public static void SetSolidColorBrush(SolidColorBrush element, SolidColorBrush value)
        {
            element.SetValue(SolidColorBrushProperty, value);
        }
    }
}