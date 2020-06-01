using DigitalLibrary.DataAccess.Models;
using DigitalLibrary.Interface.ViewModel;
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
    public class LibraryViewModel : BaseViewModel
    {
        LibraryEntityDTO Entity = new LibraryEntityDTO();
        ObservableCollection<LibraryEntityDTO> _libraryEntities = new ObservableCollection<LibraryEntityDTO>();
        LibraryEntityDTO _libraryEntity = new LibraryEntityDTO();
        public ObservableCollection<LibraryEntityDTO> libraryEntities { get { return _libraryEntities; } }
        public LibraryEntityDTO libraryEntity { get { return _libraryEntity; } }
        ICommand loadEntites;
        ICommand loadEntityByID;
        LibraryEntityDTO GetEntityDTO (int id )
        {
            loadEntityByID = new LoadByIdCommand(id);
            loadEntityByID.Execute(_libraryEntity);
            return _libraryEntity;
        }

        public LibraryViewModel ()
        {
            loadEntites = new LoadCommand();
            _libraryEntities = GetEntities();
        }


        public ObservableCollection<LibraryEntityDTO> GetEntities()
        {
            if (libraryEntities == null || libraryEntities.Count == 0)
                loadEntites.Execute(_libraryEntities);
            return _libraryEntities;
        }
    }
}
