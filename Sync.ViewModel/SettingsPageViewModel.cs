using GalaSoft.MvvmLight.Command;
using Sync.Model;
using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;

namespace Sync.ViewModel
{
    public class SettingsPageViewModel : Bindable
    {
        private ObservableCollection<string> folders;

        public SettingsPageViewModel()
        {
            SelectFolderCommand = new RelayCommand(OnSelectFolderExecute);

            Folders = new ObservableCollection<string>();
            Folders.Add("test1");
            Folders.Add("test2");
            Folders.Add("test3");
            Folders.Add("test4");
        }

        #region properties
        public ObservableCollection<string> Folders
        {
            get => folders;
            set => Set(ref folders, value);
        }

        public RelayCommand SelectFolderCommand { get; }
        #endregion

        #region commands
        public async void OnSelectFolderExecute()
        {
            try
            {
                //Intent intent = new Intent(Intent.ActionOpenDocumentTree);
                //StartActivityForResult(intent, 99);

                var folder = await FilePicker.PickAsync();
                string name = folder.FileName;
            }
            catch (Exception ex) { }
        }
        #endregion
    }
}
