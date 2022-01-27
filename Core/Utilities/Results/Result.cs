using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult//implemente ettik
    {
        public bool Success { get; }         //okun yanına ne yazarsan o nu return eder


        public string Message { get; }        //bu sadece get- read only - fakat yukarıdakii gibi constructor içerisinde set edilebilri

        public Result(bool success, string message):this(success)//yani tek parametre verrisem tek beni,  ikinci parametre scuucess i de verirsem aşağıdaki ctor resultu da çalıştır

        {//bu ctor un içerisinei temizledik-Bizim ctorumuz 2 parametre istiyor
          //bu blok çalışınca aşağıdaki de çalışıyor =tihs kullan
            Message = message;
            Success = success;


            //sadece ctor içeriisnde set edilebilir
        }//bu ctor kullanımı kodların standardize olması için kullanıyoruz,
        //programcı kafasına göre set edemesin diye, ctor ile set ettiriyoz

        public Result(bool success)
        {
            Success = success;

        }

            //sadece ctor içeriisnde set edilebilir
        
         //okun yanına ne yazarsan o nu return eder

    }
}
