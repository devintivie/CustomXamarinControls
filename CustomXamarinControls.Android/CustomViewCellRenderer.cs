using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomXamarinControls;
using CustomXamarinControls.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace CustomXamarinControls.Droid
{
    
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        private bool isSelected = false;
        private Android.Views.View core;
        protected override global::Android.Views.View GetCellCore(Cell item, global::Android.Views.View convertView, ViewGroup parent, Context context)
        {
            core = base.GetCellCore(item, convertView, parent, context);
            var listView = parent as Android.Widget.ListView;

            if (listView != null)
            {
                // Disable native cell selection color style - set as *Transparent*
                listView.SetSelector(Android.Resource.Color.HoloPurple);
                listView.CacheColorHint = Android.Graphics.Color.Pink;
            }
            return core;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnCellPropertyChanged(sender, e);

            if (e.PropertyName == "IsSelected")
            {
                
                isSelected = !isSelected;
                var viewcell = sender as ViewCell;
                if (isSelected)
                {
                    core.SetBackgroundColor(Android.Graphics.Color.Transparent);

                }
                else
                {
                    core.SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
            }
        }
    }
}