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
    internal partial class LoadingBox : UserControl
    {
        public LoadingBox()
        {
            InitializeComponent();
        }

        public LoadingStyle LoadingStyle
        {
            get { return (LoadingStyle)GetValue(LoadingStyleProperty); }
            set { SetValue(LoadingStyleProperty, value); }
        }

        public static readonly DependencyProperty LoadingStyleProperty =
            DependencyProperty.Register("LoadingStyle", typeof(LoadingStyle), typeof(LoadingBox), new PropertyMetadata(OnLoadingStyleChanged));

        public Brush LoadingStroke
        {
            get { return (Brush)GetValue(LoadingStrokeProperty); }
            set { SetValue(LoadingStrokeProperty, value); }
        }

        public static readonly DependencyProperty LoadingStrokeProperty =
            DependencyProperty.Register("LoadingStroke", typeof(Brush), typeof(LoadingBox), new PropertyMetadata(OnLoadingStyleChanged));



        public Brush LoadingStrokeCover
        {
            get { return (Brush)GetValue(LoadingStrokeCoverProperty); }
            set { SetValue(LoadingStrokeCoverProperty, value); }
        }

        public static readonly DependencyProperty LoadingStrokeCoverProperty =
            DependencyProperty.Register("LoadingStrokeCover", typeof(Brush), typeof(LoadingBox), new PropertyMetadata(OnLoadingStyleChanged));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(LoadingBox));


        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register("Message", typeof(string), typeof(LoadingBox));



        public bool IsRunning
        {
            get { return (bool)GetValue(IsRunningProperty); }
            set { SetValue(IsRunningProperty, value); }
        }

        public static readonly DependencyProperty IsRunningProperty =
            DependencyProperty.Register("IsRunning", typeof(bool), typeof(LoadingBox));



        #region Event Handler
        private static void OnLoadingStyleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var box = d as LoadingBox;
            if (box.LoadingStroke != null)
                box.LdMain.Stroke = box.LoadingStroke;
            if (box.LoadingStrokeCover != null)
                box.LdMain.StrokeCover = box.LoadingStrokeCover;

            box.LdMain.LoadingStyle = box.LoadingStyle;
        }
        #endregion
    }
}
