using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Zhang.SimpleTaskApp.Tasks;

namespace Zhang.SimpleTaskApp
{
	[AutoMapTo(typeof(Task1))]
	public class CreateTaskInput
	{
		[Required]
		[MaxLength(Task1.MaxTitleLength)]
		public string Title { get; set; }

		[MaxLength(Task1.MaxDescriptionLength)]
		public string Description { get; set; }

		public Guid? AssignedPersonId { get; set; }
	}
}
