﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Zhang.SimpleTaskApp.Tasks
{
	[Table("AppTasks")]
	public class Task1 : Entity, IHasCreationTime
	{
		public const int MaxTitleLength = 256;
		public const int MaxDescriptionLength = 64 * 1024; //64KB

		[Required]
		[MaxLength(MaxTitleLength)]
		public string Title { get; set; }

		[MaxLength(MaxDescriptionLength)]
		public string Description { get; set; }

		public DateTime CreationTime { get; set; }

		public TaskState State { get; set; }

		public Task1()
		{
			CreationTime = Clock.Now;
			State = TaskState.Open;
		}

		public Task1(string title, string description = null)
			: this()
		{
			Title = title;
			Description = description;
		}
	}

	public enum TaskState : byte
	{
		Open = 0,
		Completed = 1
	}
}