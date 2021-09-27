using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string printReverseString = delegate(string content){
                char[] charArray = content.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            var productOfTwo = delegate(decimal x, decimal y){
                return x * y;
            }

            var 


            print(HelloWorld);
        }
    }
    
}
