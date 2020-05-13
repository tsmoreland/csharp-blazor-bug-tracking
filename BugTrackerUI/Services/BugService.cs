using BugTrackerUI.Model;
using System.Collections.Generic;
using System.Linq;

namespace BugTrackerUI.Services
{
    public class BugService : IBugService
    {
        private List<Bug> Bugs { get; } = new List<Bug>();

        public void AddBug(Bug newBug)
        {
            newBug.Id = Bugs.Count + 1;
            Bugs.Add(newBug);
        }

        public void RemoveBug(int id)
        {
            var match = Bugs.FirstOrDefault(bug => bug.Id == id);
            if (match != null)
                Bugs.Remove(match);
        }

        public IEnumerable<Bug> GetBugs() => Bugs.AsEnumerable();

    }
}
