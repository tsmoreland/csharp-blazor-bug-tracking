using BugTrackerUI.Model;
using System.Collections.Generic;

namespace BugTrackerUI
{
    public interface IBugService
    {
        IEnumerable<Bug> GetBugs();

        void AddBug(Bug newBug);
    }
}
