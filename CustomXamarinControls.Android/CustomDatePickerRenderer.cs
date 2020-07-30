using Android.Content;
using CustomXamarinControls;
using CustomXamarinControls.Android;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms.Platform.Android.AppCompat;


[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace CustomXamarinControls.Android
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            Control.SetPadding(8, 8, 8, 8);
        }
    }
}
