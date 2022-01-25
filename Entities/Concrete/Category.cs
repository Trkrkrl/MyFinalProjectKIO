using Core.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{//çıplak class kalmasın: 
    public class Category:IEntity//bu imza sayesinde bir veritabanı nesnesi olduğu belli olur
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
