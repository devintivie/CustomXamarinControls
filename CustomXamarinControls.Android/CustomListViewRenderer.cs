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

[assembly: ExportRenderer(typeof(TransparentSelectListView), typeof(TransparentSelectListViewRenderer))]
namespace CustomXamarinControls.Droid
{

    public class TransparentSelectListViewRenderer : ListViewRenderer
    {
        public TransparentSelectListViewRenderer(Context context) : base(context)
        {
        }
    }
}