﻿using DigitalLibrary.DataAccess.Models;
using DigitalLibrary.Interface.Helpers;
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
            var loadedEtities = parameter as ObservableCollection<LibraryEntityDTO>;
            if (loadedEtities != null)
            {
                var entityList = WebRequestHelper.GetAPI("https://localhost:44363/api/LibaryEntities/");
                foreach (var entity in entityList)
                    loadedEtities.Add(entity);
   
            }
        }
    }
}

