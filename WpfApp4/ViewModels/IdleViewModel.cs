using System.Windows.Input;
using WpfApp4.Commands;
using WpfApp4.Stores;

namespace WpfApp4.ViewModels
{
    public class IdleViewModel : ViewModelBase
    {
        public ICommand BreakIdleNavigateCommand { get; set; }

        public IdleViewModel(NavigationStore navigationStore, BuildingStore buildingStore)
        {
            BreakIdleNavigateCommand = new NavigateCommand<HomeViewModel>(buildingStore, new Services.NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore, buildingStore)));
        }
    }
}
