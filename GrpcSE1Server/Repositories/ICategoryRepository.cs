using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcSE1Server.Models;

namespace GrpcSE1Server.Repositories
{
    public interface ICategoryRepository
    {
        public Task<Models.Category> AddCategory(CategoryCreate category);
        public Task<Models.Category> GetCategory(int id);

        public Task<Models.Category> DeleteCategory(int id);

        public Task<Models.Category> ModifyCategory(Category categoryModel);
    }
}
