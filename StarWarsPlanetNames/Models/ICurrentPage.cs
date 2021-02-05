using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarWarsApi.Models
{
     public interface ICurrentPage
    {
        public int CurrentPage { get; set; }
    }
}
