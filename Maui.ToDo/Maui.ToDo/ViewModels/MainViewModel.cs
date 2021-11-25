using Maui.ToDo.Models.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace Maui.ToDo.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public RelayCommand<NavigationMenuItem> ExecuteCommand { get; private set; }

        public MainViewModel()
        {
            InitNavigaionMenu();
            ExecuteCommand = new RelayCommand<NavigationMenuItem>(Execute);
        }

        void Execute(NavigationMenuItem arg)
        {

        }

        #region Navigation

        private ObservableCollection<NavigationMenuItem> navigationMenus;

        public ObservableCollection<NavigationMenuItem> NavigationMenus
        {
            get { return navigationMenus; }
            set { navigationMenus = value; OnPropertyChanged(); }
        }

        void InitNavigaionMenu()
        {
            NavigationMenus = new ObservableCollection<NavigationMenuItem>();

            NavigationMenus.Add(new NavigationMenuItem() { Icon = "\xe635", Title = "我的一天", BackColor = "#218868", });
            NavigationMenus.Add(new NavigationMenuItem() { Icon = "\xe6b6", Title = "重要", BackColor = "#EE3B3B", });
            NavigationMenus.Add(new NavigationMenuItem() { Icon = "\xe6e1", Title = "计划内", BackColor = "#218868", });
            NavigationMenus.Add(new NavigationMenuItem() { Icon = "\xe614", Title = "已分配给我", BackColor = "#EE3B3B", });
            NavigationMenus.Add(new NavigationMenuItem() { Icon = "\xe755", Title = "任务", BackColor = "#218868", });
        }

        #endregion 
    }
}
