// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Windows.Media;

namespace Isvis.Windows.Themes.Extensions
{
    internal static class BrushExtension
    {
        public static SolidColorBrush Blend(this SolidColorBrush background, Brush foreground)
        {
            return background.Blend(foreground as SolidColorBrush);
        }

        public static SolidColorBrush Blend(this SolidColorBrush background, SolidColorBrush foreground)
        {
            if (foreground == null)
            {
                return background;
            }

            if (background == null)
            {
                return null;
            }

            var scale = (float) foreground.Opacity*foreground.Color.A/255;
            return
                new SolidColorBrush(
                    Color.Multiply(background.Color, 1.0f - scale) +
                    Color.Multiply(foreground.Color, scale))
                {
                    Opacity = Math.Min(background.Opacity + foreground.Opacity, 1.0)
                };
        }
    }
}