using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto//Ar

    {//Ientitiy miz Core da Entities de, yain normal entities ler için olan
     //interfacei en yukarı katman core da aynı adlı klasöre koyduk

        // fakat bu tek bir tablo değil
        // --  TABLOLAR birleşimi de olabilr
        //Bu yüzden IDTO


        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }









    }
}
