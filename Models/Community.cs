﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KalanchoeAI.Models
{
	public class Community
	{
        public int Id { get; set; }

		public int UserId { get; set; }

        public string GroupName { get; set; }

        public string Description { get; set; }
        
        public string? MediaLink { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public User User { get; set; }

		public ICollection<Member>? Members { get; set; }

		public ICollection<Channel>? Channels { get; set; }
	}
}

