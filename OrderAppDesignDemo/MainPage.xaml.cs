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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace OrderAppDesignDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void DessertBt_Click(object sender, RoutedEventArgs e)
        {
            OrderPage.Navigate(typeof(DessertPage));
            if (!OrderSplit.IsPaneOpen)
            {
                 OrderSplit.IsPaneOpen = !OrderSplit.IsPaneOpen;
            }        
        }

        private void CoffeeBt_Click(object sender, RoutedEventArgs e)
        {
            
            OrderPage.Navigate(typeof(CoffeePage));
            if (!OrderSplit.IsPaneOpen)
            {
                OrderSplit.IsPaneOpen = !OrderSplit.IsPaneOpen;
            }
        }

        private void ScheduleBt_Click(object sender, RoutedEventArgs e)
        {
            OrderPage.Navigate(typeof(SchedulePage));
            if (!OrderSplit.IsPaneOpen)
            {
                OrderSplit.IsPaneOpen = !OrderSplit.IsPaneOpen;
            }
        }
    }
}
