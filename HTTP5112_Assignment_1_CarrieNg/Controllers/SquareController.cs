using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_CarrieNg.Controllers
{
    public class SquareController : ApiController
    {/// <summary>
    /// displays the square of the input number (the input number multiped by itself)
    /// </summary>
    /// <param name="id">the input number</param>
    /// <returns>
    /// the input number sqared
    /// </returns>
    /// <example>
    /// api/Square/2 -> 4
    /// </example>
        public int Get(int id)
        {
            int square = id * id;
            return square;
        }
    }
}
