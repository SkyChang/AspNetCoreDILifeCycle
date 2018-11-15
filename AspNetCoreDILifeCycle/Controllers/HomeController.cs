using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreDILifeCycle.Services;

namespace AspNetCoreDILifeCycle.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly MyFatherService _myFatherService;
        private readonly MyMotherService _myMotherService;

        public HomeController(MyFatherService myFatherService, MyMotherService myMotherService)
        {
            _myFatherService = myFatherService;
            _myMotherService = myMotherService;
        }


        [HttpGet]
        public string Get()
        {
            return $"Father Creation Count : {MyFatherService.CreationCount}. Mother Creation Count : {MyFatherService.CreationCount}. Child Creation Count : {MyChildService.CreationCount}";
        }

        
    }
}
