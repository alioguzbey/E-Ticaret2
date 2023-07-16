using Etic.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etic.Business.ControllerHandler
{
    public class ProductListControllerHandler : IProductListControllerHandler
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductImageService _productImageService;
        private readonly IVwCategoryProductService _vwCategoryProductService;
        public ProductListControllerHandler(ICategoryService categoryService, IProductService productService, IProductCategoryService productCategoryService, IProductImageService productImageService, IVwCategoryProductService vwCategoryProductService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _productImageService = productImageService;
            _vwCategoryProductService = vwCategoryProductService;
        }
    }
    public interface IProductListControllerHandler
    {
    }
}
