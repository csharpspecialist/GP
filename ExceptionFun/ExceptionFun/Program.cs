using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionFun
{
    class Program
    {
        static void Main(string[] args)
        {
           // CauseException();
          // HandleException();
           // HandleSpecException();
           // FinallyEx();
         //  Callstack();
            ThrowCustomExep();
            Console.ReadLine();

        }

        static void CauseException()
        {
            int x = 17;
            int y = 0;

            Console.WriteLine(x/y);

        }

        static void HandleException()
        {
            try
            {
                CauseException();
            }
            catch //(Exception)
            {
                Console.WriteLine("You did something bad, but I am going to keep running");
               
            }
            Console.WriteLine("I am still here!!!");
        }

        static void HandleSpecException()
        {
            try
            {
                int[] nums = new int[] {2, 5};
                nums[2] = 20;

                nums[1] = 21;

            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Your index is out of range");
            }
            catch
            {
                Console.WriteLine("AN EXCEPTION HAPPENED...DON'T CRY!!!!");
            }
        }

        static void FinallyEx()
        {
            try
            {
                int x = 3;
                int y = 7;

                Console.WriteLine(x/y);

            }
            catch (DivideByZeroException dex)
            {

                Console.WriteLine("You cannot divide by zero...we thought u Knew!!!");
            }
            finally
            {
                Console.WriteLine("Finaly Block...executed!!!");
            }


        }


        static void Callstack()
        {
            try
            {
                Method1();
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Catch clause in Callstack example for DIV by Zero");
            }

            finally
            {
                Console.WriteLine("Finally block executed!!!! Yesss!!!!");
            }

            Console.WriteLine("I am still running!!!");
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException)
            {

                Console.WriteLine("Catch clause for method 1 for nullref exception");
            }
            finally
            {
                Console.WriteLine("Finally clause in Method1");
            }

            
        }

        static void Method2()
        {
            try
            {
                CauseException();
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Catch block in Method2 for index out of range excepiton");
            }
            finally
            {
                Console.WriteLine("Method 2 Finally block right here!!!!!");
            }
        }

        static void ThrowCustomExep()
        {
            try
            {
                throw new MySpecificException("I am now using MYspecific exception!!!Right now!!!");
            }
            catch (MySpecificException mex)
            {
                Console.WriteLine(mex.Message); 
                Console.WriteLine(mex.StackTrace);
                Console.WriteLine(mex.HelpLink);


                //  throw;
            }
        }
    }







}
