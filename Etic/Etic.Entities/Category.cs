using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Core;

namespace Etic.Entities
{
    // 1. yeni tablo geldiğinde ilk olarak entity oluşturulur.
    public class Category : IEntity
    {
        public int Id { get; set; }  
        public string Name { get; set; }  
        public int Sort { get; set; }
        public string? IconName { get; set; }
        public string? Link { get; set; }
        public int? ParentId { get; set; }
        public string SeoLink { get; set; }
    }
}
