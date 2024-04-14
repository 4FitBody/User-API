namespace FitnessApp.Infrastructure.SportSupplements.Handlers;

using FitnessApp.Infrastructure.SportSupplements.Queries;
using FitnessApp.Core.SportSupplements.Models;
using MediatR;
using FitnessApp.Core.SportSupplements.Repositories;

public class GetByIdHandler : IRequestHandler<GetByIdQuery, SportSupplement>
{
    private readonly ISportSupplementRepository sportSupplementRepository;

    public GetByIdHandler(ISportSupplementRepository sportSupplementRepository) => this.sportSupplementRepository = sportSupplementRepository;

    public async Task<SportSupplement> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request.Id);

        var exercise = await this.sportSupplementRepository.GetByIdAsync((int)request.Id);

        if (exercise is null)
        {
            return new SportSupplement();
        }

        return exercise!;
    }
}