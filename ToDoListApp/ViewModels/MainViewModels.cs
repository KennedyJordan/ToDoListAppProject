using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Commands;

namespace ToDoListApp.ViewModels
{
	class MainViewModel : INotifyPropertyChanged
	{
		private string enteredTaskName = "";
		private ObservableCollection<TaskViewModels> tasks = new ObservableCollection<TaskViewModels>();
		public string EnteredTaskName { get { return enteredTaskName; } set { if (enteredTaskName != value) { enteredTaskName = value; OnPropertyChanged(nameof(EnteredTaskName)); } } }
		public ObservableCollection<TaskViewModels> Tasks { get { return tasks; } set { tasks = value; } }
		public CreateTaskCommand CreateTask => new CreateTaskCommand();

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	internal class TaskViewModels
	{
		public string TaskName { get; set; }
		public bool IsDone { get; set; }

	}
}
