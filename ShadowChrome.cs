// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public sealed class ShadowChrome : Decorator
    {
        public Color Color
        {
            get { return (Color) this.GetValue(ColorProperty); }

            set { this.SetValue(ColorProperty, value); }
        }

        public double Depth
        {
            get { return (double) this.GetValue(DepthProperty); }

            set { this.SetValue(DepthProperty, value); }
        }

        public bool IsActive
        {
            get { return (bool) this.GetValue(IsActiveProperty); }

            set { this.SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty ColorProperty = DependencyProperty.Register(
            "Color",
            typeof (Color),
            typeof (ShadowChrome),
            new FrameworkPropertyMetadata(Color.FromArgb(16, 0, 0, 0), FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty DepthProperty = DependencyProperty.Register(
            "Depth",
            typeof (double),
            typeof (ShadowChrome),
            new FrameworkPropertyMetadata(2.0, FrameworkPropertyMetadataOptions.AffectsRender));

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive",
            typeof (bool),
            typeof (ShadowChrome),
            new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));

        protected override void OnRender(DrawingContext drawingContext)
        {
            if (!this.IsActive)
            {
                return;
            }

            var color = this.Color;
            var depth = this.Depth;

            var rectangle = new Rect(new Point(depth, depth), new Size(this.RenderSize.Width, this.RenderSize.Height));
            if (rectangle.Width > 0.0 && rectangle.Height > 0.0 && color.A > 0)
            {
                drawingContext.DrawRectangle(new SolidColorBrush(color), null, rectangle);
            }
        }
    }
}