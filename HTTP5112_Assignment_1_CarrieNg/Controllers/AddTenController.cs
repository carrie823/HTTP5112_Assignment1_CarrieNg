using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_CarrieNg.Controllers
{ 
    
    public class AddTenController : ApiController
    {/// <summary>
    /// Adds 10 to the input number
    /// </summary>
    /// <param name="id">the input number</param>
    /// <returns>
    /// The input id plus 10
    /// </returns>
    /// <example>
    /// GET api/AddTen/6 -> 16
    /// GET api/AddTen/7 -> 17
    /// </example>
    
        public int Get(int id)
        {
            int add = id + 10;
            return add;

        }

    }

}
