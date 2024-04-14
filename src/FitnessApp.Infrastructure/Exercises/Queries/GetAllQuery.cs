namespace FitnessApp.Infrastructure.Exercises.Queries;

using FitnessApp.Core.Exercises.Models;
using MediatR;

public class GetAllQuery : IRequest<IEnumerable<Exercise>>
{

}