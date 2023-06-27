namespace Maui_CSS;

public partial class MainPage : ContentPage
{
	int count = 0;

    [Obsolete]
    public MainPage()
	{
		InitializeComponent();

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            _timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            return true;
        });
    }

	
}

