namespace AutoChess;

public partial class App : Application
{
    public const string DATABASE_NAME = "Sportsmans.db";
    public static AutoChessRepository database;
    public static AutoChessRepository Database
    {
        get
        {
            if (database == null)
            {
                database = new AutoChessRepository(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
    }
}
