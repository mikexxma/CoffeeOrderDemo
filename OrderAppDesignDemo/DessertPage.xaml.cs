using OrderAppDesignDemo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace OrderAppDesignDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DessertPage : Page
    {
        public DessertPage()
        {
            this.InitializeComponent();
        }

        private void Slider_DragLeave(object sender, DragEventArgs e)
        {
            
        }

        private void DonutsNum_DragLeave(object sender, DragEventArgs e)
        {
            App.order.OrderedDonuts = Convert.ToInt32(DonutsNum.Value);
        }

        private void CakeNum_DragLeave(object sender, DragEventArgs e)
        {
            App.order.OrderedCake = Convert.ToInt32(CakeNum.Value);
        }
    }
}
