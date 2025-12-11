using ReadChrono.MVVM.ViewModels;

namespace ReadChrono.MVVM.Views;

public partial class ChronoView : ContentPage
{
	public ChronoView()
	{
		InitializeComponent();
		BindingContext = new ChronoViewModel(this.Dispatcher);
	}
}