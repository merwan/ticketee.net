using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Ticketee.Controllers;
using Ticketee.Models;

namespace Ticketee.Tests.Controllers
{
    [TestClass]
    public class ProjectControllerTests
    {
        [TestMethod]
        public void Index()
        {
            Mock<IProjectRepository> repository = new Mock<IProjectRepository>();
            var projects = new[] { new Project(), new Project(), new Project() };
            repository.Setup(x => x.GetAllProjects()).Returns(projects);

            ProjectController projectController = new ProjectController(repository.Object);
            var result = projectController.Index() as ViewResult;
            var projectViewModel = result.Model as ProjectViewModel;

            Assert.AreEqual(3, projectViewModel.Projects.Count());
        }
    }
}