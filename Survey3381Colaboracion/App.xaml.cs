namespace Survey3381Colaboracion
{
    public partial class App : Application
    {
        public App()
        {
           

            //Mainpage = AppShell();
            MainPage = new NavigationPage(new SurveyView());
        }
    }
}
