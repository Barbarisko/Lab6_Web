using System;

namespace TestLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                TestClass test = new TestClass("Helen", "1234");

                Console.WriteLine("input auth info. name first:");
                string name = Console.ReadLine();
                Console.WriteLine("passwd:");
                string paswd = Console.ReadLine();

                int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
                int[] denom = { 2, 0, 4, 4, 0, 8 };

                try
                {
                    //auth exception
                    test.AuthCheck(name, paswd);

                    //argument out of range
                    Console.WriteLine("input size of the array to test(range 10-13):");
                    int testsize = Convert.ToInt32(Console.ReadLine());
                    test.InitMassiv(testsize);

                    //divide by zero, null reference, index out of range
                    var list = test.MassDivision(numer, denom);                    
                }
                catch (IndexOutOfRangeException e) when (numer.Length > denom.Length)
                {
                    CatchActions(e);
                }
                catch(AuthException e)
                {
                    CatchActions(e);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    CatchActions(e);
                }
                catch (DivideByZeroException e)
                {
                    CatchActions(e);
                }
                catch (NullReferenceException e) 
                {
                    CatchActions(e);
                }
                catch (Exception e) 
                {
                    CatchActions(e);
                }
            }
        }

        private static  void CatchActions(Exception e)
        {
            Console.WriteLine("\n" + e.GetType() + "/ " + e.Message + "\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
