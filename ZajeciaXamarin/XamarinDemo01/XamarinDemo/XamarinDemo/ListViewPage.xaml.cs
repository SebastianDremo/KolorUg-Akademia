using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item 1",
                "Item 2",
                "Item 3",
                "Item 4",
                "Item 5"
            };

            MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            //((ListView)sender).SelectedItem = null;

            var obj = ((ListView) sender).SelectedItem.ToString();



            //Items.Remove(x=>x==obj);
            //Items.RemoveAt(Items.Count-1);
            //Items.Add($"Item {Items.Count + 1}");
        }
    }
}
