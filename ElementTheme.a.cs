// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public static partial class ElementTheme
    {
        /// <summary>
        /// Identifies the Geometry dependency property.
        /// </summary>
        public static readonly DependencyProperty GeometryProperty = DependencyProperty.RegisterAttached("Geometry",
            typeof (Geometry), typeof (ElementTheme));

        /// <summary>
        /// Gets the Geometry dependency property.
        /// </summary>
        public static Geometry GetGeometry(FrameworkElement element)
        {
            return (Geometry) element.GetValue(GeometryProperty);
        }

        /// <summary>
        /// Sets the Geometry dependency property.
        /// </summary>
        public static void SetGeometry(FrameworkElement element, Geometry value)
        {
            element.SetValue(GeometryProperty, value);
        }
    }
}