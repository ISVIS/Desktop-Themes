// Copyright © ISVIS Ltd. All Rights Reserved. Licensed under the MIT License. See License.txt in the project root for license information.

using System.Windows;
using System.Windows.Media;

namespace Isvis.Windows.Themes
{
    public partial class ControlChrome
    {
        /// <summary>
        /// Gets or sets the CheckedBackground property.
        /// </summary>
        public Brush CheckedBackground
        {
            get { return (Brush) this.GetValue(CheckedBackgroundProperty); }

            set { this.SetValue(CheckedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the CheckedBorderBrush property.
        /// </summary>
        public Brush CheckedBorderBrush
        {
            get { return (Brush) this.GetValue(CheckedBorderBrushProperty); }

            set { this.SetValue(CheckedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the CheckedForeground property.
        /// </summary>
        public Brush CheckedForeground
        {
            get { return (Brush) this.GetValue(CheckedForegroundProperty); }

            set { this.SetValue(CheckedForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the DisabledBackground property.
        /// </summary>
        public Brush DisabledBackground
        {
            get { return (Brush) this.GetValue(DisabledBackgroundProperty); }

            set { this.SetValue(DisabledBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the DisabledBorderBrush property.
        /// </summary>
        public Brush DisabledBorderBrush
        {
            get { return (Brush) this.GetValue(DisabledBorderBrushProperty); }

            set { this.SetValue(DisabledBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the DisabledForeground property.
        /// </summary>
        public Brush DisabledForeground
        {
            get { return (Brush) this.GetValue(DisabledForegroundProperty); }

            set { this.SetValue(DisabledForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the FocusedBackground property.
        /// </summary>
        public Brush FocusedBackground
        {
            get { return (Brush) this.GetValue(FocusedBackgroundProperty); }

            set { this.SetValue(FocusedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the FocusedBorderBrush property.
        /// </summary>
        public Brush FocusedBorderBrush
        {
            get { return (Brush) this.GetValue(FocusedBorderBrushProperty); }

            set { this.SetValue(FocusedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the FocusedForeground property.
        /// </summary>
        public Brush FocusedForeground
        {
            get { return (Brush) this.GetValue(FocusedForegroundProperty); }

            set { this.SetValue(FocusedForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the NormalForeground property.
        /// </summary>
        public Brush Foreground
        {
            get { return (Brush) this.GetValue(ForegroundProperty); }

            set { this.SetValue(ForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the HighlightedBackground property.
        /// </summary>
        public Brush HighlightedBackground
        {
            get { return (Brush) this.GetValue(HighlightedBackgroundProperty); }

            set { this.SetValue(HighlightedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the HighlightedBorderBrush property.
        /// </summary>
        public Brush HighlightedBorderBrush
        {
            get { return (Brush) this.GetValue(HighlightedBorderBrushProperty); }

            set { this.SetValue(HighlightedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the HighlightedForeground property.
        /// </summary>
        public Brush HighlightedForeground
        {
            get { return (Brush) this.GetValue(HighlightedForegroundProperty); }

            set { this.SetValue(HighlightedForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the IndeterminateBackground property.
        /// </summary>
        public Brush IndeterminateBackground
        {
            get { return (Brush) this.GetValue(IndeterminateBackgroundProperty); }

            set { this.SetValue(IndeterminateBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the IndeterminateBorderBrush property.
        /// </summary>
        public Brush IndeterminateBorderBrush
        {
            get { return (Brush) this.GetValue(IndeterminateBorderBrushProperty); }

            set { this.SetValue(IndeterminateBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the IndeterminateForeground property.
        /// </summary>
        public Brush IndeterminateForeground
        {
            get { return (Brush) this.GetValue(IndeterminateForegroundProperty); }

            set { this.SetValue(IndeterminateForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the NormalBackground property.
        /// </summary>
        public Brush NormalBackground
        {
            get { return (Brush) this.GetValue(NormalBackgroundProperty); }

            set { this.SetValue(NormalBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the NormalBorderBrush property.
        /// </summary>
        public Brush NormalBorderBrush
        {
            get { return (Brush) this.GetValue(NormalBorderBrushProperty); }

            set { this.SetValue(NormalBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the NormalForeground property.
        /// </summary>
        public Brush NormalForeground
        {
            get { return (Brush) this.GetValue(NormalForegroundProperty); }

            set { this.SetValue(NormalForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PointerOverBackground property.
        /// </summary>
        public Brush PointerOverBackground
        {
            get { return (Brush) this.GetValue(PointerOverBackgroundProperty); }

            set { this.SetValue(PointerOverBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PointerOverBorderBrush property.
        /// </summary>
        public Brush PointerOverBorderBrush
        {
            get { return (Brush) this.GetValue(PointerOverBorderBrushProperty); }

            set { this.SetValue(PointerOverBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PointerOverForeground property.
        /// </summary>
        public Brush PointerOverForeground
        {
            get { return (Brush) this.GetValue(PointerOverForegroundProperty); }

            set { this.SetValue(PointerOverForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PressedBackground property.
        /// </summary>
        public Brush PressedBackground
        {
            get { return (Brush) this.GetValue(PressedBackgroundProperty); }

            set { this.SetValue(PressedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PressedBorderBrush property.
        /// </summary>
        public Brush PressedBorderBrush
        {
            get { return (Brush) this.GetValue(PressedBorderBrushProperty); }

            set { this.SetValue(PressedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the PressedForeground property.
        /// </summary>
        public Brush PressedForeground
        {
            get { return (Brush) this.GetValue(PressedForegroundProperty); }

            set { this.SetValue(PressedForegroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderChecked property.
        /// </summary>
        public bool? RenderChecked
        {
            get { return (bool?) this.GetValue(RenderCheckedProperty); }

            set { this.SetValue(RenderCheckedProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderEnabled property.
        /// </summary>
        public bool RenderEnabled
        {
            get { return (bool) this.GetValue(RenderEnabledProperty); }

            set { this.SetValue(RenderEnabledProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderFocused property.
        /// </summary>
        public bool RenderFocused
        {
            get { return (bool) this.GetValue(RenderFocusedProperty); }

            set { this.SetValue(RenderFocusedProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderHighlighted property.
        /// </summary>
        public bool RenderHighlighted
        {
            get { return (bool) this.GetValue(RenderHighlightedProperty); }

            set { this.SetValue(RenderHighlightedProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderPointerOver property.
        /// </summary>
        public bool RenderPointerOver
        {
            get { return (bool) this.GetValue(RenderPointerOverProperty); }

            set { this.SetValue(RenderPointerOverProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderPressed property.
        /// </summary>
        public bool RenderPressed
        {
            get { return (bool) this.GetValue(RenderPressedProperty); }

            set { this.SetValue(RenderPressedProperty, value); }
        }

        /// <summary>
        /// Gets or sets the RenderSelected property.
        /// </summary>
        public bool RenderSelected
        {
            get { return (bool) this.GetValue(RenderSelectedProperty); }

            set { this.SetValue(RenderSelectedProperty, value); }
        }

        /// <summary>
        /// Gets or sets the SelectedBackground property.
        /// </summary>
        public Brush SelectedBackground
        {
            get { return (Brush) this.GetValue(SelectedBackgroundProperty); }

            set { this.SetValue(SelectedBackgroundProperty, value); }
        }

        /// <summary>
        /// Gets or sets the SelectedBorderBrush property.
        /// </summary>
        public Brush SelectedBorderBrush
        {
            get { return (Brush) this.GetValue(SelectedBorderBrushProperty); }

            set { this.SetValue(SelectedBorderBrushProperty, value); }
        }

        /// <summary>
        /// Gets or sets the SelectedForeground property.
        /// </summary>
        public Brush SelectedForeground
        {
            get { return (Brush) this.GetValue(SelectedForegroundProperty); }

            set { this.SetValue(SelectedForegroundProperty, value); }
        }

        /// <summary>
        /// Identifies the RenderSelected dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderSelectedProperty =
            DependencyProperty.Register("RenderSelected", typeof (bool), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderEnabled dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderEnabledProperty =
            DependencyProperty.Register("RenderEnabled", typeof (bool), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the SelectedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedBackgroundProperty =
            DependencyProperty.Register("SelectedBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the SelectedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedBorderBrushProperty =
            DependencyProperty.Register("SelectedBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the SelectedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the Foreground dependency property.
        /// </summary>
        public static readonly DependencyProperty ForegroundProperty = DependencyProperty.Register("Foreground",
            typeof (Brush), typeof (ControlChrome));

        /// <summary>
        /// Identifies the NormalBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalBackgroundProperty =
            DependencyProperty.Register("NormalBackground",
                typeof (Brush), typeof (ControlChrome), new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the NormalBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalBorderBrushProperty =
            DependencyProperty.Register("NormalBorderBrush",
                typeof (Brush), typeof (ControlChrome), new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the NormalForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty NormalForegroundProperty =
            DependencyProperty.Register("NormalForeground",
                typeof (Brush), typeof (ControlChrome), new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the HighlightedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedBackgroundProperty =
            DependencyProperty.Register("HighlightedBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the HighlightedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedBorderBrushProperty =
            DependencyProperty.Register("HighlightedBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the HighlightedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty HighlightedForegroundProperty =
            DependencyProperty.Register("HighlightedForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderHighlighted dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderHighlightedProperty =
            DependencyProperty.Register("RenderHighlighted",
                typeof (bool), typeof (ControlChrome), new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderFocused dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderFocusedProperty = DependencyProperty.Register("RenderFocused",
            typeof (bool), typeof (ControlChrome), new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the FocusedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedBackgroundProperty =
            DependencyProperty.Register("FocusedBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the FocusedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedBorderBrushProperty =
            DependencyProperty.Register("FocusedBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the FocusedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty FocusedForegroundProperty =
            DependencyProperty.Register("FocusedForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderPointerOver dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderPointerOverProperty =
            DependencyProperty.Register("RenderPointerOver",
                typeof (bool), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PointerOverBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverBackgroundProperty =
            DependencyProperty.Register("PointerOverBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PointerOverBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverBorderBrushProperty =
            DependencyProperty.Register("PointerOverBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PointerOverForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty PointerOverForegroundProperty =
            DependencyProperty.Register("PointerOverForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderPressed dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderPressedProperty = DependencyProperty.Register("RenderPressed",
            typeof (bool), typeof (ControlChrome),
            new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PressedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedBackgroundProperty =
            DependencyProperty.Register("PressedBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PressedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedBorderBrushProperty =
            DependencyProperty.Register("PressedBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the PressedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty PressedForegroundProperty =
            DependencyProperty.Register("PressedForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the RenderChecked dependency property.
        /// </summary>
        public static readonly DependencyProperty RenderCheckedProperty = DependencyProperty.Register("RenderChecked",
            typeof (bool?), typeof (ControlChrome), new PropertyMetadata(false, OnPropertyChanged));

        /// <summary>
        /// Identifies the CheckedBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedBackgroundProperty =
            DependencyProperty.Register("CheckedBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the CheckedBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedBorderBrushProperty =
            DependencyProperty.Register("CheckedBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the CheckedForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty CheckedForegroundProperty =
            DependencyProperty.Register("CheckedForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the IndeterminateBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateBackgroundProperty =
            DependencyProperty.Register("IndeterminateBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the IndeterminateBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateBorderBrushProperty =
            DependencyProperty.Register("IndeterminateBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the IndeterminateForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty IndeterminateForegroundProperty =
            DependencyProperty.Register("IndeterminateForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the DisabledBackground dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledBackgroundProperty =
            DependencyProperty.Register("DisabledBackground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the DisabledBorderBrush dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledBorderBrushProperty =
            DependencyProperty.Register("DisabledBorderBrush", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));

        /// <summary>
        /// Identifies the DisabledForeground dependency property.
        /// </summary>
        public static readonly DependencyProperty DisabledForegroundProperty =
            DependencyProperty.Register("DisabledForeground", typeof (Brush), typeof (ControlChrome),
                new PropertyMetadata(OnPropertyChanged));
    }
}