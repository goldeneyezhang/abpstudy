using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using Zhang.SimpleTaskApp.Tasks;

namespace Zhang.SimpleTaskApp
{
    public class GetAllTasksInput
    {
		public Tasks.TaskState? State { get; set; }
    }
	[AutoMapFrom(typeof(Task1))]
	public class TaskListDto:EntityDto,IHasCreationTime
	{
		public Guid? AssignedPersonId { get; set; }
		public string AssignedPersonName { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime CreationTime { get; set;}
		public TaskState State { get; set; }
	}
}
