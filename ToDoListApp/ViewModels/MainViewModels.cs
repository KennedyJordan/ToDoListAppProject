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
		public string EnteredTaskName { get; set; }
		public List<TaskViewModels> Tasks { get; set; }
		public CreateTaskCommand CreateTask => new CreateTaskCommand();
	}

	internal class TaskViewModels
	{
		public string TaskName { get; set; }
		public bool IsDone { get; set; }

	}
}
