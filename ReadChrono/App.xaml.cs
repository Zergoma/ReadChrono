using Microsoft.Extensions.DependencyInjection;
using ReadChrono.MVVM.Views;

namespace ReadChrono
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new ChronoView());
        }
    }
}