using Post.Query.Domain.Entities;
using Post.Query.Domain.Repositories;

namespace Post.Query.Api.Queries
{
	public class QueryHandler : IQueryHandler
	{
		private readonly IPostRepository _posRepository;

		public QueryHandler(IPostRepository postRepository)
		{
			_posRepository = postRepository;
		}

		public async Task<List<PostEntity>> HandleAsync(FindAllPostsQuery query)
		{
			return await _posRepository.ListAllAsync();
		}

		public async Task<List<PostEntity>> HandleAsync(FindPostByIdQuery query)
		{
			var post = await _posRepository.GetByIdAsync(query.Id);

			return new List<PostEntity> { post };
		}

		public async Task<List<PostEntity>> HandleAsync(FindPostsByAuthorQuery query)
		{
			return await _posRepository.ListByAuthorAsync(query.Author);
		}

		public async Task<List<PostEntity>> HandleAsync(FindPostsWithCommentsQuery query)
		{
			return await _posRepository.ListWithCommentsAsync();
		}

		public async Task<List<PostEntity>> HandleAsync(FindPostsWithLikesQuery query)
		{
			return await _posRepository.ListWithLikesAsync(query.NumberOfLikes);
		}
	}
}
