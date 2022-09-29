using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_CarrieNg.Controllers
{
    public class GreetingController : ApiController
    {/// <summary>
     /// displays "Hello World"
     /// </summary>
     /// <returns>Hello World</returns>
     /// curl -d "" localhost:xxxx/api/Greeting
     /// POST api/Greeting -> "Hello World"
        public String Post()
        {
            return "Hello World";
        }
    }
}
