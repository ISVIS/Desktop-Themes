// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Isvis.Windows.Themes
{
    public static partial class ControlTheme
    {
        private static void OnBackgroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateValue(d, NormalBackgroundProperty, e.NewValue);
            UpdateValue(d, FocusedBackgroundProperty, e.NewValue);
            UpdateValue(d, HighlightedBackgroundProperty, e.NewValue);
            UpdateValue(d, PointerOverBackgroundProperty, e.NewValue);
            UpdateValue(d, PressedBackgroundProperty, e.NewValue);
            UpdateValue(d, CheckedBackgroundProperty, e.NewValue);
            UpdateValue(d, IndeterminateBackgroundProperty, e.NewValue);
            UpdateValue(d, DisabledBackgroundProperty, e.NewValue);
        }

        private static void OnBorderBrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateValue(d, NormalBorderBrushProperty, e.NewValue);
            UpdateValue(d, FocusedBorderBrushProperty, e.NewValue);
            UpdateValue(d, HighlightedBorderBrushProperty, e.NewValue);
            UpdateValue(d, PointerOverBorderBrushProperty, e.NewValue);
            UpdateValue(d, PressedBorderBrushProperty, e.NewValue);
            UpdateValue(d, CheckedBorderBrushProperty, e.NewValue);
            UpdateValue(d, IndeterminateBorderBrushProperty, e.NewValue);
            UpdateValue(d, DisabledBorderBrushProperty, e.NewValue);
        }

        private static void OnForegroundChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UpdateValue(d, NormalForegroundProperty, e.NewValue);
            UpdateValue(d, FocusedForegroundProperty, e.NewValue);
            UpdateValue(d, HighlightedForegroundProperty, e.NewValue);
            UpdateValue(d, PointerOverForegroundProperty, e.NewValue);
            UpdateValue(d, PressedForegroundProperty, e.NewValue);
            UpdateValue(d, CheckedForegroundProperty, e.NewValue);
            UpdateValue(d, IndeterminateForegroundProperty, e.NewValue);
            UpdateValue(d, DisabledForegroundProperty, e.NewValue);
        }

        private static void OnBorderThicknessChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
        }

        private static void UpdateValue(DependencyObject d, DependencyProperty p, object v)
        {
            var element = (Control) d;
            var style = element.Style;
            while (style != null)
            {
                var setters = style.Setters.OfType<Setter>().ToList();
                if (setters.Any(t => t.Property == Control.TemplateProperty))
                {
                    break;
                }

                if (setters.Any(setter => setter.Property == p))
                {
                    return;
                }

                style = style.BasedOn;
            }

            // TODO: Check local properties.
            //if (d.ReadLocalValue(p) != DependencyProperty.UnsetValue)
            //{
            //    return;
            //}

            //var local = d.GetLocalValueEnumerator();
            //while (local.MoveNext())
            //{
            //    var propertyToClear = local.Current.Property;
            //    if (propertyToClear == p)
            //    {
            //    }
            //}

            if (v == null)
            {
                d.ClearValue(p);
            }
            else
            {
                d.SetCurrentValue(p, v);
            }
        }
    }
}