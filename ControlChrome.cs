// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Isvis.Windows.Themes.Extensions;

namespace Isvis.Windows.Themes
{
    public partial class ControlChrome : Border
    {
        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var elementChrome = (ControlChrome)d;
            elementChrome.OnPropertyChanged();
        }

        static ControlChrome()
        {
            CornerRadiusProperty.OverrideMetadata(typeof(ControlChrome),
                new FrameworkPropertyMetadata(new CornerRadius(0), OnPropertyChanged, (d, v) => v));
        }

        public ControlChrome()
        {
            this.Loaded += this.ElementChromeLoaded;
        }

        private void ElementChromeLoaded(object sender, RoutedEventArgs e)
        {
            this.OnPropertyChanged();
        }

        private void OnPropertyChanged()
        {
            var background = (SolidColorBrush)this.NormalBackground;
            var borderBrush = (SolidColorBrush)this.NormalBorderBrush;
            var foreground = (SolidColorBrush)this.NormalForeground;

            if (this.RenderFocused)
            {
                background = background.Blend(this.FocusedBackground);
                borderBrush = borderBrush.Blend(this.FocusedBorderBrush);
                foreground = foreground.Blend(this.FocusedForeground);
            }

            if (this.RenderHighlighted)
            {
                background = background.Blend(this.HighlightedBackground);
                borderBrush = borderBrush.Blend(this.HighlightedBorderBrush);
                foreground = foreground.Blend(this.HighlightedForeground);
            }

            if (this.RenderChecked == true)
            {
                background = background.Blend(this.CheckedBackground);
                borderBrush = borderBrush.Blend(this.CheckedBorderBrush);
                foreground = foreground.Blend(this.CheckedForeground);
            }

            if (this.RenderChecked == null)
            {
                background = background.Blend(this.IndeterminateBackground);
                borderBrush = borderBrush.Blend(this.IndeterminateBorderBrush);
                foreground = foreground.Blend(this.IndeterminateForeground);
            }

            if (this.RenderSelected)
            {
                background = background.Blend(this.SelectedBackground);
                borderBrush = borderBrush.Blend(this.SelectedBorderBrush);
                foreground = foreground.Blend(this.SelectedForeground);
            }

            if (this.RenderPointerOver)
            {
                background = background.Blend(this.PointerOverBackground);
                borderBrush = borderBrush.Blend(this.PointerOverBorderBrush);
                foreground = foreground.Blend(this.PointerOverForeground);
            }

            if (this.RenderPressed)
            {
                background = background.Blend(this.PressedBackground);
                borderBrush = borderBrush.Blend(this.PressedBorderBrush);
                foreground = foreground.Blend(this.PressedForeground);
            }

            if (!this.RenderEnabled)
            {
                background = background.Blend(this.DisabledBackground);
                borderBrush = borderBrush.Blend(this.DisabledBorderBrush);
                foreground = foreground.Blend(this.DisabledForeground);
            }

            this.Background = background;
            this.Foreground = foreground;
            this.BorderBrush = borderBrush;
        }
    }
}