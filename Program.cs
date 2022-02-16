using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                char[] characters = { 'H', 'I', 'N' };
                Console.WriteLine(characters[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("First");
                Console.WriteLine("Second:" + e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("@@@@@@@@@@@@");
                Console.WriteLine("Fire");
                Console.WriteLine("@@@@@@@@@@@@");
            }
            
            

            Console.ReadKey();
        }
    }
}
