using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BOopsConceptPractiseProblem
{
    //Constructor name is same as class name
    //It cannot create objects
    public class ConstructBuilding
    {
        public string Input;
        public int faxNumber;
        //This is parameterless constructor
        public ConstructBuilding()
        {
            Console.WriteLine("This is parameterless constructor");
        }
        //This is a parameterized constructor
        public ConstructBuilding(string data, int pinCode)
        {
            Input = data;
            Console.WriteLine($"This is a parameterised constructor, parameter :  {Input} , {pinCode}");
            Console.WriteLine(Input);
        }
        public ConstructBuilding(string Name, int faxNumber, char grade, int numOne, int numTwo)
        {
            Input = Name;
            this.faxNumber = faxNumber;
            int multiplication = numOne * numTwo;
            Console.WriteLine("Multiplication of two numbers : " + multiplication);
            Console.WriteLine("He has received grade : " + grade);
            Console.WriteLine("Bridgelabz with fax number : " + faxNumber);
            Console.WriteLine(Input);
        }
    }
}
