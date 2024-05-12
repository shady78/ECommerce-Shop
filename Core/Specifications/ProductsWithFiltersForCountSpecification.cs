using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithFiltersForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFiltersForCountSpecification(ProductSpecParams productParams) 
        : base(p => 
        (string.IsNullOrEmpty(productParams.Search) || p.Name.ToLower().Contains(productParams.Search)) && 
        (!productParams.BrandId.HasValue || p.ProductBrandId == productParams.BrandId) &&
        (!productParams.TypeId.HasValue || p.ProductTypeId == productParams.TypeId))
        {
            
        }

     
}
}