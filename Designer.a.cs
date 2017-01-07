// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Controls;

namespace Isvis.Windows.Themes
{
    public partial class Designer
    {
        /// <summary>
        /// Identifies the IsActive dependency property.
        /// </summary>
        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.RegisterAttached(
            "IsActive",
            typeof (bool),
            typeof (Designer),
            new PropertyMetadata(false, OnIsActiveChanged));

        /// <summary>
        /// Gets the IsActive dependency property.
        /// </summary>
        public static bool GetIsActive(Control element)
        {
            return (bool) element.GetValue(IsActiveProperty);
        }

        /// <summary>
        /// Sets the IsActive dependency property.
        /// </summary>
        public static void SetIsActive(Control element, bool value)
        {
            element.SetValue(IsActiveProperty, value);
        }
    }
}