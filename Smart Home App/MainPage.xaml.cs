namespace Smart_Home_App;

public partial class MainPage : ContentPage
{
	int count = 0;
	CommunicationModel communicationModel;
	public MainPage()
	{
		InitializeComponent();
		communicationModel = new CommunicationModel();	
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		CommunicationModel.sendTCP("Test");
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

