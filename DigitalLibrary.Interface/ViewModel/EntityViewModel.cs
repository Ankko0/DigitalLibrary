using DigitalLibrary.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Interface.ViewModel
{
    class EntityViewModel : BaseViewModel
    {
        LibraryEntityDTO _libraryEntity = new LibraryEntityDTO();

        public LibraryEntityDTO libraryEntity { get { return _libraryEntity; } }

        /*EntityViewModel(LibraryEntityDTO t)
        {
            _libraryEntity = t;
        }*/

    }
}
