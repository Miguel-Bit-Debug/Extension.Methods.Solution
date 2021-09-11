using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.API.Extension.Methods
{
    public static class Birthday
    {
        public static string BirthDay(this DateTime date, int dia, int mes, int ano)
        {
            return string.Concat(dia, mes, ano);
        }
    }
}
