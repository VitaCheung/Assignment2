using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Total Calories of the meal
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>Your total calorie count is</returns>
        /// <example>
        /// Get:api/J1/Menu/4/4/4/4--> "Your total calorie count is 0"
        /// Get:api/J1/Menu/1/2/3/4--> "Your total calorie count is 691"
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        
        public string Menu (int burger, int drink, int side, int dessert)
        {
            List<int> burgerCal = new List<int> { 461, 431, 420, 0 };
            burger = burgerCal[burger - 1];

            List<int> drinkCal = new List<int> { 130, 160, 118, 0 };
            drink = drinkCal[drink- 1];

            List<int> sideCal = new List<int> { 100, 57, 70, 0 };
            side = sideCal[side - 1];

            List<int> dessertCal = new List<int> { 167, 266, 75, 0 };
            dessert = dessertCal[dessert - 1];

            int TotalCalorie = burger + drink + side + dessert;
            return "Your total calorie count is " + TotalCalorie;
        }
    }
}
