using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace HTTP5112_Assignment1_CarrieNg.Controllers
{/// <summary> 
/// use variable for the fee, which is 5.50
/// use a variable for the the number of fortnigts (ie. numbFortnight), by taking the the input id divied by 14 plus 1, becuase 1 fortnight is 14 days)
/// use a variable for the price before tax (ie. price), by multiplying the fee by the number of fortnights.
/// use a variable for the tax (ie. afterTax), by multiply the fee by the number of fortnights then multipy by 0.13
/// use a variable for the total (ie. total), by adding the price plus the afterTax
///<example>
/// GET api/HostingCost/42 -> "4 fortnight at $5.50/FN = $5.50 CAD"
///                           "HST 13% = $2.86 CAD"
///                           "Total = $24.86 CAD"
/// </example>
/// <return>strings to indicated the subtotal amount, the 13% tax, and the total</return>
/// </summary>
    public class HostingCostController : ApiController
    {
        public IEnumerable<String> Get(int id)
        {
            double fee = 5.50;
            int numFortnight = (id/14) + 1;
            double price = numFortnight * fee;
            double afterTax = (fee * numFortnight) * 0.13;
            double total = price + afterTax;

            return new string[]
            {
                 numFortnight + " fortnights at $" + price + "/FN =$" + price + "CAD",
                "HST 13% =" + afterTax + " CAD",
                "Total $" + total + " CAD"
            };
        }
     }

}

