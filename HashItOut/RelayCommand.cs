﻿using System;
using System.Windows.Input;

namespace HashItOut
{
    /// <summary>
    /// Represents a command.
    /// </summary>
    public class RelayCommand : ICommand
    {
        Action executeMethod;

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommand"/> class with an action.
        /// </summary>
        public RelayCommand(Action executeMethod) => this.executeMethod = executeMethod;

        /// <summary>Implements <see cref="ICommand.CanExecute(object)"/>.</summary>
        public bool CanExecute(object parameter) => true;

        /// <summary>Implements <see cref="ICommand.CanExecuteChanged"/>.</summary>
        public event EventHandler CanExecuteChanged = delegate { };

        /// <summary>Implements <see cref="ICommand.Execute(object)"/>.</summary>
        public void Execute(object parameter) => executeMethod?.Invoke();
    }
}