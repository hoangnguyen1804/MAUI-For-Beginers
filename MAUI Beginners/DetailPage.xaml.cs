using MAUI_Beginners.ViewModel;

namespace MAUI_Beginners;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}
