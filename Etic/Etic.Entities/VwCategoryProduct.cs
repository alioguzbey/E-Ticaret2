using Etic.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etic.Entities
{
    public class VwCategoryProduct : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? BrandId { get; set; }

        public string SeoLink { get; set; }

        public string ProductDescription { get; set; }

        public string Tags { get; set; }

        public int CategoryId { get; set; }

        public int? Sort { get; set; }

        public string SeoLinkCat { get; set; }

        public string ImageUrl { get; set; }

    }
}
