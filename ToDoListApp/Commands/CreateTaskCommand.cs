﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoListApp.ViewModels;

namespace ToDoListApp.Commands
{
	class CreateTaskCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			// CanExecuteChanged?.Invoke(this, EventArgs.Empty);
			if (parameter is MainViewModel viewModel)
			{
				return !string.IsNullOrWhiteSpace(viewModel.EnteredTaskName);
			}
			else
			{
				return false;
			}
		}

		public void Execute(object parameter)
		{
			if(parameter is MainViewModel viewModel)
			{
				viewModel.Tasks.Add(new TaskViewModels() { IsDone = false, TaskName = viewModel.EnteredTaskName });
				viewModel.EnteredTaskName = "";
				CanExecuteChanged.Invoke(this, EventArgs.Empty);
			}
		}
	}
}