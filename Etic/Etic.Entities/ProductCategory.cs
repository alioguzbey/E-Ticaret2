using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Core;

namespace Etic.Entities
{
    public class ProductCategory : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Key]
        public int CategoryId { get; set; }
        public int? Sort { get; set; }
    }
}
