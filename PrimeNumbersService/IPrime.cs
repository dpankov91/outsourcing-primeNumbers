using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersService
{
    public interface IPrime
    {
        public List<string> GetPrimeAndNonPrimeNumberCounter(int startNumber, int endNumber);
        public List<string> GetAllPrimeAndNonPrimeNumberBeforeFirstNumber(int startNumber, int endNumber);
        public string ListOfPrimeInProcentBetween(int listOfPrimeBetween);
        public string ListOfPrimeInProcentbeforeLowest(int listOfPrimeBefore);
    }
}
