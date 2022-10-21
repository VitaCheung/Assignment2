using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Roll the Dice
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die</param>
        /// <param name="n">positive integer representing the number of sides on the second die</param>
        /// <returns>The ways she can roll the value of 10.</returns>
        /// <example>
        /// Get: api/J2/DiceGame/6/8 --> "There are 5 total ways to get the sum 10."
        /// Get: api/J2/Dicegame/5/5 --> "There is 1 way to get the sum 10."
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame (int m, int n)
        {
            int count = 0;
            for (int i=1; i<=m; i++)
            {
                for (int j=1; j<=n; j++)
                { if (i + j == 10)
                    {
                        count++;    
                    }

                }
            }
            if (count == 1)
            {
                return "There is " + count + " way to get the sum 10.";
            }
            else
            {
                return "There are " + count + " ways to get the sum 10.";
            }
        }

            
    }
}
