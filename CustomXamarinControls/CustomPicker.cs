using System;
using Xamarin.Forms;

namespace CustomXamarinControls
{
    public class CustomPicker : Picker
    {
        public CustomPicker()
        {
            Console.WriteLine("cutom");
        }
    }

    public class CustomEntry : Entry
    {

    }

    public class CustomDatePicker : DatePicker
    {

    }

    public class CustomViewCell : ViewCell
    {
        
    }
    public class TransparentSelectListView : ListView
    {
        public TransparentSelectListView()
        {
            ItemSelected += CustomListView_ItemSelected;
        }

        private void CustomListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            SelectedItem = null;
        }
    }
}
