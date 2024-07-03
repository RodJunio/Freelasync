using Freelasync.Application.InputModels;
using Freelasync.Application.Services.Interfaces;
using Freelasync.Application.ViewModels;
using Freelasync.Core.Entities;
using Freelasync.Infrastructure.Persistence;

namespace Freelasync.Application.Services.Implementations;
public class ProjectService : IProjectService
{
    private readonly FreelasyncDbContext _dbContext;
    public ProjectService(FreelasyncDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public int Create(NewProjectInputModel inputModel)
    {
        var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
        _dbContext.Projects.Add(project);
        return project.Id;
    }

    public void CreateComment(CreateCommentInputModel inputModel)
    {
        var comment = new ProjectComment(inputModel.IdProject, inputModel.IdUser, inputModel.Content);
        _dbContext.ProjectComments.Add(comment);
    }

    public void Delete(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
        project.Cancel();
    }

    public void Finish(int id)
    {
        throw new NotImplementedException();
    }

    public List<ProjectViewModel> GetAll(string query)
    {
        var projects = _dbContext.Projects;
        
        var projectsViewModel = projects.Select(p => new ProjectViewModel
        {
            Title = p.Title,
            CreatedAt = p.CreatedAt,
        }).ToList();

        return projectsViewModel;
    }

    public ProjectDetailsViewModel GetById(int id)
    {
        var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

        var projectViewModel = new ProjectDetailsViewModel(
            project.Id,
            project.Title,
            project.Description,
            project.TotalCost,
            project.StartedAt,
            project.FinishedAt
            );
        
        return projectViewModel;
    }

    public void Start(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(UpdateProjectInputModel inputModel)
    {
        throw new NotImplementedException();
    }
}
