using Panuon.UI.Silver.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Panuon.UI.Silver.Controls.Internal
{
    /// <summary>
    /// CheckIcon.xaml 的交互逻辑
    /// </summary>
    internal partial class PendingBox : WindowX
    {
        public PendingBox(Window owner, string message, string title, PendingBoxConfigurations configurations)
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(title))
            {
                Title = title;
                WindowXCaption.SetHeight(this, 35);
            }

            Message = message;
            CancelButton = configurations.CancelButton;

            LoadingBackground = configurations.LoadingBackground;
            LoadingForeground = configurations.LoadingForeground;
            ButtonBrush = configurations.ButtonBrush;

            ShowInTaskbar = configurations.ShowInTaskbar;
            Topmost = configurations.Topmost;
            FontSize = configurations.FontSize;
            WindowStartupLocation = configurations.WindowStartupLocation;
            LoadingStyle = configurations.LoadingStyle;
            LoadingSize = configurations.LoadingSize;
            MinHeight = configurations.MinHeight;
            MinWidth = configurations.MinWidth;
            MaxHeight = configurations.MaxHeight;
            MaxWidth = configurations.MaxWidth;
        }



        #region Event
        public event EventHandler Canceled;
        #endregion

        #region Property
        /// <summary>
        /// Gets or sets loading style.
        /// </summary>
        public LoadingStyle LoadingStyle
        {
            get { return (LoadingStyle)GetValue(LoadingStyleProperty); }
            set { SetValue(LoadingStyleProperty, value); }
        }

        public static readonly DependencyProperty LoadingStyleProperty =
            DependencyProperty.Register("LoadingStyle", typeof(LoadingStyle), typeof(PendingBox), new PropertyMetadata(OnLoadingStyleChanged));



        public Brush ButtonBrush
        {
            get { return (Brush)GetValue(ButtonBrushProperty); }
            set { SetValue(ButtonBrushProperty, value); }
        }

        public static readonly DependencyProperty ButtonBrushProperty =
            DependencyProperty.Register("ButtonBrush", typeof(Brush), typeof(PendingBox));


        /// <summary>
        /// Gets or sets loading stroke.
        /// </summary>
        public Brush LoadingBackground
        {
            get { return (Brush)GetValue(LoadingBackgroundProperty); }
            set { SetValue(LoadingBackgroundProperty, value); }
        }

        public static readonly DependencyProperty LoadingBackgroundProperty =
            DependencyProperty.Register("LoadingBackground", typeof(Brush), typeof(PendingBox), new PropertyMetadata(OnLoadingStyleChanged));

        /// <summary>
        /// Gets or sets loading stroke cover.
        /// </summary>
        public Brush LoadingForeground
        {
            get { return (Brush)GetValue(LoadingForegroundProperty); }
            set { SetValue(LoadingForegroundProperty, value); }
        }

        public static readonly DependencyProperty LoadingForegroundProperty =
            DependencyProperty.Register("LoadingForeground", typeof(Brush), typeof(PendingBox), new PropertyMetadata(OnLoadingStyleChanged));

        /// <summary>
        /// Gets or sets message.
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(PendingBox));

        /// <summary>
        /// Gets or sets is runing.
        /// </summary>
        public bool IsRunning
        {
            get { return (bool)GetValue(IsRunningProperty); }
            set { SetValue(IsRunningProperty, value); }
        }

        public static readonly DependencyProperty IsRunningProperty =
            DependencyProperty.Register("IsRunning", typeof(bool), typeof(PendingBox));

        /// <summary>
        /// Gets or sets loading size.
        /// </summary>
        public double LoadingSize
        {
            get { return (double)GetValue(LoadingSizeProperty); }
            set { SetValue(LoadingSizeProperty, value); }
        }

        public static readonly DependencyProperty LoadingSizeProperty =
            DependencyProperty.Register("LoadingSize", typeof(double), typeof(PendingBox));

        /// <summary>
        /// Gets or sets cancel button content.
        /// </summary>
        public string CancelButton
        {
            get { return (string)GetValue(CancelButtonProperty); }
            set { SetValue(CancelButtonProperty, value); }
        }

        public static readonly DependencyProperty CancelButtonProperty =
            DependencyProperty.Register("CancelButton", typeof(string), typeof(PendingBox));
        #endregion

        #region Event Handler
        private void PendingBox_Loaded(object sender, RoutedEventArgs e)
        {
            IsRunning = true;
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Canceled?.Invoke(this, e);
        }

        private static void OnLoadingStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var box = d as PendingBox;
            if (box.LoadingBackground != null)
                box.LdMain.Background = box.LoadingBackground;
            if (box.LoadingForeground != null)
                box.LdMain.Foreground = box.LoadingForeground;

            box.LdMain.LoadingStyle = box.LoadingStyle;
        }
        #endregion

        #region Calling Methods
        public void UpdateMessage(string message)
        {
            Message = message;
        }
        #endregion
    }
}
