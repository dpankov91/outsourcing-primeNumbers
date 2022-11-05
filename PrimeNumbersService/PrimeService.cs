using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersService
{
    public class PrimeService : IPrime
    {
        public List<string> GetAllPrimeAndNonPrimeNumberBeforeFirstNumber(int firstNumber, int secondNumber)
        {
            int neededNumber = 0;

            if (firstNumber < secondNumber){
                neededNumber = firstNumber;
            }
            else if (firstNumber > secondNumber || firstNumber == secondNumber)          
                neededNumber = secondNumber;


            int primeCounter = 0;
            int nonPrimeCounter = 0;

            for (int i = 0; i < neededNumber; i++)
            {
                if (isPrime(i))
                    primeCounter++;
                else
                    nonPrimeCounter++;
            }

            string primeCounterString = primeCounter.ToString();
            string nonPrimeCounterString = nonPrimeCounter.ToString();

            List<string> listOfPrimeBefore = new List<string>();

            listOfPrimeBefore.Add(primeCounterString);
            listOfPrimeBefore.Add(nonPrimeCounterString);

            return listOfPrimeBefore;
        }

        public List<string> GetPrimeAndNonPrimeNumberCounter(int startNumber, int endNumber)
        {
            throw new NotImplementedException();
        }

        public string ListOfPrimeInProcentbeforeLowest(int listOfPrimeBefore)
        {
            throw new NotImplementedException();
        }

        public string ListOfPrimeInProcentBetween(int listOfPrimeBetween)
        {
            throw new NotImplementedException();
        }

        public bool isPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
