using CommunityToolkit.Mvvm.ComponentModel;
using TestApp.Models;

namespace TestApp.PageModels
{
    [ObservableObject]
    public partial class MainPageModel
    {
        public MainPageModel()
        {
           _monkeyList = new List<Monkey>
           {
               new() { Name = "Dunston", Age = "21" }, 
               new() { Name = "Chuckles", Age = "25" }
           };
        }

        [ObservableProperty] private List<Monkey> _monkeyList;
    }
}
