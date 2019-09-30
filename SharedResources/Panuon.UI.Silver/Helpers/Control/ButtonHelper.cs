﻿using System.Windows;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class ButtonHelper
    {
        #region ButtonStyle
        public static ButtonStyle GetButtonStyle(DependencyObject obj)
        {
            return (ButtonStyle)obj.GetValue(ButtonStyleProperty);
        }

        public static void SetButtonStyle(DependencyObject obj, ButtonStyle value)
        {
            obj.SetValue(ButtonStyleProperty, value);
        }

        public static readonly DependencyProperty ButtonStyleProperty =
            DependencyProperty.RegisterAttached("ButtonStyle", typeof(ButtonStyle), typeof(ButtonHelper), new PropertyMetadata(ButtonStyle.Standard));
        #endregion

        #region ClickStyle
        public static ClickStyle GetClickStyle(DependencyObject obj)
        {
            return (ClickStyle)obj.GetValue(ClickStyleProperty);
        }

        public static void SetClickStyle(DependencyObject obj, ClickStyle value)
        {
            obj.SetValue(ClickStyleProperty, value);
        }

        public static readonly DependencyProperty ClickStyleProperty =
            DependencyProperty.RegisterAttached("ClickStyle", typeof(ClickStyle), typeof(ButtonHelper), new PropertyMetadata(ClickStyle.None));
        #endregion

        #region HoverBrush
        public static Brush GetHoverBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverBrushProperty);
        }

        public static void SetHoverBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverBrushProperty, value);
        }

        public static readonly DependencyProperty HoverBrushProperty =
            DependencyProperty.RegisterAttached("HoverBrush", typeof(Brush), typeof(ButtonHelper));
        #endregion

        #region CornerRadius
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(ButtonHelper));
        #endregion

        #region IsWaiting
        public static bool GetIsWaiting(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsWaitingProperty);
        }

        public static void SetIsWaiting(DependencyObject obj, bool value)
        {
            obj.SetValue(IsWaitingProperty, value);
        }

        public static readonly DependencyProperty IsWaitingProperty =
            DependencyProperty.RegisterAttached("IsWaiting", typeof(bool), typeof(ButtonHelper));
        #endregion

        #region WaitingContent
        public static object GetWaitingContent(DependencyObject obj)
        {
            return obj.GetValue(WaitingContentProperty);
        }

        public static void SetWaitingContent(DependencyObject obj, object value)
        {
            obj.SetValue(WaitingContentProperty, value);
        }

        public static readonly DependencyProperty WaitingContentProperty =
            DependencyProperty.RegisterAttached("WaitingContent", typeof(object), typeof(ButtonHelper));
        #endregion

        #region Icon
        public static object GetIcon(DependencyObject obj)
        {
            return obj.GetValue(IconProperty);
        }

        public static void SetIcon(DependencyObject obj, object value)
        {
            obj.SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.RegisterAttached("Icon", typeof(object), typeof(ButtonHelper));


        #endregion

        #region ClickCoverBrush
        public static Brush GetClickCoverBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(ClickCoverBrushProperty);
        }

        public static void SetClickCoverBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(ClickCoverBrushProperty, value);
        }

        public static readonly DependencyProperty ClickCoverBrushProperty =
            DependencyProperty.RegisterAttached("ClickCoverBrush", typeof(Brush), typeof(ButtonHelper));


        #endregion


    }
}
