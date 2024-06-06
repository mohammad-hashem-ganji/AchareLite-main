﻿
using App.Domain.Core.CategoryService.Data.Repositories;
using App.Domain.Core.CategoryService.Entities;
using App.Infra.DB.SqlServer.EF.DB_Achare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.DataAccess.Repo.Ef
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly AchareDbContext _dbContext;

        public SubCategoryRepository(AchareDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void Creat(string name)
        {
            _dbContext.Add(new SubCategory { Title = name });
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbContext.SubCategories.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {
                _dbContext.SubCategories.Remove(entity);
                _dbContext.SaveChanges();
            }
        }

        public List<SubCategory> GetAll()
        {
            var subCategories = _dbContext.SubCategories.ToList();
            return subCategories;
        }

        public void Update(int id)
        {
            var entity = _dbContext.SubCategories.FirstOrDefault(s => s.Id == id);
            if (entity != null)
            {

            }
        }
    }
}