using App.Domain.Core.CategoryService.Data.Repositories;
using App.Domain.Core.CategoryService.Entities;
using App.Infra.DB.SqlServer.EF.DB_Achare;

namespace App.Infra.DataAccess.Repo.Ef
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AchareDbContext _dbContext;

        public CategoryRepository(AchareDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(string name)
        {
            _dbContext.MainCategories.Add(new MainCategory
            {
                Title = name,
            });

            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
           var enetiy = _dbContext.MainCategories.FirstOrDefault(c => c.Id == id);

            if (enetiy != null)
            {
                _dbContext.MainCategories.Remove(enetiy);
                _dbContext.SaveChanges();
            }

        }

        public List<MainCategory> GetAll()
        {
            var categories = _dbContext.MainCategories.ToList();
            return categories;
        }
    }
}
