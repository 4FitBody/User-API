namespace FitnessApp.Infrastructure.News.Handlers;

using FitnessApp.Infrastructure.News.Queries;
using FitnessApp.Core.News.Models;
using MediatR;
using FitnessApp.Core.News.Repositories;

public class GetByIdHandler : IRequestHandler<GetByIdQuery, News>
{
    private readonly INewsRepository newsRepository;

    public GetByIdHandler(INewsRepository newsRepository) => this.newsRepository = newsRepository;

    public async Task<News> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(request.Id);

        var exercise = await this.newsRepository.GetByIdAsync((int)request.Id);

        if (exercise is null)
        {
            return new News();
        }

        return exercise!;
    }
}