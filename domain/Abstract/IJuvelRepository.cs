using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain.Entities;

namespace domain.Abstract
{
    interface IJuvelRepository
    {
        IEnumerable<FacetingType> FacetingTypes { get; }
    }
}
