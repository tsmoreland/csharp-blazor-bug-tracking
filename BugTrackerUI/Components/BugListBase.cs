using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace BugTrackerUI.Components
{
    public class BugListBase : ComponentBase
    {
        public List<Bug> Bugs { get; set; } = new List<Bug>();

        [Inject]
        public IBugService BugService { get; private set; } = null!;

        protected override void OnInitialized()
        {
            Bugs = BugService
                .GetBugs()
                .OrderBy(x => x.Priority)
                .ToList();
        }
    }
}
