using System;
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
        public Priority Priority { get; set; } = Priority.Low;
    }
}
