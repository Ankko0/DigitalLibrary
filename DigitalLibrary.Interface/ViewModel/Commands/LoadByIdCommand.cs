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

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var loadedEtity = parameter as LibraryEntityDTO;
            if (loadedEtity != null)
            {
                AboutWindow window = new AboutWindow();
                window.Author.Content = loadedEtity.Author;
                window.image.Source = ImageHelper.LoadImage(loadedEtity.Photo);
                window.Name.Content = loadedEtity.Name;
                window.Code.Content = loadedEtity.Code;
                window.Pages.Content = loadedEtity.Pages;
                window.Year.Content = loadedEtity.Year;
                window.Language.Content = loadedEtity.Language;
                window.Type.Content = loadedEtity.Type;
                window.Category.Content = loadedEtity.Category;

                window.Show();
            }
        }
    }
}
