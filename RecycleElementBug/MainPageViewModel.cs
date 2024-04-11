using RecycleElementBug.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace RecycleElementBug
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Page Page { get; set; }

        public ObservableCollection<object> ItemsList { get; set; }

        public Command PreviousCommand => new Command(() => LoadDataPrevious());
        public Command CurrentCommand => new Command(() => LoadDataCurrent());
        public Command NextCommand => new Command(() => LoadDataNext());

        public MainPageViewModel(Page page)
        {
            Page = page;

            ItemsList = new ObservableCollection<object>();
            LoadDataCurrent();
        }

        private void LoadDataCurrent()
        {
            ObservableCollection<object> ItemsListLocal = new ObservableCollection<object>();

            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR CURRENT 1" });
            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR CURRENT 2" });

            ItemsList = ItemsListLocal;
        }

        private void LoadDataPrevious()
        {
            ObservableCollection<object> ItemsListLocal = new ObservableCollection<object>();

            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR PREVIOUS 1" });
            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR PREVIOUS 2" });
            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR PREVIOUS 3" });

            ItemsListLocal.Add(new Alarm() { ALARM_NAME = "WARNING PREVIOUS" });

            ItemsList = ItemsListLocal;
        }

        private void LoadDataNext()
        {
            ObservableCollection<object> ItemsListLocal = new ObservableCollection<object>();

            ItemsListLocal.Add(new Alarm() { ALARM_NAME = "ALARM NEXT" });
            ItemsListLocal.Add(new Info() { INFO_NAME = "INFO NEXT" });

            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR NEXT 1" });
            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR NEXT 2" });
            ItemsListLocal.Add(new Regular() { REGULAR_NAME = "REGULAR NEXT 3" });

            ItemsList = ItemsListLocal;
        }
    }
}
