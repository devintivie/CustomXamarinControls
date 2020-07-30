using CustomXamarinControls;
using CustomXamarinControls.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace CustomXamarinControls.iOS
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
        }
    }
}
