﻿using Freelasync.Core.Enums;

namespace Freelasync.Core.Entities;
public class Project : BaseEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int IdCliente { get; private set; }
    public int IdFreelancer { get; private set; }
    public decimal TotalCost { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? StartedAt { get; private set; }
    public DateTime? FinishedAt { get; private set; }
    public ProjectStatusEnum Status { get; private set; }

    public List<ProjectComment> Comments { get; private set; }

    public Project(string title, string description, int idCliente, int idFreelancer, decimal totalCost)
    {
        Title = title;
        Description = description;
        IdCliente = idCliente;
        IdFreelancer = idFreelancer;
        TotalCost = totalCost;

        CreatedAt = DateTime.Now;
        Comments = new List<ProjectComment>();
        Status = ProjectStatusEnum.Created;
    }

    public void Cancel()
    {
        if (Status == ProjectStatusEnum.InProgress || Status == ProjectStatusEnum.Created)
            Status = ProjectStatusEnum.Cancelled;
    }

}
