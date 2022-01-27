using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult//hangi tipi döndüreceğini söyle
    {
        T Data { get; }

    }
}
