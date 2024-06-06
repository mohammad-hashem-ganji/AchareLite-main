using App.Domain.Core.CategoryService.Data.Repositories;
using App.Domain.Core.CategoryService.DTOs;
using App.Domain.Core.CategoryService.Entities;
using App.Infra.DB.SqlServer.EF.DB_Achare;
using App.Infra.DB.SqlServer.EF.DB_Achare.Ef;

namespace App.Infra.DataAccess.Repo.Ef
{
    public class MainCategoryRepository : ICategoryRepository
    {
        private readonly AchareDbContext _dbContext;

        public MainCategoryRepository(AchareDbContext dbContext)
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

        public MainCategory Edit(int id)
        {
            var mainCategoryEntity = _dbContext.MainCategories.FirstOrDefault(m => m.Id == id);
            return mainCategoryEntity;
        }

        public List<MainCategory> GetAll()
        {
            var categories = _dbContext.MainCategories.ToList();
            return categories;
        }



        public void Update(MainCategory main)
        {
            MainCategory mainCategory = _dbContext.MainCategories.FirstOrDefault(m => m.Id == main.Id);
            mainCategory.Title = main.Title;
            _dbContext.Update(mainCategory);
            _dbContext.SaveChanges();
        }
    }
}
