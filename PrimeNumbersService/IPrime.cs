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
        public List<string> GetAllPrimeAndNonPrimeNumberBeforeFirstNumber(int firstNumber, int secondNumber);
        public string ListOfPrimeInProcentBetween(GetAllPrimeAndNonPrimeNumberBeforeFirstNumber(firstnubmer, lastnumber));
        public string ListOfPrimeInProcentbeforeLowest(int listOfPrimeBefore);
    }
}
