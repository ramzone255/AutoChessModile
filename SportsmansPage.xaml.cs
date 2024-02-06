namespace AutoChess;

public partial class SportsmansPage : ContentPage
{
	public SportsmansPage()
	{
		InitializeComponent();
	}
    private void SaveStudent(object sender, EventArgs e)
    {
        var friend = (Sportsmans)BindingContext;
        if (!String.IsNullOrEmpty(friend.Name))
        {
            App.Database.SaveItem(friend);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteStudent(object sender, EventArgs e)
    {
        var friend = (Sportsmans)BindingContext;
        App.Database.DeleteItem(friend.ID);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }

    private void GroupPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}