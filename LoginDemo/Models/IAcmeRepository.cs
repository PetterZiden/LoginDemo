using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public interface IAcmeRepository
    {
        string GetHeader();

    }

    public class AcmeDBRepository : IAcmeRepository
    {
        public string GetHeader()
        {
            return "Welcome (from db)";
        }
    }

    public class AcmeTestRepository : IAcmeRepository
    {
        public string GetHeader()
        {
            return "Welcome (test)";
        }
    }
}
