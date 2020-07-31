using Android.Content;
using Android.Graphics.Drawables;
using CustomXamarinControls;
using CustomXamarinControls.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
//using Xamarin.Forms.Platform.Android.AppCompat;
using Color = Android.Graphics.Color;


[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace CustomXamarinControls.Droid
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

            var view = (CustomPicker)Element;
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
