using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Domain.Exceptions
{
    public class DuplicatedPortfolioImageException : Exception
    {
        public DuplicatedPortfolioImageException(string msg) : base (msg)
        {
            
        }
    }
}
