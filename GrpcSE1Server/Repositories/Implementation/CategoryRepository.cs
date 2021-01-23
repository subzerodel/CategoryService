using GrpcSE1Server.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcSE1Server.Repositories.Implementation
{
    public class CategoryRepository
    {
        private readonly DataContext _context;

        public CategoryRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Models.Category> AddCategory(CategoryCreate category)
        {
            var newCategory = new Models.Category
            {
                Name = category.Name
            };

            await _context.CategoryList.AddAsync(newCategory);
            await _context.SaveChangesAsync();

            return newCategory;
        }

        public async Task<Models.Category> GetCategory(int id)
        {
            return await _context.CategoryList.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public async Task<Models.Category> DeleteCategory(int id)
        {
            var categoryToDelete = await _context.CategoryList.FirstOrDefaultAsync(x => x.Id.Equals(id));
            _context.CategoryList.Remove(categoryToDelete);
            await _context.SaveChangesAsync();
            return categoryToDelete;
        }
    }
}
