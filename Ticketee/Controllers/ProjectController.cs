using System.Web.Mvc;
using Ticketee.Models;

namespace Ticketee.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController()
            : this(new InMemoryProjectRepository())
        {
        }

        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public ActionResult Index()
        {
            var projects = _projectRepository.GetAllProjects();

            var projectViewModel = new ProjectViewModel { Projects = projects };

            return View(projectViewModel);
        }
    }
}