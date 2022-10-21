using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// juniorEF2020 Problem J3:Art
        /// </summary>
        /// <param name="N">number of drops of paint</param>
        /// <param name="X">the coordinate X of a drop of paint on the canvas.</param>
        /// <param name="Y">the coordinate Y of a drop of paint on the canvas</param>
        /// <returns>
        /// The first line represents the coordinates of the bottom-left corner of the rectangular frame.
        /// The second line represents the coordinates of the top-right corner of the rectangular frame.</returns>
        /// comment: I don't know how to gather more than one input at the same time.
        [HttpGet]
        [Route("api/J3/Art/{N}/{X}/{Y}")]
        public IEnumerable <string> Get (int N, int[] X, int[] Y)
        {

            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            
            for (int i = 0; i <N; i++)
            {
                
                a = Math.Min(Math.Min(X[i], X[i+1]), Math.Min(X[i], X[i + 2])) - 1;
                b = Math.Min(Math.Min(Y[i], Y[i + 1]),Math.Min(Y[i], Y[i+2]))- 1;
                c = Math.Max(Math.Max(X[i], X[i+1]), Math.Max(X[i], X[i + 2])) + 1;
                d = Math.Max(Math.Max(Y[i], Y[i+1]), Math.Max(Y[i], Y[i+2])) + 1;
       
                
            }
            return new string[] { a + "," + b, c + "," + d };



        }
    }
}
