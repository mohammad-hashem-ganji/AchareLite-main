using App.Domain.Core.CategoryService.DTOs;
using App.Domain.Core.CategoryService.Entities;

namespace App.Domain.Core.CategoryService.Data.Repositories
{
    public interface ICategoryRepository
    {
        void Create(string name);
        List<MainCategory> GetAll();
        void Delete(int id);
        MainCategory Edit(int id);
        void Update(MainCategory sub);
    }
}
