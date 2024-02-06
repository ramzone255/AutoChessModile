namespace AutoChess;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        AutoChessList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Sportsmans selectedStudent = (Sportsmans)e.SelectedItem;
        SportsmansPage studentPage = new SportsmansPage();
        studentPage.BindingContext = selectedStudent;
        await Navigation.PushAsync(studentPage);
    }
    // обработка нажатия кнопки добавления
    private async void CreateStudent(object sender, EventArgs e)
    {
        Sportsmans student = new Sportsmans();
        SportsmansPage studentPage = new SportsmansPage();
        studentPage.BindingContext = student;
        await Navigation.PushAsync(studentPage);
    }
}

