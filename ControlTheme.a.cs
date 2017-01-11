// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public static partial class ControlTheme
    {
        /// <summary>
        /// Identifies the Geometry dependency property.
        /// </summary>
        public static readonly DependencyProperty GeometryProperty = DependencyProperty.RegisterAttached("Geometry",
            typeof (Geometry), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Background dependency property.
        /// </summary>
        public static readonly DependencyProperty BackgroundProperty = DependencyProperty.RegisterAttached(
            "Background", typeof (Brush), typeof (ControlTheme), new PropertyMetadata(OnBackgroundChanged));

        /// <summary>
        /// Identifies the BorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.RegisterAttached("BorderBrush", typeof (Brush), typeof (ControlTheme),
                new PropertyMetadata(OnBorderBrushChanged));

        /// <summary>
        /// Identifies the BorderThickness dependency property.
        /// </summary>
        public static readonly DependencyProperty BorderThicknessProperty =
            DependencyProperty.RegisterAttached("BorderThickness", typeof (Thickness), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Foreground dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.RegisterAttached(
            "Foreground", typeof (Brush), typeof (ControlTheme), new PropertyMetadata(OnForegroundChanged));

        /// <summary>
        /// Identifies the CheckedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.RegisterAttached("CheckedBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the CheckedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.RegisterAttached("CheckedBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the CheckedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.RegisterAttached("CheckedForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the CornerRadius dependency property.
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof (CornerRadius), typeof (ControlTheme));

        /// <summary>
        /// Identifies the DisabledBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledBackgroundProperty =
            DependencyProperty.RegisterAttached("DisabledBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the DisabledBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledBorderBrushProperty =
            DependencyProperty.RegisterAttached("DisabledBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the DisabledForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledForegroundProperty =
            DependencyProperty.RegisterAttached("DisabledForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the FocusedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedBackgroundProperty =
            DependencyProperty.RegisterAttached("FocusedBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the FocusedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedBorderBrushProperty =
            DependencyProperty.RegisterAttached("FocusedBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the FocusedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedForegroundProperty =
            DependencyProperty.RegisterAttached("FocusedForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Height dependency property.
        /// </summary>
        public static readonly DependencyProperty HeightProperty = DependencyProperty.RegisterAttached("Height",
            typeof (double), typeof (ControlTheme));

        /// <summary>
        /// Identifies the HighlightedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedBackgroundProperty =
            DependencyProperty.RegisterAttached("HighlightedBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the HighlightedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedBorderBrushProperty =
            DependencyProperty.RegisterAttached("HighlightedBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the HighlightedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedForegroundProperty =
            DependencyProperty.RegisterAttached("HighlightedForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the IndeterminateBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateBackgroundProperty =
            DependencyProperty.RegisterAttached("IndeterminateBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the IndeterminateBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateBorderBrushProperty =
            DependencyProperty.RegisterAttached("IndeterminateBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the IndeterminateForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateForegroundProperty =
            DependencyProperty.RegisterAttached("IndeterminateForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the IsHighlighted dependency property.
        /// </summary>
        public static readonly DependencyProperty IsHighlightedProperty =
            DependencyProperty.RegisterAttached("IsHighlighted", typeof (bool), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Margin dependency property.
        /// </summary>
        public static readonly DependencyProperty MarginProperty = DependencyProperty.RegisterAttached("Margin",
            typeof (Thickness), typeof (ControlTheme));

        /// <summary>
        /// Identifies the NormalBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalBackgroundProperty =
            DependencyProperty.RegisterAttached("NormalBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the NormalBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalBorderBrushProperty =
            DependencyProperty.RegisterAttached("NormalBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the NormalForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalForegroundProperty =
            DependencyProperty.RegisterAttached("NormalForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Padding dependency property.
        /// </summary>
        public static readonly DependencyProperty PaddingProperty = DependencyProperty.RegisterAttached("Padding",
            typeof (Thickness), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PointerOverBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverBackgroundProperty =
            DependencyProperty.RegisterAttached("PointerOverBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PointerOverBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverBorderBrushProperty =
            DependencyProperty.RegisterAttached("PointerOverBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PointerOverForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverForegroundProperty =
            DependencyProperty.RegisterAttached("PointerOverForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PressedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.RegisterAttached("PressedBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PressedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedBorderBrushProperty =
            DependencyProperty.RegisterAttached("PressedBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the PressedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.RegisterAttached("PressedForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the SelectedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.RegisterAttached("SelectedBackground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the SelectedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.RegisterAttached("SelectedBorderBrush", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the SelectedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.RegisterAttached("SelectedForeground", typeof (Brush), typeof (ControlTheme));

        /// <summary>
        /// Identifies the Width dependency property.
        /// </summary>
        public static readonly DependencyProperty WidthProperty = DependencyProperty.RegisterAttached("Width",
            typeof (double), typeof (ControlTheme));

        /// <summary>
        /// Gets the Geometry dependency property.
        /// </summary>
        public static Geometry GetGeometry(Control element)
        {
            return (Geometry) element.GetValue(GeometryProperty);
        }

        /// <summary>
        /// Sets the Geometry dependency property.
        /// </summary>
        public static void SetGeometry(Control element, Geometry value)
        {
            element.SetValue(GeometryProperty, value);
        }

        /// <summary>
        /// Gets the Background dependency property.
        /// </summary>
        public static Brush GetBackground(Control element)
        {
            return (Brush) element.GetValue(BackgroundProperty);
        }

        /// <summary>
        /// Gets the BorderBrush dependency property.
        /// </summary>
        public static Brush GetBorderBrush(Control element)
        {
            return (Brush) element.GetValue(BorderBrushProperty);
        }

        /// <summary>
        /// Gets the BorderThickness dependency property.
        /// </summary>
        public static Thickness GetBorderThickness(Control element)
        {
            return (Thickness) element.GetValue(BorderThicknessProperty);
        }

        /// <summary>
        /// Gets the CheckedBackground dependency property.
        /// </summary>
        public static Brush GetCheckedBackground(Control element)
        {
            return (Brush) element.GetValue(CheckedBackgroundProperty);
        }

        /// <summary>
        /// Gets the CheckedBorderBrush dependency property.
        /// </summary>
        public static Brush GetCheckedBorderBrush(Control element)
        {
            return (Brush) element.GetValue(CheckedBorderBrushProperty);
        }

        /// <summary>
        /// Gets the CheckedForeground dependency property.
        /// </summary>
        public static Brush GetCheckedForeground(Control element)
        {
            return (Brush) element.GetValue(CheckedForegroundProperty);
        }

        /// <summary>
        /// Gets the CornerRadius dependency property.
        /// </summary>
        public static CornerRadius GetCornerRadius(Control element)
        {
            return (CornerRadius) element.GetValue(CornerRadiusProperty);
        }

        /// <summary>
        /// Gets the DisabledBackground dependency property.
        /// </summary>
        public static Brush GetDisabledBackground(Control element)
        {
            return (Brush) element.GetValue(DisabledBackgroundProperty);
        }

        /// <summary>
        /// Gets the DisabledBorderBrush dependency property.
        /// </summary>
        public static Brush GetDisabledBorderBrush(Control element)
        {
            return (Brush) element.GetValue(DisabledBorderBrushProperty);
        }

        /// <summary>
        /// Gets the DisabledForeground dependency property.
        /// </summary>
        public static Brush GetDisabledForeground(Control element)
        {
            return (Brush) element.GetValue(DisabledForegroundProperty);
        }

        /// <summary>
        /// Gets the FocusedBackground dependency property.
        /// </summary>
        public static Brush GetFocusedBackground(Control element)
        {
            return (Brush) element.GetValue(FocusedBackgroundProperty);
        }

        /// <summary>
        /// Gets the FocusedBorderBrush dependency property.
        /// </summary>
        public static Brush GetFocusedBorderBrush(Control element)
        {
            return (Brush) element.GetValue(FocusedBorderBrushProperty);
        }

        /// <summary>
        /// Gets the FocusedForeground dependency property.
        /// </summary>
        public static Brush GetFocusedForeground(Control element)
        {
            return (Brush) element.GetValue(FocusedForegroundProperty);
        }

        /// <summary>
        /// Gets the Foreground dependency property.
        /// </summary>
        public static Brush GetForeground(Control element)
        {
            return (Brush) element.GetValue(ForegroundProperty);
        }

        /// <summary>
        /// Gets the Height dependency property.
        /// </summary>
        public static double GetHeight(Control element)
        {
            return (double) element.GetValue(HeightProperty);
        }

        /// <summary>
        /// Gets the HighlightedBackground dependency property.
        /// </summary>
        public static Brush GetHighlightedBackground(Control element)
        {
            return (Brush) element.GetValue(HighlightedBackgroundProperty);
        }

        /// <summary>
        /// Gets the HighlightedBorderBrush dependency property.
        /// </summary>
        public static Brush GetHighlightedBorderBrush(Control element)
        {
            return (Brush) element.GetValue(HighlightedBorderBrushProperty);
        }

        /// <summary>
        /// Gets the HighlightedForeground dependency property.
        /// </summary>
        public static Brush GetHighlightedForeground(Control element)
        {
            return (Brush) element.GetValue(HighlightedForegroundProperty);
        }

        /// <summary>
        /// Gets the IndeterminateBackground dependency property.
        /// </summary>
        public static Brush GetIndeterminateBackground(Control element)
        {
            return (Brush) element.GetValue(IndeterminateBackgroundProperty);
        }

        /// <summary>
        /// Gets the IndeterminateBorderBrush dependency property.
        /// </summary>
        public static Brush GetIndeterminateBorderBrush(Control element)
        {
            return (Brush) element.GetValue(IndeterminateBorderBrushProperty);
        }

        /// <summary>
        /// Gets the IndeterminateForeground dependency property.
        /// </summary>
        public static Brush GetIndeterminateForeground(Control element)
        {
            return (Brush) element.GetValue(IndeterminateForegroundProperty);
        }

        /// <summary>
        /// Gets the IsHighlighted dependency property.
        /// </summary>
        public static bool GetIsHighlighted(Control element)
        {
            return (bool) element.GetValue(IsHighlightedProperty);
        }

        /// <summary>
        /// Gets the Margin dependency property.
        /// </summary>
        public static Thickness GetMargin(Control element)
        {
            return (Thickness) element.GetValue(MarginProperty);
        }

        /// <summary>
        /// Gets the NormalBackground dependency property.
        /// </summary>
        public static Brush GetNormalBackground(Control element)
        {
            return (Brush) element.GetValue(NormalBackgroundProperty);
        }

        /// <summary>
        /// Gets the NormalBorderBrush dependency property.
        /// </summary>
        public static Brush GetNormalBorderBrush(Control element)
        {
            return (Brush) element.GetValue(NormalBorderBrushProperty);
        }

        /// <summary>
        /// Gets the NormalForeground dependency property.
        /// </summary>
        public static Brush GetNormalForeground(Control element)
        {
            return (Brush) element.GetValue(NormalForegroundProperty);
        }

        /// <summary>
        /// Gets the Padding dependency property.
        /// </summary>
        public static Thickness GetPadding(Control element)
        {
            return (Thickness) element.GetValue(PaddingProperty);
        }

        /// <summary>
        /// Gets the PointerOverBackground dependency property.
        /// </summary>
        public static Brush GetPointerOverBackground(Control element)
        {
            return (Brush) element.GetValue(PointerOverBackgroundProperty);
        }

        /// <summary>
        /// Gets the PointerOverBorderBrush dependency property.
        /// </summary>
        public static Brush GetPointerOverBorderBrush(Control element)
        {
            return (Brush) element.GetValue(PointerOverBorderBrushProperty);
        }

        /// <summary>
        /// Gets the PointerOverForeground dependency property.
        /// </summary>
        public static Brush GetPointerOverForeground(Control element)
        {
            return (Brush) element.GetValue(PointerOverForegroundProperty);
        }

        /// <summary>
        /// Gets the PressedBackground dependency property.
        /// </summary>
        public static Brush GetPressedBackground(Control element)
        {
            return (Brush) element.GetValue(PressedBackgroundProperty);
        }

        /// <summary>
        /// Gets the PressedBorderBrush dependency property.
        /// </summary>
        public static Brush GetPressedBorderBrush(Control element)
        {
            return (Brush) element.GetValue(PressedBorderBrushProperty);
        }

        /// <summary>
        /// Gets the PressedForeground dependency property.
        /// </summary>
        public static Brush GetPressedForeground(Control element)
        {
            return (Brush) element.GetValue(PressedForegroundProperty);
        }

        /// <summary>
        /// Gets the SelectedBackground dependency property.
        /// </summary>
        public static Brush GetSelectedBackground(Control element)
        {
            return (Brush) element.GetValue(SelectedBackgroundProperty);
        }

        /// <summary>
        /// Gets the SelectedBorderBrush dependency property.
        /// </summary>
        public static Brush GetSelectedBorderBrush(Control element)
        {
            return (Brush) element.GetValue(SelectedBorderBrushProperty);
        }

        /// <summary>
        /// Gets the SelectedForeground dependency property.
        /// </summary>
        public static Brush GetSelectedForeground(Control element)
        {
            return (Brush) element.GetValue(SelectedForegroundProperty);
        }

        /// <summary>
        /// Gets the Width dependency property.
        /// </summary>
        public static double GetWidth(Control element)
        {
            return (double) element.GetValue(WidthProperty);
        }

        /// <summary>
        /// Sets the Background dependency property.
        /// </summary>
        public static void SetBackground(Control element, Brush value)
        {
            element.SetValue(BackgroundProperty, value);
        }

        /// <summary>
        /// Sets the BorderBrush dependency property.
        /// </summary>
        public static void SetBorderBrush(Control element, Brush value)
        {
            element.SetValue(BorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the BorderThickness dependency property.
        /// </summary>
        public static void SetBorderThickness(Control element, Thickness value)
        {
            element.SetValue(BorderThicknessProperty, value);
        }

        /// <summary>
        /// Sets the CheckedBackground dependency property.
        /// </summary>
        public static void SetCheckedBackground(Control element, Brush value)
        {
            element.SetValue(CheckedBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the CheckedBorderBrush dependency property.
        /// </summary>
        public static void SetCheckedBorderBrush(Control element, Brush value)
        {
            element.SetValue(CheckedBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the CheckedForeground dependency property.
        /// </summary>
        public static void SetCheckedForeground(Control element, Brush value)
        {
            element.SetValue(CheckedForegroundProperty, value);
        }

        /// <summary>
        /// Sets the CornerRadius dependency property.
        /// </summary>
        public static void SetCornerRadius(Control element, CornerRadius value)
        {
            element.SetValue(CornerRadiusProperty, value);
        }

        /// <summary>
        /// Sets the DisabledBackground dependency property.
        /// </summary>
        public static void SetDisabledBackground(Control element, Brush value)
        {
            element.SetValue(DisabledBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the DisabledBorderBrush dependency property.
        /// </summary>
        public static void SetDisabledBorderBrush(Control element, Brush value)
        {
            element.SetValue(DisabledBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the DisabledForeground dependency property.
        /// </summary>
        public static void SetDisabledForeground(Control element, Brush value)
        {
            element.SetValue(DisabledForegroundProperty, value);
        }

        /// <summary>
        /// Sets the FocusedBackground dependency property.
        /// </summary>
        public static void SetFocusedBackground(Control element, Brush value)
        {
            element.SetValue(FocusedBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the FocusedBorderBrush dependency property.
        /// </summary>
        public static void SetFocusedBorderBrush(Control element, Brush value)
        {
            element.SetValue(FocusedBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the FocusedForeground dependency property.
        /// </summary>
        public static void SetFocusedForeground(Control element, Brush value)
        {
            element.SetValue(FocusedForegroundProperty, value);
        }

        /// <summary>
        /// Sets the Foreground dependency property.
        /// </summary>
        public static void SetForeground(Control element, Brush value)
        {
            element.SetValue(ForegroundProperty, value);
        }

        /// <summary>
        /// Sets the Height dependency property.
        /// </summary>
        public static void SetHeight(Control element, double value)
        {
            element.SetValue(HeightProperty, value);
        }

        /// <summary>
        /// Sets the HighlightedBackground dependency property.
        /// </summary>
        public static void SetHighlightedBackground(Control element, Brush value)
        {
            element.SetValue(HighlightedBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the HighlightedBorderBrush dependency property.
        /// </summary>
        public static void SetHighlightedBorderBrush(Control element, Brush value)
        {
            element.SetValue(HighlightedBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the HighlightedForeground dependency property.
        /// </summary>
        public static void SetHighlightedForeground(Control element, Brush value)
        {
            element.SetValue(HighlightedForegroundProperty, value);
        }

        /// <summary>
        /// Sets the IndeterminateBackground dependency property.
        /// </summary>
        public static void SetIndeterminateBackground(Control element, Brush value)
        {
            element.SetValue(IndeterminateBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the IndeterminateBorderBrush dependency property.
        /// </summary>
        public static void SetIndeterminateBorderBrush(Control element, Brush value)
        {
            element.SetValue(IndeterminateBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the IndeterminateForeground dependency property.
        /// </summary>
        public static void SetIndeterminateForeground(Control element, Brush value)
        {
            element.SetValue(IndeterminateForegroundProperty, value);
        }

        /// <summary>
        /// Sets the IsHighlighted dependency property.
        /// </summary>
        public static void SetIsHighlighted(Control element, bool value)
        {
            element.SetValue(IsHighlightedProperty, value);
        }

        /// <summary>
        /// Sets the Margin dependency property.
        /// </summary>
        public static void SetMargin(Control element, Thickness value)
        {
            element.SetValue(MarginProperty, value);
        }

        /// <summary>
        /// Sets the NormalBackground dependency property.
        /// </summary>
        public static void SetNormalBackground(Control element, Brush value)
        {
            element.SetValue(NormalBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the NormalBorderBrush dependency property.
        /// </summary>
        public static void SetNormalBorderBrush(Control element, Brush value)
        {
            element.SetValue(NormalBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the NormalForeground dependency property.
        /// </summary>
        public static void SetNormalForeground(Control element, Brush value)
        {
            element.SetValue(NormalForegroundProperty, value);
        }

        /// <summary>
        /// Sets the Padding dependency property.
        /// </summary>
        public static void SetPadding(Control element, Thickness value)
        {
            element.SetValue(PaddingProperty, value);
        }

        /// <summary>
        /// Sets the PointerOverBackground dependency property.
        /// </summary>
        public static void SetPointerOverBackground(Control element, Brush value)
        {
            element.SetValue(PointerOverBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the PointerOverBorderBrush dependency property.
        /// </summary>
        public static void SetPointerOverBorderBrush(Control element, Brush value)
        {
            element.SetValue(PointerOverBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the PointerOverForeground dependency property.
        /// </summary>
        public static void SetPointerOverForeground(Control element, Brush value)
        {
            element.SetValue(PointerOverForegroundProperty, value);
        }

        /// <summary>
        /// Sets the PressedBackground dependency property.
        /// </summary>
        public static void SetPressedBackground(Control element, Brush value)
        {
            element.SetValue(PressedBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the PressedBorderBrush dependency property.
        /// </summary>
        public static void SetPressedBorderBrush(Control element, Brush value)
        {
            element.SetValue(PressedBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the PressedForeground dependency property.
        /// </summary>
        public static void SetPressedForeground(Control element, Brush value)
        {
            element.SetValue(PressedForegroundProperty, value);
        }

        /// <summary>
        /// Sets the SelectedBackground dependency property.
        /// </summary>
        public static void SetSelectedBackground(Control element, Brush value)
        {
            element.SetValue(SelectedBackgroundProperty, value);
        }

        /// <summary>
        /// Sets the SelectedBorderBrush dependency property.
        /// </summary>
        public static void SetSelectedBorderBrush(Control element, Brush value)
        {
            element.SetValue(SelectedBorderBrushProperty, value);
        }

        /// <summary>
        /// Sets the SelectedForeground dependency property.
        /// </summary>
        public static void SetSelectedForeground(Control element, Brush value)
        {
            element.SetValue(SelectedForegroundProperty, value);
        }

        /// <summary>
        /// Sets the Width dependency property.
        /// </summary>
        public static void SetWidth(Control element, double value)
        {
            element.SetValue(WidthProperty, value);
        }
    }
}