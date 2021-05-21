using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EssentialMacros
{
    public partial class BindControl : UserControl
    {
        public BindControl()
        {
            InitializeComponent();
        }
        public string BindText
        {
            set
            {
                BindName.Text = value;
            }
        }

        private Key _Keyx;
        public Key Keyx
        {
            get
            {
                return _Keyx;
            }
            set
            {
                _Keyx = value;
                BindKeyLabel.Content = "• • •";
                if (value != Key.None)
                {
                    BindKeyLabel.Content = value.ToString();
                    UnbindContainer.Visibility = Visibility.Visible;
                }
            }
        }
        private void RebindButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (Constants.weaponArray.Exists(item => item.bind == e.Key))
            {
                if (_Keyx == Key.None)
                    BindKeyLabel.Content = "• • •";
                else
                    BindKeyLabel.Content = _Keyx.ToString();
                RebindContainer.Visibility = Visibility.Hidden;
                Constants.BP.Focus();
            } else
            {
                _Keyx = e.Key;
                WeaponElement result = Constants.weaponArray.Find(item => item.element == this);
                result.bind = e.Key;
                Constants.localMachineKey.SetValue(result.name, e.Key);
                BindKeyLabel.Content = e.Key.ToString();
                RebindContainer.Visibility = Visibility.Hidden;
                UnbindContainer.Visibility = Visibility.Visible;
            }
            Constants.isBind = false;
        }

        private void RebindButton_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            Constants.isBind = false;
            if (_Keyx == Key.None)
                BindKeyLabel.Content = "• • •";
            else
                BindKeyLabel.Content = _Keyx.ToString();
            RebindContainer.Visibility = Visibility.Hidden;
        }

        private void BindButton_Click(object sender, RoutedEventArgs e)
        {
            Constants.isBind = true;
            BindKeyLabel.Content = "-press-";
            RebindContainer.Visibility = Visibility.Visible;
            RebindButton.Focus();
        }

        private void RebindButton_Click(object sender, RoutedEventArgs e)
        {
            Constants.isBind = true;
            BindKeyLabel.Content = "-press-";
            RebindButton.Focus();
        }

        private void UnbindButton_Click(object sender, RoutedEventArgs e)
        {
            if (Constants.offsetWorker.MouseIsDown)
                return;
            UnbindContainer.Visibility = Visibility.Hidden;
            BindButton.Visibility = Visibility.Visible;
            BindKeyLabel.Content = "• • •";
            _Keyx = Key.None;

            WeaponElement result = Constants.weaponArray.Find(item => item.element == this);
            result.bind = Key.None;
            Constants.localMachineKey.SetValue(result.name, Key.None);
        }
    }
}
