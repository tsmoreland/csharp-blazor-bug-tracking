﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BugTrackerUI
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(10)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, 5)]
        public int Priority { get; set; } = -1;
    }
}
