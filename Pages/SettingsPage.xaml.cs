using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EssentialMacros.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Sens.Value = double.Parse(Constants.localMachineKey.GetValue("Sensetivity").ToString());
            Constants.offsetWorker.default_offset = double.Parse(Constants.localMachineKey.GetValue("Sensetivity").ToString());

            Fov.Value = double.Parse(Constants.localMachineKey.GetValue("Fov").ToString());
            Constants.offsetWorker.fov_offset = double.Parse(Constants.localMachineKey.GetValue("Fov").ToString());
        }
        private void Sens_ValueChanged(object sender, EventArgs e)
        {
            Constants.localMachineKey.SetValue("Sensetivity", ((SliderControl)sender).Value);
            Constants.offsetWorker.default_offset = ((SliderControl)sender).Value;
        }
        private void Fov_ValueChanged(object sender, EventArgs e)
        {
            Constants.localMachineKey.SetValue("Fov", ((SliderControl)sender).Value);
            Constants.offsetWorker.fov_offset = ((SliderControl)sender).Value;
        }

        private void InventoryInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            swapOverlay("ФИКС ИНВЕНТАРЯ", "Отключает функционал макроса, когда вы нажимаете на кнопку, забинженую на инвентарь.");
        }

        private void InventoryInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            swapOverlay("", "");
        }

        private void OverlayInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            swapOverlay("ОВЕРЛЕЙ", "Отображает поверх игры информацию о статусе макросов");
        }

        private void OverlayInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            swapOverlay("", "");
        }

        private void swapOverlay(string title, string data)
        {
            if (InfoOverlay.Visibility == Visibility.Visible)
                InfoOverlay.Visibility = Visibility.Hidden;
            else
            {
                InfoOverlay.Visibility = Visibility.Visible;
                InfoOverlayText.Text = data;
                InfoOverlayTitle.Content = title;
            }
        }
    }
}
