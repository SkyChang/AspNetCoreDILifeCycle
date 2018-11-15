using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDILifeCycle.Services
{
    public class MyChildService
    {
        public static int CreationCount { get; private set; }
        public MyChildService()
        {
            CreationCount++;
        }
    }
}
