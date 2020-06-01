using DigitalLibrary.DataAccess.Models;
using DigitalLibrary.Interface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalLibrary.Interface.ViewModel.Commands
{
    public class LoadByIdCommand:ICommand
    {
        public event EventHandler CanExecuteChanged;
        int id;
        public LoadByIdCommand(int id)
        {
            this.id = id;
        }
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            var loadedEtity = parameter as LibraryEntityDTO;
            if (loadedEtity != null)
            {
                 loadedEtity = WebRequestHelper.GetAPI("https://localhost:44363/api/LibaryEntities/" + id.ToString()).SingleOrDefault();

            }
        }
    }
}
