using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    /// <summary>
    /// Class responsible for proper displaying repertoir
    /// </summary>
    public class ResultDisplay
    {
        private readonly Cinema cinema;
        /// <summary>
        /// Constructor take as parameter Cinema type which store data about movies and repertoir
        /// </summary>
        /// <param name="cinema"></param>
        public ResultDisplay(Cinema cinema)
        {
            this.cinema = cinema;
        }
        /// <summary>
        /// Method generate string with repertoir
        /// </summary>
        /// <returns>Return string with repertoir</returns>
        public string GenerateResult()
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            int j = 0;
            foreach (var item in cinema.Films)
            {
                if (item.Showings.Count > 0)
                {
                    foreach (var item2 in item.Showings)
                    {
                        if (item2.DatePrefix.Equals(DatePrefix.Dzisiaj))
                        {
                            for (int i = j; i < 1; i++)
                            {
                                resultStringBuilder.AppendLine(item2.DateLong);
                                j++;
                            }
                            resultStringBuilder.AppendLine(item.Title);
                            foreach (var item3 in item2.Times)
                            {
                                resultStringBuilder.Append(item3.TimeTime + "\t");
                                //Console.Write(item3.TimeTime + "\t");                              
                            }
                            resultStringBuilder.AppendLine();
                        }
                    }
                }
            }

            return resultStringBuilder.ToString();
        }
    }
}
