namespace FitnessApp.Infrastructure.Food.Handlers;

using FitnessApp.Infrastructure.Food.Queries;
using FitnessApp.Core.Food.Models;
using MediatR;
using FitnessApp.Core.Food.Repositories;

public class GetAllHandler : IRequestHandler<GetAllQuery, IEnumerable<Food>>
{
    private readonly IFoodRepository foodRepository;

    public GetAllHandler(IFoodRepository foodRepository) => this.foodRepository = foodRepository;

    public async Task<IEnumerable<Food>?> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var food = await this.foodRepository.GetAllAsync();

        if (food is null)
        {
            return Enumerable.Empty<Food>();
        }

        return food;
    }
}