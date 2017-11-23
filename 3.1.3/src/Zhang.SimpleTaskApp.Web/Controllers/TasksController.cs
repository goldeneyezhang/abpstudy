using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zhang.SimpleTaskApp.Web.ViewModel;

namespace Zhang.SimpleTaskApp.Web.Controllers
{
    public class TasksController : SimpleTaskAppControllerBase
	{
		private readonly ITaskAppService _taskAppService;
		public TasksController(ITaskAppService taskAppService)
		{
			_taskAppService = taskAppService;
		}
        public async Task<ActionResult> Index(GetAllTasksInput input)
        {
			var output = await _taskAppService.GetAll(input);
			var model = new IndexViewModel(output.Items)
			{
				SelectedTaskState = input.State
			};
            return View(model);
        }
    }
}