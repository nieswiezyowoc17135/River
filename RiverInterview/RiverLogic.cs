using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiverInterview
{
    public class RiverLogic
    {
        //deklaracja pierwszej rzeki
        public List<int> river1 = new List<int>();
        //deklaracja drugiej rzeki
        public List<int> river2 = new List<int>();


        //metoda sprawdzajaca 
        public void EqualChecker(List<int> firstRiver, List<int> secondRiver)
        {
            do{
                if (firstRiver.Last() == secondRiver.Last())
                {
                    Console.WriteLine("Miejsce spotkania to " + firstRiver.Last());
                } else if (secondRiver.Last() > firstRiver.Last())
                {
                    RiverNextElementCreator(firstRiver.Last(), river1);
                } else if (firstRiver.Last() > secondRiver.Last())
                {
                    RiverNextElementCreator(secondRiver.Last(), river2);
                }
            } while (firstRiver.Last()!= secondRiver.Last());
            Console.WriteLine("Miejsce spotkania rzek to " + firstRiver.Last());
        }

        //metoda dodająca do rzeki nowa wartosc
        public void RiverNextElementCreator(int element, List<int> whichRiver)
        {
            //sumowanie wszystkich 'elementow' liczby
            int sum = 0;
            //zamiana na string w celu zrobienia sumy
            string temporaryString = element.ToString();
            for (int i = 0; i < temporaryString.Length; i++)
            {
                //kody ascii
                sum += Convert.ToInt32(temporaryString[i]) - 48;
            }

            //dodawanie do listy sumy
            whichRiver.Add(sum + element);
        }

    }
}
