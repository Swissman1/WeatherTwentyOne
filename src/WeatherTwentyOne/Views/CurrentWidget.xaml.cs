using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views;

public partial class CurrentWidget
{
    public CurrentWidget(HomeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
