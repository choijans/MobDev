namespace ToDo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the Shell as the main page
            MainPage = new AppShell();
        }
    }
}
