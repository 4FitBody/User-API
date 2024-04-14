namespace FitnessApp.Infrastructure.SportSupplements.Queries;

using FitnessApp.Core.SportSupplements.Models;
using MediatR;

public class GetByIdQuery : IRequest<SportSupplement>
{
    public int? Id { get; set; }

    public GetByIdQuery(int? id)
    {
        this.Id = id;
    }

    public GetByIdQuery() { }
}