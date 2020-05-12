using System.ComponentModel;

namespace BugTrackerUI
{
    public enum Priority
    {
        [Description("Very Low")]
        VeryLow,
        [Description("Low")]
        Low,
        [Description("Medium")]
        Medium,
        [Description("High")]
        High,
        [Description("Very High")]
        VeryHigh,
    }
}
