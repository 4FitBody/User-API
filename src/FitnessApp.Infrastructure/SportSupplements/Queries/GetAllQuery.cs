namespace FitnessApp.Infrastructure.SportSupplements.Queries;

using FitnessApp.Core.SportSupplements.Models;
using MediatR;


public class GetAllQuery : IRequest<IEnumerable<SportSupplement>>
{

}
