using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDILifeCycle.Services
{
    public class MyFatherService
    {
        public static int CreationCount { get; private set; }

        private readonly MyChildService _myChildService;

        public MyFatherService(MyChildService myChildService)
        {
            _myChildService = myChildService;
            CreationCount++;
        }
    }
}
