using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

internal class Utils
{
    [DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
    public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    internal static extern bool GetCursorPos(ref Win32Point pt);

    public static void DoMouseClick() //Клик !ЛКМ, не работает, нужен реворк ивента
    {
        int num = (int)GetMousePosition().X;
        int num2 = (int)GetMousePosition().Y;
        mouse_event(2, num, num2, 0, 0);
    }

    public static Point GetMousePosition() //Поинтер на позицию мыши
    {
        Win32Point win32Point = default(Win32Point);
        GetCursorPos(ref win32Point);
        return new Point((double)win32Point.X, (double)win32Point.Y);
    }

    public static void Move(int xDelta, int yDelta) //Перемещение мыши
    {
        mouse_event(1, xDelta, yDelta, 0, 0);
    }

    private const int MOUSEEVENTF_LEFTDOWN = 2;

    private const int MOUSEEVENTF_LEFTUP = 4;

    private const int MOUSEEVENTF_RIGHTDOWN = 8;

    private const int MOUSEEVENTF_RIGHTUP = 16;

    private const int MOUSEEVENTF_MOVE = 1;

    internal struct Win32Point
    {
        public int X;

        public int Y;
    }
}

internal static class WindowTransparentHelper
{
    /// <summary> Справочник в котором хранятся старые состояния стиля окон </summary>
    private static readonly Dictionary<IntPtr, int> s_extendedStyleHwndDictionary
        = new Dictionary<IntPtr, int>();

    private const int WS_EX_TRANSPARENT = 0x00000020;
    private const int GWL_EXSTYLE = (-20);

    [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
    private static extern int GetWindowLong(IntPtr hwnd, int index);

    [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
    private static extern int SetWindowLong(IntPtr hwnd, int index, int newStyle);

    /// <summary> Делает окно прозрачным для ввода мышки </summary>
    /// <param name="hwnd">HWND окна</param>
    public static void SetWindowExTransparent(IntPtr hwnd)
    {
        int extendedStyle = GetWindowLong(hwnd, GWL_EXSTYLE);
        SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle | WS_EX_TRANSPARENT);
        if (s_extendedStyleHwndDictionary.Keys.Contains(hwnd) == false)
        {
            s_extendedStyleHwndDictionary.Add(hwnd, extendedStyle);
        }
    }

    /// <summary> Отключает прозрачность для ввода мышки у окна</summary>
    /// <param name="hwnd">HWND окна</param>
    public static void UndoWindowExTransparent(IntPtr hwnd)
    {
        if (s_extendedStyleHwndDictionary.Keys.Contains(hwnd))
        {
            int extendedStyle = s_extendedStyleHwndDictionary[hwnd];
            SetWindowLong(hwnd, GWL_EXSTYLE, extendedStyle);
        }
    }
}
public class PopupTransparentBehavior
{
    /// <summary> Прикрепляемое свойство зависимости отвечающее за прозрачность формы для ввода </summary>
    public static readonly DependencyProperty IsPopupEventTransparentProperty =
        DependencyProperty.RegisterAttached("IsPopupEventTransparent",
                                            typeof(bool),
                                            typeof(PopupTransparentBehavior),
                                            new UIPropertyMetadata(false, OnIsPopupEventTransparentPropertyChanged));

    public static bool GetIsPopupEventTransparent(DependencyObject obj) { return (bool)obj.GetValue(IsPopupEventTransparentProperty); }
    public static void SetIsPopupEventTransparent(DependencyObject obj, bool value) { obj.SetValue(IsPopupEventTransparentProperty, value); }

    private static void OnIsPopupEventTransparentPropertyChanged(DependencyObject target, DependencyPropertyChangedEventArgs e)
    {
        var element = target as FrameworkElement;
        var topParent = GetTopParent(element);
        var popupHwndSource = PresentationSource.FromVisual(topParent) as HwndSource;
        if (popupHwndSource == null) return;

        var newValue = (bool)e.NewValue;
        if (newValue)
            WindowTransparentHelper.SetWindowExTransparent(popupHwndSource.Handle);
        else
            WindowTransparentHelper.UndoWindowExTransparent(popupHwndSource.Handle);
    }

    public static FrameworkElement GetTopParent(FrameworkElement element)
    {
        return LogicalTreeHelper.GetChildren(element).Cast<FrameworkElement>().First();
    }
}
