namespace FitnessApp.Infrastructure.Exercises.Handlers;

using FitnessApp.Infrastructure.Exercises.Queries;
using FitnessApp.Core.Exercises.Models;
using MediatR;
using FitnessApp.Core.Exercises.Repositories;

public class GetAllHandler : IRequestHandler<GetAllQuery, IEnumerable<Exercise>>
{
    private readonly IExerciseRepository exerciseRepository;

    public GetAllHandler(IExerciseRepository exerciseRepository) => this.exerciseRepository = exerciseRepository;

    public async Task<IEnumerable<Exercise>?> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var exercises = await this.exerciseRepository.GetAllAsync();

        if (exercises is null)
        {
            return Enumerable.Empty<Exercise>();
        }

        return exercises;
    }
}