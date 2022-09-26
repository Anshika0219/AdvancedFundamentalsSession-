using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");// print the value and move the cursor to next line
            Console.Write("welcome");// stay in the same line
            Console.ReadLine();//it is used to read a value
            // data types
             Boolean cd = true;
            Console.WriteLine(cd);// 1 byte
            char c = 'a';
            Console.WriteLine(c);// 2 byte
            int a = 4; // 4 byte
            Console.WriteLine(a);
             float b = 1.2f; // 4 byte
            Console.WriteLine(b);
             string e = "hello"; // 2 byte
            Console.WriteLine(e);
             double f = 3.66; // 8 byte
            Console.WriteLine(f);

            // type casting
            /* string a = "7";
             int b = Convert.ToInt32(a);// converting string to integer
             Console.WriteLine(b);
             double c = 123.45;
             int d = Convert.ToInt32(c);// convert double to integer
             Console.WriteLine(d);*/

            // operaters 
            // Arithmetic operators
            int m=4,n=2, res;
             res = m + n;
            Console.WriteLine(res);
            res = m - n;
            Console.WriteLine(res);
            res = m * n;
            Console.WriteLine(res);
            res = m / n;
            Console.WriteLine(res);
            // assignment operator
            int s = 8, t = 4;
            Console.WriteLine(s += t);
            Console.WriteLine(s -= t);
            Console.WriteLine(s *= t);
            Console.WriteLine(s /= t);
            // Relation operator
             int num1=5, num2=7;
             bool result;
             result = (num1 == num2);
            Console.WriteLine(result);// equal 
            result = (num1 > num2);
            Console.WriteLine(result);//greater
            result = (num1 < num2);
            Console.WriteLine(result);// less then
            result = (num1 >= num2);
            Console.WriteLine(result);// greater equal
            result = (num1 <= num2);
            Console.WriteLine(result);// less then equal
            result = (num1 != num2); // not equal
             Console.WriteLine(result);
            // logical operator
             bool j = true, k = false, l;
               l = j && k; // and both value are true then result true
            Console.WriteLine(l);
            l = j || k; // or one value are true then result is true
            Console.WriteLine(l);
            l = !j; // not opposite value return
               Console.WriteLine(l); 

            // bitwise operator
             int p = 8, q = 7, Result;
             // Bitwise AND Operator
             Result = p & q;
             Console.WriteLine(Result);
            // Bitwise OR Operator
            Result = p | q;
             Console.WriteLine(Result);
             // Bitwise XOR Operator
             Result = p ^ q;
             Console.WriteLine(Result);
            // increment operator
            int u = 5, v = 4;
              Console.WriteLine(++u + ++v);
            // ternary operator
            int x = 20, y = 10, z;
               z = ((x > y) ? x : y);
               Console.WriteLine(z);
            // conditional statement
            int num = 8;
             if (num%2 ==  0)
             {
                 Console.WriteLine("true");
             }
             else {
                 Console.WriteLine("false");
             }
            // switch statement
             int h = 4;
              switch (h)
              {
                  case 0:
                      Console.WriteLine("sunday");
                      break;
                  case 1:
                      Console.WriteLine("monday");
                      break;
                  case 2:
                      Console.WriteLine("Tuesday");
                      break;
                  case 3:
                      Console.WriteLine("wednesday");
                      break;
                  case 4:
                      Console.WriteLine("thrusday");
                      break;
                  case 5:
                      Console.WriteLine("friday");
                      break;
                  case 6:
                      Console.WriteLine("saturday");
                      break;
                  default:
                      Console.WriteLine("invalid");
                      break; 
              }

            // looping statement 
             int g = 2;
            for (int i = 1; i <=10; i++)
             {
                 Console.WriteLine(g*i);
             }
            // while loop
             int lo = 0;
              while (lo <= 10)
              {
                  Console.WriteLine(lo);
                  lo+=2;
              }
            // do while loop
             int ab = 0;
              do
              {
                  Console.WriteLine(ab);
                  ab++;
              } while (ab <= 5);
            // jumping statement
            for (int w = 0; w <= 7; w++)
            {
                Console.WriteLine(w) ;
                if (w == 3)
                    break;
            }
            // continue statement
            for (int r = 0; r <= 7; r++)
            {

                if (r == 3)
                    continue;
                Console.WriteLine(r);
            }
        }
    }
}
