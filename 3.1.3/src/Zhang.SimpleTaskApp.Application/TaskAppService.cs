using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using Zhang.SimpleTaskApp.Tasks;

namespace Zhang.SimpleTaskApp
{
    public class TaskAppService: SimpleTaskAppAppServiceBase, ITaskAppService
	{
		private readonly IRepository<Task1> _taskRepository;
		public TaskAppService(IRepository<Task1> taskRepository)
		{
			_taskRepository = taskRepository;
		}
		public async Task<ListResultDto<TaskListDto>> GetAll(GetAllTasksInput input)
		{
			var tasks = await _taskRepository
			   .GetAll()
			   .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
			   .OrderByDescending(t => t.CreationTime)
			   .ToListAsync();
			return new ListResultDto<TaskListDto>(ObjectMapper.Map < List<TaskListDto>>(tasks));
		}
	}
}
