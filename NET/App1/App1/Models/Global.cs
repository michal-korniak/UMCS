using System.Collections.Generic;

namespace App1.Models
{
    class Global
    {
        public List<SingleCount> ListOfSingleCount { get; set; }

        public Global()
        {
        }

        public Global(List<SingleCount> listOfSingleCount)
        {
            ListOfSingleCount = listOfSingleCount;
        }
    }
}
