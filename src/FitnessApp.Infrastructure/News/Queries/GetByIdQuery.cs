namespace FitnessApp.Infrastructure.News.Queries;

using FitnessApp.Core.News.Models;
using MediatR;

public class GetByIdQuery : IRequest<News>
{
    public int? Id { get; set; }

    public GetByIdQuery(int? id)
    {
        this.Id = id;
    }

    public GetByIdQuery() { }
}