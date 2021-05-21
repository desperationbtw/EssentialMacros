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

namespace EssentialMacros
{
    /// <summary>
    /// Логика взаимодействия для SliderControl.xaml
    /// </summary>
    public partial class SliderControl : UserControl
    {
        public SliderControl()
        {
            InitializeComponent();
        }

        public event EventHandler ValueChanged;
        public double Value
        {
            get
            {
                return currentSlider.Value;
            }
            set
            {
                currentSlider.Value = value;
            }
        }
        public string SliderText
        {
            set
            {
                SliderName.Text = value;
            }
        }

        public double Min
        {
            set
            {
                currentSlider.Minimum = value;
            }
        }

        public double Max
        {
            set
            {
                currentSlider.Maximum = value;
            }
        }

        public double Step
        {
            set
            {
                currentSlider.TickFrequency = value;
            }
        }



        private void CurrentSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            infoBar.Content = currentSlider.Value.ToString();
        }

        private void CurrentSlider_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
