using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Views;

public partial class Next7DWidget
{
    public Next7DWidget(HomeViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
