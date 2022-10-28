using System

namespace SearchAlgorithma
{
    class Program 
    {
        // Army to be search
        int[] arr = new int[20];
        // get the number of element  to store in the away
        int n;
        //get the number of element  to store in the way
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elementa in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have maximum 1 and maximum 20 element. \n");
            }
            //accept array element
            Console.WriteLine("")
            Console.WriteLine("-------------------");
            Console.WriteLine("enter array element");
            Console
        }
    }
}