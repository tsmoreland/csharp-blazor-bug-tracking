using BugTrackerUI.Model;
using Microsoft.AspNetCore.Components;

namespace BugTrackerUI.Pages
{
    public class NewBugBase : ComponentBase
    {
        public Bug AddBug { get; private set; } = new Bug();

        [Inject]
        public IBugService BugService { get; private set; } = null!; 

        [Inject]
        public NavigationManager NavService { get; private set; } = null!;

        protected void HandleValidSubmit()
        {
            BugService?.AddBug(AddBug);
            NavService?.NavigateTo("");
        }
    }
}
