﻿using Android.Content;
using CustomXamarinControls;
using CustomXamarinControls.Droid;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Graphics;
using Android.Graphics.Drawables;
using Color = Android.Graphics.Color;
using Android.Text;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace CustomXamarinControls.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control.SetPadding(8, 8, 8, 8);

            var view = (CustomEntry)Element;
            Control.InputType = InputTypes.TextFlagCapWords;
            
            var color = view.BackgroundColor.ToAndroid();
            
            //view.BackgroundColor
            //Control.Background.
            GradientDrawable gd = new GradientDrawable();
            if (view.BackgroundColor.IsDefault)
            {
                gd.SetColor(Color.White);
            }
            else
            {
                gd.SetColor(color);
            }
            
            Control.SetBackground(gd);

        }
    }
}
