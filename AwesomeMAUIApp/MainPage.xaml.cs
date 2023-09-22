namespace AwesomeMAUIApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

  
    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

     void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string write_type = e.OldTextValue;
        string display = e.NewTextValue;
        DisplayLbl.Text = display;
    }
	
}

