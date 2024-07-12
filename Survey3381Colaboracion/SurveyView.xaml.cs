namespace Survey3381Colaboracion;

public partial class SurveyView : ContentPage
{
	public SurveyView()
	{
		InitializeComponent();
		MessagingCenter.Subscribe<ContentPage, Surveys>(this, Messages.NewSurveyComplete, (sender, args) => {
			SurveysPanel.Children.Add(new Label() { Text = args.ToString() });
		});
	}
		private async void AddSurveyButton_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new SurveyDetailsView());
		}

	}
}