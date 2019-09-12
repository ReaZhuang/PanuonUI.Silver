using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Panuon.UI.Silver
{
    public class MenuHelper
    {
        #region Orientation
        public static Orientation GetOrientation(DependencyObject obj)
        {
            return (Orientation)obj.GetValue(OrientationProperty);
        }

        public static void SetOrientation(DependencyObject obj, Orientation value)
        {
            obj.SetValue(OrientationProperty, value);
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.RegisterAttached("Orientation", typeof(Orientation), typeof(MenuHelper), new PropertyMetadata(Orientation.Horizontal));
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
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(MenuHelper));
        #endregion

        #region HoverForeground
        public static Brush GetHoverForeground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverForegroundProperty);
        }

        public static void SetHoverForeground(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverForegroundProperty, value);
        }

        public static readonly DependencyProperty HoverForegroundProperty =
            DependencyProperty.RegisterAttached("HoverForeground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region HoverBackground
        public static Brush GetHoverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(HoverBackgroundProperty);
        }

        public static void SetHoverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(HoverBackgroundProperty, value);
        }

        public static readonly DependencyProperty HoverBackgroundProperty =
            DependencyProperty.RegisterAttached("HoverBackground", typeof(Brush), typeof(MenuHelper));
        #endregion

        #region ShadowColor
        public static Color GetShadowColor(DependencyObject obj)
        {
            return (Color)obj.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(DependencyObject obj, Color value)
        {
            obj.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color), typeof(MenuHelper));
        #endregion

        #region MenuStyle
        public static MenuStyle GetMenuStyle(DependencyObject obj)
        {
            return (MenuStyle)obj.GetValue(MenuStyleProperty);
        }

        public static void SetMenuStyle(DependencyObject obj, MenuStyle value)
        {
            obj.SetValue(MenuStyleProperty, value);
        }

        public static readonly DependencyProperty MenuStyleProperty =
            DependencyProperty.RegisterAttached("MenuStyle", typeof(MenuStyle), typeof(MenuHelper), new PropertyMetadata(MenuStyle.Standard));
        #endregion

        #region SubmentItemHeight
        public static double GetSubmentItemHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(SubmentItemHeightProperty);
        }

        public static void SetSubmentItemHeight(DependencyObject obj, double value)
        {
            obj.SetValue(SubmentItemHeightProperty, value);
        }

        public static readonly DependencyProperty SubmentItemHeightProperty =
            DependencyProperty.RegisterAttached("SubmentItemHeight", typeof(double), typeof(MenuHelper));
        #endregion

        #region ItemIconWidth
        public static string GetItemIconWidth(DependencyObject obj)
        {
            return (string)obj.GetValue(ItemIconWidthProperty);
        }

        public static void SetItemIconWidth(DependencyObject obj, string value)
        {
            obj.SetValue(ItemIconWidthProperty, value);
        }

        public static readonly DependencyProperty ItemIconWidthProperty =
            DependencyProperty.RegisterAttached("ItemIconWidth", typeof(string), typeof(MenuHelper));
        #endregion

        #region IsSubMenuGlyphVisible
        public static bool GetIsSubMenuGlyphVisible(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSubMenuGlyphVisibleProperty);
        }

        public static void SetIsSubMenuGlyphVisible(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSubMenuGlyphVisibleProperty, value);
        }

        public static readonly DependencyProperty IsSubMenuGlyphVisibleProperty =
            DependencyProperty.RegisterAttached("IsSubMenuGlyphVisible", typeof(bool), typeof(MenuHelper));
        #endregion

        #region ItemPadding
        public static Thickness GetItemPadding(DependencyObject obj)
        {
            return (Thickness)obj.GetValue(ItemPaddingProperty);
        }

        public static void SetItemPadding(DependencyObject obj, Thickness value)
        {
            obj.SetValue(ItemPaddingProperty, value);
        }

        public static readonly DependencyProperty ItemPaddingProperty =
            DependencyProperty.RegisterAttached("ItemPadding", typeof(Thickness), typeof(MenuHelper));
        #endregion

        #region PopupAnimation
        public static PopupAnimation GetPopupAnimation(DependencyObject obj)
        {
            return (PopupAnimation)obj.GetValue(PopupAnimationProperty);
        }

        public static void SetPopupAnimation(DependencyObject obj, PopupAnimation value)
        {
            obj.SetValue(PopupAnimationProperty, value);
        }

        public static readonly DependencyProperty PopupAnimationProperty =
            DependencyProperty.RegisterAttached("PopupAnimation", typeof(PopupAnimation), typeof(MenuHelper), new PropertyMetadata(PopupAnimation.Fade));
        #endregion
    }
}
