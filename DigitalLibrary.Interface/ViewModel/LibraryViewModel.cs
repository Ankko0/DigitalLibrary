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
        ObservableCollection<LibraryEntityDTO> _libraryEntities = new ObservableCollection<LibraryEntityDTO>();

        public ObservableCollection<LibraryEntityDTO> libraryEntities { get { return _libraryEntities; } }


        public ICommand loadEntites;

        LoadByIdCommand _loadEntityByID;
        public ICommand loadEntityByID
        {
            set
            {
                
            }
            get
            {
                if (_loadEntityByID == null)
                {
                    _loadEntityByID = new LoadByIdCommand();
                }

                return _loadEntityByID;
            }
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
