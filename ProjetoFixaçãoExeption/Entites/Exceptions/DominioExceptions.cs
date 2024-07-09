using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFixaçãoExeption.Entites.Exceptions
{
    internal class DominioExceptions : ApplicationException
    {
        public DominioExceptions(string message) : base(message)
        {

        }
    }
}
