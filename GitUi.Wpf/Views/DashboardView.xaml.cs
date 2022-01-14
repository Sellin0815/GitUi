using GitUi.Core.ViewModels;
using MvvmCross.Platforms.Wpf.Presenters.Attributes;
using MvvmCross.Platforms.Wpf.Views;
using MvvmCross.ViewModels;

namespace GitUi.Wpf.Views
{
    [MvxContentPresentation]
    [MvxViewFor(typeof(DashboardViewModel))]
    public partial class DashboardView : MvxWpfView
    {
        public DashboardView()
        {
            InitializeComponent();
        }
    }
}
