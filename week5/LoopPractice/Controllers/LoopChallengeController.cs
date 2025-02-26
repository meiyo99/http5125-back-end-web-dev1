﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreLoopPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoopChallengeController : ControllerBase
    {

        /// <summary>
        /// a string which counts from {start} to {limit} counting by {step} with FizzBuzz rules applied.
        /// </summary>
        /// <param name="start">The starting position</param>
        /// <param name="limit">The limit, either upper limit or lower limit</param>
        /// <param name="step">The value to increment by per loop iteration</param>
        /// <param name="fizzy">The "Fizzy" number, which will be compared for divisibility.</param>
        /// <param name="buzzy">The "Buzzy" number, which will be compared for divisibility.</param>
        /// <returns>A comma deliminated string of integers, representing how to count from {start} to {limit} by {step}. Integers divisible by {fizzy} are replaced with "Fizzy". Integers divisible by {buzzy} are divisible by "Buzzy". Integers divisible by both {fizzy} AND {buzzy} are replaced with "FizzyBuzzy".</returns>
        /// <example>
        /// GET: api/LoopChallenge/FizzyBuzzy/1/25/4/3/7 
        /// ->   "1,5,Fizzy,13,17,FizzyBuzzy,25"
        /// </example>
        /// <example>
        /// GET: api/LoopChallenge/FizzyBuzzy/1/4/1/1/4
        /// ->	"Fizzy, Fizzy, Fizzy, FizzyBuzzy"
        /// </example>
        /// <example>
        /// GET: api/LoopChallenge/FizzyBuzzy/2/15/4/3/4
        ///->	"2,Fizzy,10,14"
        /// </example>
        /// <example>
        /// GET: api/LoopChallenge/FizzyBuzzy/10/60/12/200/200
        ///->	"10,22,34,46,58"
        /// </example>
        /// <example>
        /// GET:  api/LoopChallenge/FizzyBuzzy/-40/-20/3/-2/-5
        ///->	"FizzyBuzzy,-37,Fizzy,-31,Fizzy,Buzzy,Fizzy"
        /// </example>
        [HttpGet(template:"FizzyBuzzy/{start}/{limit}/{step}/{fizzy}/{buzzy}")]
        public string FizzyBuzzy(int start, int limit, int step, int fizzy, int buzzy)
        {
            string message = "";




            return message;
        }

        /// <summary>
        /// Lists the minimum required Canadian denominations of $20 or less to arrive at {amount}
        /// </summary>
        /// <param name="amount">The amount to provide minimum change for.</param>
        /// <returns>A list of strings describing the minimum number of bills and coins needed to achieve the {amount} with a largest denomination of 20.</returns>
        /// <example>
        /// GET : api/LoopChallenge/GetChange/100.23/
	    /// ->	["Twenties : 5","Dimes : 2", "Pennies : 3"]
        /// </example>
        /// <example>
        /// GET : api/LoopChallenge/GetChange/13.68/	
        ///->	["Tens : 1","Toonies : 1","Loonies : 1","Quarters : 2", "Dimes : 1","Nickels : 1","Pennies : 3"]
        /// </example>
        [HttpGet(template:"api/LoopChallenge/GetChange/{amount}")]
        public List<string> GetChange(decimal amount)
        {
            List<string> denominations = new List<string>();
            denominations.Add("Pennies: 0");
            denominations.Add("Nickels: 0");
            denominations.Add("Dimes: 0");
            denominations.Add("Quarters: 0");
            denominations.Add("Loonies: 0");
            denominations.Add("Toonies: 0");

            return denominations;

        }


        /// <summary>
        /// Amy is inventing a new board game with 11 rows, from A to K (A,B,C,D,E,F,G,H,I,J,K). She isn't sure how many columns to have, and would like to see some examples with different column setups.
        /// </summary>
        /// <param name="Cols">The number of columns for the board game.</param>
        /// <returns>A list, with each list item containing a List of Strings. Each string represents a cell on the board {Row}{Col}.</returns>
        /// <example>
        /// GET api/LoopChallenge/GameBoard/1 ->
        /// [["A1","B1","C1","D1","E1","F1","G1","H1,"I1","J1","K1"]]
        /// </example>
        /// <example>
        /// GET api/LoopChallenge/GameBoard/2 ->
        /// [["A1","B1","C1","D1","E1","F1","G1","H1,"I1","J1","K1"],["A2","B2","C2","D2","E2","F2","G2","H2,"I2","J2","K2"]]
        /// </example>
        [HttpGet(template:"GameBoard/{Cols}")]
        public List<List<string>> GameBoard(int Cols)
        {
            return new List<List<string>>();
        }


        
        /// <summary>
        /// Outputs the cells of a chess board, separated by ,
        /// </summary>
        /// <returns>the cells of a chess board from A1 to H8</returns>
        /// <example>
        /// GET api/ChessBoard -> A1,A2,A3,A4,A5,A6,A7,A8,B1,... H7,H8
        /// </example>
        [HttpGet(template: "ChessBoard")]
        public string ChessBoard()
        {

            return "";
        }


    }
}
