using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Core;

namespace Etic.Entities
{
    public class Slider : IEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public int Sort { get; set; }
        public string? Header1 { get; set; }
        public string? Header2 { get; set; }
        public string? ProductLink { get; set; }
        public string? Name { get; set; }
    }
}
