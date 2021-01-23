using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcSE1Server.Services
{
    public class CategoryService : Category.CategoryBase
    {
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(ILogger<CategoryService> logger)
        {
            _logger = logger;
        }

        public override Task<ProductInfo> AddProduct(ProductCreate request, ServerCallContext context)
        {
            return base.AddProduct(request, context);
        }

        public override Task<CategoryInfo> CreateCategory(CategoryCreate request, ServerCallContext context)
        {
            return base.CreateCategory(request, context);
        }

        public override Task<CategoryInfo> GetCategory(CategoryLookup request, ServerCallContext context)
        {
            return base.GetCategory(request, context);
        }

        public override Task<ProductInfo> GetProductById(ProductLookup request, ServerCallContext context)
        {
            return base.GetProductById(request, context);
        }
    }
}
