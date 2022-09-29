using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_CarrieNg.Controllers
{
    public class NumberMachineController : ApiController
    {/// <summary>
    /// displays the input number after mathimatical operations have been applied
    /// </summary>
    /// <param name="id">input number</param>
    /// <returns>input number multiped by 5, plus 1, divided by 3, subtract 3 </returns>
    /// <example>
    /// api/NumberMachine/1 -> -1
    /// api/NumberMachine/3 -> 2
    /// </example>
        public int Get(int id)
        {
            return ((id * 5) + 1)/3 -3; 
        }
    }
}
