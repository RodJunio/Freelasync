using Freelasync.Application.InputModels;
using Freelasync.Application.ViewModels;

namespace Freelasync.Application.Services.Interfaces;
internal interface IProjectService
{
    List<ProjectViewModel> GetAll(string query);
    ProjectDetailsViewModel GetById(int id);
    int Create(NewProjectInputModel inputModel);
    void Update(UpdateProjectInputModel inputModel);
    void Delete(int id);
    void CreateComment(CreateCommentInputModel inputModel);
    void Start(int id);
    void Finish(int id);
}
