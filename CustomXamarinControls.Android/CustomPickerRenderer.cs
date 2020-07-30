using Android.Content;
using CustomXamarinControls;
using CustomXamarinControls.Android;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms.Platform.Android.AppCompat;


[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace CustomXamarinControls.Android
{
    public class CustomPickerRenderer : PickerRenderer
    {
        public CustomPickerRenderer(Context context) : base(context)
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            Control.SetPadding(8, 8, 8, 8);
        }
    }
}
