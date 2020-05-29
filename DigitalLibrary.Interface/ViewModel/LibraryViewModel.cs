using DigitalLibrary.DataAccess.Models;
using DigitalLibrary.Interface.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalLibrary.Interface.VievModel
{
    class LibraryViewModel : INotifyPropertyChanged
    {
        LibraryEntityDTO Entity = new LibraryEntityDTO();
        ObservableCollection<LibraryEntityDTO> _libraryEntities = new ObservableCollection<LibraryEntityDTO>();
        public ObservableCollection<LibraryEntityDTO> libraryEntities { get { return _libraryEntities; } }
        ICommand loadEntites;


        public LibraryViewModel ()
        {
            loadEntites = new LoadCommand();
            _libraryEntities = GetEntities();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "") 
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ObservableCollection<LibraryEntityDTO> GetEntities()
        {
            if (libraryEntities == null || libraryEntities.Count == 0)
                loadEntites.Execute(_libraryEntities);
            return _libraryEntities;
        }
    }
}
