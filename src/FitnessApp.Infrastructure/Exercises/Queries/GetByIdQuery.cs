namespace FitnessApp.Infrastructure.Exercises.Queries;

using FitnessApp.Core.Exercises.Models;
using MediatR;

public class GetByIdQuery : IRequest<Exercise>
{
    public int? Id { get; set; }

    public GetByIdQuery(int? id)
    {
        this.Id = id;
    }

    public GetByIdQuery() { }
}