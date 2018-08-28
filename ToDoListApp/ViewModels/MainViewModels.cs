using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp.ViewModels
{
	class MainViewModel
	{
		public string EnteredTaskName { get; set; }
		public List<TaskViewModels> Tasks {get; set;}
	}

	internal class TaskViewModels
	{
		public string TaskName { get; set; }
		public bool IsDone { get; set; }

	}
}
