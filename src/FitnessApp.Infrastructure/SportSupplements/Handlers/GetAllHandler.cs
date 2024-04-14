namespace FitnessApp.Infrastructure.SportSupplements.Handlers;

using FitnessApp.Core.SportSupplements.Models;
using FitnessApp.Core.SportSupplements.Repositories;
using FitnessApp.Infrastructure.SportSupplements.Queries;
using MediatR;

public class GetAllHandler : IRequestHandler<GetAllQuery, IEnumerable<SportSupplement>>
{
    private readonly ISportSupplementRepository sportSupplementRepository;

    public GetAllHandler(ISportSupplementRepository sportSupplementRepository) => this.sportSupplementRepository = sportSupplementRepository;

    public async Task<IEnumerable<SportSupplement>?> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var supplements = await this.sportSupplementRepository.GetAllAsync();

        if (supplements is null)
        {
            return Enumerable.Empty<SportSupplement>();
        }

        return supplements;
    }
}
