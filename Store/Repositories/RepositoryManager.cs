using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IProductRepository _productRepository;

        public RepositoryManager(IProductRepository productRepository, RepositoryContext context , ICategoryRepository categoryRepository)
        {
            this._productRepository = productRepository;
            this._context = context;
            this._categoryRepository = categoryRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}