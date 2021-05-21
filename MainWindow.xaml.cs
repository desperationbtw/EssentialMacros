using EssentialMacros.Pages;
using Gma.System.MouseKeyHook;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace EssentialMacros
{
    public partial class MainWindow : Window
    {
        KeyConverter keyConvert = new KeyConverter();
        private IKeyboardMouseEvents mouseHook;
        KeyboardHook keyboardHook = new KeyboardHook(true);

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Анимация тайтла формы
            #region animation
            string[] titleChars = {"E", "s", "s", "e", "n", "t", "i", "a", "l", " ", "M", "a", "c", "r", "o", "s"};

            new Task(()=> {
                Thread.Sleep(1000);
                foreach (string x in titleChars)
                {
                    Dispatcher.Invoke(() => TitleText.Text += x);
                    Thread.Sleep(150);
                }
            }).Start();
            #endregion 

            Constants.localMachineKey = Registry.CurrentUser.OpenSubKey("Software\\EssentialM", true);
            if (Constants.localMachineKey == null)
            {
                //Создание и конфигурация записи в регистре при первом запуске или её отсутствии
                Constants.localMachineKey = Registry.CurrentUser.CreateSubKey("Software\\EssentialM");
                Constants.localMachineKey.SetValue("AK47", Key.None);
                Constants.localMachineKey.SetValue("BERDANKA", Key.None);
                Constants.localMachineKey.SetValue("BERETTA", Key.None);
                Constants.localMachineKey.SetValue("LR300", Key.None);
                Constants.localMachineKey.SetValue("M249", Key.None);
                Constants.localMachineKey.SetValue("MP5A4", Key.None);
                Constants.localMachineKey.SetValue("PISTOL", Key.None);
                Constants.localMachineKey.SetValue("PYTHON", Key.None);
                Constants.localMachineKey.SetValue("REVOLVER", Key.None);
                Constants.localMachineKey.SetValue("SMG", Key.None);
                Constants.localMachineKey.SetValue("TOMPSON", Key.None);
                Constants.localMachineKey.SetValue("M39", Key.None);

                Constants.localMachineKey.SetValue("Sensetivity", 1);
                Constants.localMachineKey.SetValue("Fov", 0);
                Constants.localMachineKey.SetValue("CrossHair", true);
                Constants.localMachineKey.SetValue("CrossHair_Y", 490);
                Constants.localMachineKey.SetValue("CrossHair_Size", 0.2);
                Constants.localMachineKey.SetValue("CrossHair_Opacity", 1);
                Constants.localMachineKey.SetValue("InventoryFix", true);
                Constants.localMachineKey.SetValue("InventoryKey", Key.Tab);
                Constants.localMachineKey.SetValue("Overlay", true);
            }

            Constants.BP = new BindingPage();
            Constants.SP = new SettingsPage();

            Constants.weaponArray.Add(new WeaponElement { name = "AK47", element = Constants.BP.ak_47, offsets = Encoding.UTF8.GetString(Properties.Resources.AK47).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("AK47").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "BERDANKA", element = Constants.BP.berdanka, offsets = Encoding.UTF8.GetString(Properties.Resources.Berdanka).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("BERDANKA").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "BERETTA", element = Constants.BP.beretta, offsets = Encoding.UTF8.GetString(Properties.Resources.Beretta).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("BERETTA").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "LR300", element = Constants.BP.lr300, offsets = Encoding.UTF8.GetString(Properties.Resources.LR300).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("LR300").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "M249", element = Constants.BP.m249, offsets = Encoding.UTF8.GetString(Properties.Resources.M249).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("M249").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "MP5A4", element = Constants.BP.mp5a4, offsets = Encoding.UTF8.GetString(Properties.Resources.MP5A4).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("MP5A4").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "PISTOL", element = Constants.BP.pistol, offsets = Encoding.UTF8.GetString(Properties.Resources.Pistol).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("PISTOL").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "PYTHON", element = Constants.BP.python, offsets = Encoding.UTF8.GetString(Properties.Resources.Python).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("PYTHON").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "REVOLVER", element = Constants.BP.revolver, offsets = Encoding.UTF8.GetString(Properties.Resources.Revolver).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("REVOLVER").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "SMG", element = Constants.BP.smg, offsets = Encoding.UTF8.GetString(Properties.Resources.SMG).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("SMG").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "TOMPSON", element = Constants.BP.tompson, offsets = Encoding.UTF8.GetString(Properties.Resources.Tompson).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("TOMPSON").ToString()) });
            Constants.weaponArray.Add(new WeaponElement { name = "M39", element = Constants.BP.m39, offsets = Encoding.UTF8.GetString(Properties.Resources.AK47).Split('\n'), bind = (Key)keyConvert.ConvertFromString(Constants.localMachineKey.GetValue("M39").ToString()) });


            for (int i = 0; i < Constants.weaponArray.Count; i++)
            {
                Constants.weaponArray[i].element.Keyx = Constants.weaponArray[i].bind;
            }

            keyboardHook.KeyDown += KHKeyDown;
            mouseHook = Hook.GlobalEvents();
            mouseHook.MouseDown += Constants.offsetWorker.MD;
            mouseHook.MouseUp += Constants.offsetWorker.MU;
            MainFrame.Navigate(Constants.BP);
        }

        private void KHKeyDown(Keys key, bool Shift, bool Ctrl, bool Alt) //Ивент на KeyBoard Input
        {
            WeaponElement result = Constants.weaponArray.Find(item => (Keys)KeyInterop.VirtualKeyFromKey(item.bind) == key);
            if (result != null && !Constants.isBind && !Constants.offsetWorker.MouseIsDown)
            {
                //Отключение бинда
                if (Constants.currentWeapon == result)
                {
                    result.element.BindName.Foreground = new SolidColorBrush(Colors.White);
                    Constants.currentWeapon = null;
                } else
                {
                    if (Constants.currentWeapon != null)
                        Constants.currentWeapon.element.BindName.Foreground = new SolidColorBrush(Colors.White);
                    Constants.currentWeapon = result;
                    result.element.BindName.Foreground = new SolidColorBrush(Colors.Red);
                }
            }
        }

        //!---------------------------------------------------UTILS
        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void BindsButton_Click(object sender, RoutedEventArgs e)
        {

            MainFrame.Navigate(Constants.BP);
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(Constants.SP);
        }
    }
}
