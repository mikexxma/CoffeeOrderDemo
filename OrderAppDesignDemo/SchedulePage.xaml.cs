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
    public delegate void TimePikcEnd();
    public sealed partial class SchedulePage : Page
    {
        public event TimePikcEnd endTimePick;
        public SchedulePage()
        {
            this.InitializeComponent();
        }
        public void OnTiemPickEnd()// 通过方法调用委托(参数就是方法)

        {
            if (endTimePick != null)//判断方法有没有赋值 

            {
                endTimePick();
            }

        }

        private void DatePicker_DateChanged(object sender, DatePickerValueChangedEventArgs e)
        {
            DatePicker selectDate = (DatePicker)sender;
            OnTiemPickEnd();            
        }

        private void TimePicker_TimeChanged(object sender, TimePickerValueChangedEventArgs e)
        {
            TimePicker selectDate = (TimePicker)sender;
            OnTiemPickEnd();     
        }
        class TimePickEndListerner

        {
            int i = 0;
            public TimePickEndListerner(SchedulePage schedule)

            {

                // Add "ListChanged" to the Changed event on "List".

                schedule.endTimePick += new TimePikcEnd(TimePlickEndListner);

            }

            //用一个代理方法 来监听事件 然后再事件发生的时候做点什么

            private void TimePlickEndListner()

            {
                i++;
                if (i == 2)
                {
                    
                }

            }
        }
    }
}
