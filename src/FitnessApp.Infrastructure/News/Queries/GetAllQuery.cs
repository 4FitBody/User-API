namespace FitnessApp.Infrastructure.News.Queries;

using FitnessApp.Core.News.Models;
using MediatR;

public class GetAllQuery : IRequest<IEnumerable<News>>
{

}