using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace assignment2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2Controller : ControllerBase
    {

        /// <summary>
        /// Input a string of peppers from the user and calculate the total Scolville Heat Units (SHU).
        /// </summary>
        /// <param name="Ingredients"></param>
        /// <returns>
        /// The sum of the SHU associated with the peppers in the string.
        /// </returns>
        /// <example>
        /// GET: /api/J2/ChiliPeppers?Ingredients=Poblano,Mirasol,Serrano,Cayenne,Thai,Habanero -> 263000
        /// GET: /api/J2/ChiliPeppers?Ingredients=Cayenne,Thai,Poblano,Poblano -> 118000
        /// </example>
        [HttpGet(template: "ChiliPeppers")]
        public int ChiliPeppers([FromQuery] String Ingredients)
        {
            int SHU = 0;
            string[] pepperList = Ingredients.Split(',');
            int ceiling = pepperList.Length;
            for (int i = 0; i < ceiling; i+=1)
            {
                if (pepperList[i] == "Poblano")
                {
                    SHU += 1500;
                }
                else if (pepperList[i] == "Mirasol")
                {
                    SHU += 6000;
                }
                else if (pepperList[i] == "Serrano")
                {
                    SHU += 15500;
                }
                else if (pepperList[i] == "Cayenne")
                {
                    SHU += 40000;
                }
                else if (pepperList[i] == "Thai")
                {
                    SHU += 75000;
                }
                else if (pepperList[i] == "Habanero")
                {
                    SHU += 125000;
                }
                else
                {
                    break;
                }
            }
            return SHU;
        }

        /// <summary>
        /// Input the names and amounts of the bidders and determine the winner of the silent auction.
        /// </summary>
        /// <param name="names"></param>
        /// <param name="amounts"></param>
        /// <returns>
        /// The name of the winner of the silent auction.
        /// </returns>
        /// <example>
        /// GET: /api/J2/silentAuction?names=John,Paul,George,Ringo&amounts=100,200,300,400 -> Ringo
        /// </example>
        [HttpGet(template: "silentAuction")]
        public string silentAuction([FromQuery] string names, [FromQuery] string amounts)
        {
            string winner = "";
            int winningBid = 0;
            string[] nameList = names.Split(',');
            string[] amountList = amounts.Split(',');

            for (int i = 0; i < nameList.Length; i += 1)
            {
                int bid = int.Parse(amountList[i]);
                if (bid > winningBid)
                {
                    winningBid = bid;
                    winner = nameList[i];
                }
            }
            return winner;
        }
    }
}
