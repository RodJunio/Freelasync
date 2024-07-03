namespace Freelasync.Core.Entities;
public class ProjectComment : BaseEntity
{
    public string Content { get; private set; }
    public int IdProject { get; private set; }
    public int IdUser { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public ProjectComment(int idProject, int idUser, string content)
    {
        IdProject = idProject;
        IdUser = idUser;
        Content = content;
    }
}
