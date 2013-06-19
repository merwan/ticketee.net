using System.Collections.Generic;

namespace Ticketee.Models
{
    public class InMemoryProjectRepository : IProjectRepository
    {
        public IEnumerable<Project> GetAllProjects()
        {
            return new[] { new Project { Name = "aze" }, new Project { Name = "qsd" }, new Project { Name = "wxc" } };
        }
    }
}