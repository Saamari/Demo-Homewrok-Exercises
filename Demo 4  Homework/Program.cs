using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// do { 
//kysy kerros, siirrä hii
namespace Demo_4__Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            int number = 0;
            do
            {
                Console.WriteLine("Push a Button 1-5");
               string line = Console.ReadLine();
                number = int.Parse(line);
                elevator.Floor = number;
                Console.WriteLine("Elevator is in floor " + elevator.Floor);
                


            } while (number != -1);


        }
    }
}
