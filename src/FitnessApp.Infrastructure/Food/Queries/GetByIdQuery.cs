namespace FitnessApp.Infrastructure.Food.Queries;

using FitnessApp.Core.Food.Models;
using MediatR;

public class GetByIdQuery : IRequest<Food>
{
    public int Id { get; set; }

    public GetByIdQuery(int Id)
    {
        this.Id = Id;
    }

    public GetByIdQuery() { }
}
