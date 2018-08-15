using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoman.Core
{
    public class ResultDisplay
    {
        private readonly Cinema cinema;

        public ResultDisplay(Cinema cinema)
        {
            this.cinema = cinema;
        }

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
