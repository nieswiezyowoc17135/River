namespace RiverInterview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pierwsze cyfry/liczby rzeki
            int a = 0;
            int b = 0;   
        
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            //tworzenie instancji klasy w ktorej zawarlem logike
            RiverLogic riverLogic = new RiverLogic();

            riverLogic.river1.Add(a);
            riverLogic.river2.Add(b);

            //wywołanie sprawdzenia czy nie sa takie same
            riverLogic.EqualChecker(riverLogic.river1, riverLogic.river2);
        }
    }
}