using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroFunctions
{
    class Program
    {
        public void Show_Out_Param(out int val) // Out parameter  
        {
            int square = 5;
            val = square;
            val *= val; // Manipulating value  
        }

        public void Show_By_Value(int val) // Call By Value
        {
            val *= val;
            Console.WriteLine($"Value in the Function Call By value {val}");
        }

        public void Show_By_Reference(ref int val) // Call By reference
        {
            val *= val;
            Console.WriteLine($"Value in the Function Call By value {val}");
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val = 50;
            Program program = new Program(); 
            Console.WriteLine("Value before passing out variable " + val);
            program.Show_By_Value(val);
            Console.WriteLine("Value After calling call by Value" + val);
            program.Show_By_Reference(ref val);
            Console.WriteLine("Value After calling call by Reference" + val);
            program.Show_Out_Param(out val);
            Console.WriteLine("Value after recieving the Out variable " + val);
            Console.ReadLine();
        }
    }
}
