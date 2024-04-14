namespace FitnessApp.Infrastructure.Food.Queries;

using FitnessApp.Core.Food.Models;
using MediatR;

public class GetAllQuery : IRequest<IEnumerable<Food>>
{

}