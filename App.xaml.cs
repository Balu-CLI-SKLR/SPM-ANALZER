using SPM_ANALZER.Pages;

namespace SPM_ANALZER
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Mainpage());
        }
    }
}
