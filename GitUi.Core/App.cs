using GitUi.Core.ViewModels;
using MvvmCross.ViewModels;

namespace GitUi.Core;

public class App : MvxApplication
{
    public override void Initialize()
    {
        RegisterAppStart<DashboardViewModel>();
    }
}
