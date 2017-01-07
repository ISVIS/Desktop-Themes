// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Isvis.Windows.Themes
{
    public partial class Designer
    {
        /// <summary>
        /// Gets or sets the Properties property.
        /// </summary>
        public ReadOnlyObservableCollection<Property> Properties
        {
            get { return (ReadOnlyObservableCollection<Property>) this.GetValue(PropertiesProperty); }

            set { this.SetValue(PropertiesProperty, value); }
        }

        /// <summary>
        /// Gets or sets the Target property.
        /// </summary>
        public DependencyObject Target
        {
            get { return (DependencyObject) this.GetValue(TargetProperty); }

            set { this.SetValue(TargetProperty, value); }
        }

        /// <summary>
        /// Gets or sets the TargetType property.
        /// </summary>
        public Type TargetType
        {
            get { return (Type) this.GetValue(TargetTypeProperty); }

            set { this.SetValue(TargetTypeProperty, value); }
        }

        /// <summary>
        /// Identifies the Properties dependency property.
        /// </summary>
        public static readonly DependencyProperty PropertiesProperty = DependencyProperty.Register(
            "Properties",
            typeof (ReadOnlyObservableCollection<Property>),
            typeof (Designer));

        /// <summary>
        /// Identifies the Target dependency property.
        /// </summary>
        public static readonly DependencyProperty TargetProperty = DependencyProperty.Register(
            "Target",
            typeof (DependencyObject),
            typeof (Designer));

        /// <summary>
        /// Identifies the TargetType dependency property.
        /// </summary>
        public static readonly DependencyProperty TargetTypeProperty = DependencyProperty.Register(
            "TargetType",
            typeof (Type),
            typeof (Designer));
    }
}