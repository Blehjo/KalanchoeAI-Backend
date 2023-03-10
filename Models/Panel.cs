using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KalanchoeAI_Backend.Models;

namespace KalanchoeAI_Backend.Models
{
	public class Panel
	{
        public int PanelId { get; set; }

        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }
        public User? User { get; set; }

        public ICollection<Note>? Notes { get; set; }
    }
}