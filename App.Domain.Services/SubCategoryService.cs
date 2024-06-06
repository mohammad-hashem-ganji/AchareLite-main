using App.Domain.Core.CategoryService.DTOs;
using App.Domain.Core.CategoryService.Entities;
using App.Domain.Core.CategoryService.Services;
using App.Infra.DataAccess.Repo.Ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly SubCategoryRepository _subCategoryRepository;

        SubCategoryService(SubCategoryRepository subCategoryRepository)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public void Creat(string name)
        {
            _subCategoryRepository.Creat(name);
        }

        public void Delete(int id)
        {
            _subCategoryRepository.Delete(id);
        }

        public SubCategory Edit(int id)
        {
            var entity = _subCategoryRepository.Edit(id);
            return entity;
        }

        public List<SubCategory> GetAll()
        {
            var entities = _subCategoryRepository.GetAll();
            return entities;
        }

        public void Update(int id, SubCategoryDto sub)
        {
            _subCategoryRepository.Update(id, sub);
        }
    }
}
