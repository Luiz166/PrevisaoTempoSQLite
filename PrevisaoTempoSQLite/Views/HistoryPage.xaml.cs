using PrevisaoTempoSQLite.Models;
using System.Collections.ObjectModel;

namespace PrevisaoTempoSQLite.Views;

public partial class HistoryPage : ContentPage
{
	ObservableCollection<Weather> list = new ObservableCollection<Weather>();
	public HistoryPage()
	{
		InitializeComponent();

		lst_weather.ItemsSource = list;
	}

    protected async override void OnAppearing()
    {
        List<Weather> temp = await App.Database.GetAll();
        temp.ForEach(x => list.Add(x));
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}