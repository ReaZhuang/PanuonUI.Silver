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
        public static Color? GetShadowColor(DependencyObject obj)
        {
            return (Color?)obj.GetValue(ShadowColorProperty);
        }

        public static void SetShadowColor(DependencyObject obj, Color? value)
        {
            obj.SetValue(ShadowColorProperty, value);
        }

        public static readonly DependencyProperty ShadowColorProperty =
            DependencyProperty.RegisterAttached("ShadowColor", typeof(Color?), typeof(MenuHelper));
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

        #region SubmenuItemHeight
        public static double GetSubmenuItemHeight(DependencyObject obj)
        {
            return (double)obj.GetValue(SubmenuItemHeightProperty);
        }

        public static void SetSubmenuItemHeight(DependencyObject obj, double value)
        {
            obj.SetValue(SubmenuItemHeightProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemHeightProperty =
            DependencyProperty.RegisterAttached("SubmenuItemHeight", typeof(double), typeof(MenuHelper));
        #endregion

        #region SubmenuItemIconWidth
        public static string GetSubmenuItemIconWidth(DependencyObject obj)
        {
            return (string)obj.GetValue(SubmenuItemIconWidthProperty);
        }

        public static void SetSubmenuItemIconWidth(DependencyObject obj, string value)
        {
            obj.SetValue(SubmenuItemIconWidthProperty, value);
        }

        public static readonly DependencyProperty SubmenuItemIconWidthProperty =
            DependencyProperty.RegisterAttached("SubmenuItemIconWidth", typeof(string), typeof(MenuHelper));
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
