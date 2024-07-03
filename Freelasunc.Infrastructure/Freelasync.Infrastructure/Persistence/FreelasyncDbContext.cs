using Freelasync.Core.Entities;

namespace Freelasync.Infrastructure.Persistence;
public class FreelasyncDbContext
{
    public List<Project> Projects { get; set; }
    public List<User> Users { get; set; }
    public List<Skill> Skills { get; set; }
    public List<ProjectComment> ProjectComments { get; set; }

    public FreelasyncDbContext()
    {
        Projects = new List<Project>
        {
            new Project("Meu Projeto ASPNET Core 1", "minha Descricao do Projeto 1", 1, 1, 10000),
            new Project("Meu Projeto ASPNET Core 2", "minha Descricao do Projeto 2", 1, 1, 20000),
            new Project("Meu Projeto ASPNET Core 3", "minha Descricao do Projeto 3", 1, 1, 30000)
        };

        Users = new List<User>
        {
            new User("Junio Rodrigues", "jrodrigues@gmail.com", new DateTime(1994, 1, 9)),
            new User("Maria Rodrigues", "mrodrigues@gmail.com", new DateTime(1999, 10, 5)),
            new User("Brenda Rodrigues", "brodrigues@gmail.com", new DateTime(1999, 7, 2))
        };

        Skills = new List<Skill>
        {
            new Skill(".NET Core"),
            new Skill("SQL Server"),
            new Skill("RabbitMQ")


        };
    }

}
