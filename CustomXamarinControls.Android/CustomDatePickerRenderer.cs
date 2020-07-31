using Android.Content;
using Android.Graphics.Drawables;
using CustomXamarinControls;
using CustomXamarinControls.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms.Platform.Android.AppCompat;
using Color = Android.Graphics.Color;


[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace CustomXamarinControls.Droid
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

            var view = (CustomDatePicker)Element;
            var color = view.BackgroundColor.ToAndroid();
            GradientDrawable gd = new GradientDrawable();
            if (view.BackgroundColor.IsDefault)
            {
                gd.SetColor(Color.White);
                //gd.SetColor();
            }
            else
            {
                gd.SetColor(color);
            }

            Control.SetBackground(gd);
        }
    }
}
