using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_Assignment1_CarrieNg.Controllers
{
    public class Greeting2Controller : ApiController
    {/// <summary>
    /// displays greeting to an input number of people
    /// </summary>
    /// <param name="id">the input number</param>
    /// <returns>Greeting to input number people!</returns>
    /// <example>
    /// api/Greeting2/3 -> "Greetings to 3 people!"
    /// </example>
        public String Get(String id){
            return "Greetings to " + id + " people!"; 
        }
    }
}
