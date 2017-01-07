// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Isvis.Windows.Themes
{
    public partial class Designer : ContextMenu
    {
        private static void OnIsActiveChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var target = d;
            if (target == null || target is Designer)
            {
                return;
            }

            var active = (bool) e.NewValue;
            if (!active)
            {
                return;
            }

            var designer = new Designer {Target = target, TargetType = target.GetType()};
            var control = d as Control;

            if (control == null)
            {
                return;
            }

            control.ContextMenu = designer;
            control.ContextMenu.Opened += ContextMenuOpened;
        }

        static Designer()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof (Designer), new FrameworkPropertyMetadata(typeof (Designer)));
        }

        private static void ContextMenuOpened(object sender, RoutedEventArgs e)
        {
            var designer = (Designer) sender;
            var target = designer.PlacementTarget;

            var properties =
                TypeDescriptor.GetProperties(
                    target,
                    new Attribute[] {new PropertyFilterAttribute(PropertyFilterOptions.All)})
                    .Cast<PropertyDescriptor>()
                    .Select(DependencyPropertyDescriptor.FromProperty)
                    .Where(t => t != null && t.IsAttached && t.DisplayName.StartsWith("Control"));
            var collection = new ObservableCollection<Property>();
            foreach (var property in
                properties)
            {
                collection.Add(new Property(target, property));
            }

            designer.Properties = new ReadOnlyObservableCollection<Property>(collection);
        }
    }
}