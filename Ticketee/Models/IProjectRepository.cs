using System.Collections.Generic;

namespace Ticketee.Models
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetAllProjects();
    }
}