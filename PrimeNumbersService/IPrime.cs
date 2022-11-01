using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersService
{
    public interface IPrime
    {
        public List<string> GetPrimeAndNonPrimeNumberCounter(int number, int number2);
        public List<string> GetAllPrimeAndNonPrimeNumberbeforefirstNumber(int number, int number2);
        public string ListOfPrimeInProcentBetween(int listofprimebetween);
        public string ListOfPrimeInProcentbeforeLowest(int listofprimebefore);
    }
}
