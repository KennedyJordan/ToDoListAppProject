using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp.Commands;

namespace ToDoListApp.ViewModels
{
	class MainViewModel
	{
		private string enteredTaskName = "";
		private List<TaskViewModels> tasks = new List<TaskViewModels>();
		public string EnteredTaskName { get { return enteredTaskName; } set { enteredTaskName = value; } }
		public List<TaskViewModels> Tasks { get { return tasks; } set { tasks = value; } }
		public CreateTaskCommand CreateTask => new CreateTaskCommand();
	}

	internal class TaskViewModels
	{
		public string TaskName { get; set; }
		public bool IsDone { get; set; }

	}
}
