using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Countries.Entities
{
    public class Country
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Capital { get; set; }
        public int? Popilation { get; set; }
        public double? Area { get; set; }
        public virtual Continent? Continent { get; set; }

    }
}
