using Core.Utulities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class CarListViewModel
    {
        public IDataResult<List<Car>> Cars { get; internal set; }
    }
}
