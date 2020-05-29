using DigitalLibrary.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DigitalLibrary.Interface.ViewModel.Commands
{
    class LoadCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            /*var loadedEtities = parameter as ObservableCollection<LibraryEntityDTO>;
           
            var Entities = Task.Run(() =>LibraryEntityDTO.GetAPIAsync("https://localhost:44363/api/LibaryEntities/")).Result;
                foreach (var item in Entities)
                    loadedEtities.Add(item);*/
            var loadedEtities = parameter as ObservableCollection<LibraryEntityDTO>;
            if (loadedEtities != null)
            {
                TaskFactory taskfac = new TaskFactory();
                taskfac.StartNew(() =>
                {
                    while (true)
                    {
                        var tradelist = Task.Run(() => LibraryEntityDTO.GetAPIAsync("https://localhost:44363/api/LibaryEntities/")).Result;
                        App.Current.Dispatcher.Invoke(new Action(() =>
                        {
                            loadedEtities.Clear();
                            foreach (var trade in tradelist)
                                loadedEtities.Add(trade);
                        }));

                        Thread.Sleep(2000);
                    }
                });
            }


        }
    }
}

