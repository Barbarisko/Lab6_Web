using System;
using System.Collections.Generic;
using System.Text;

namespace TestLab6
{
    public class TestClass
  {
        private string name;
        private  string passw;
        public string Name { get => name; set => name = value; }
        public string Passw { get => passw; set => passw = value; }

        public TestClass(string _name, string _passw)
        {
            Name = _name;
            Passw = _passw;
        }

        public void AuthCheck(string _name, string _passwd)
        {
            if ((_name == string.Empty) || (_name == null))
            {
                throw new AuthException("name not set. input it ");
            }
            if (_name!= Name )
            {
                throw new AuthException("name invalid. input valid name");
            }
            if (Passw != _passwd)
            {
                throw new AuthException("password invalid.");
            }
            if ((_passwd == string.Empty) || (_passwd == null))
            {
                throw new AuthException("password is empty.");
            }
            Console.WriteLine("--auth success\n");
        }

        private int[] shortmass;
        public void InitMassiv(int size){
            if (size > 9 && size < 14)
            {
                shortmass = new int[size];
                Random rand = new Random();
                for (int i = 0; i < shortmass.Length; i++)
                {
                    shortmass[i] = rand.Next();
                }
                Console.WriteLine("--arr init success\n");
            }
            else
            {
                throw new ArgumentOutOfRangeException("--arr init fail. size doesn't meet the requirements");
            }
        }

        public List<int> MassDivision(int[] mass1, int[] mass2)
        {
            List<int> mass3 = new List<int>();
            int[] values = null;

            for (int i = 0; i < mass1.Length; i++) {
                try
                {
                    if (mass2[i] == 0)
                    {
                        mass3.Add(0);
                        throw new DivideByZeroException("second array has a 0. added 0. ");
                    }

                    int a = mass1[i] / mass2[i];
                    mass3.Add(a);
                    Console.WriteLine(mass1[i] + " / " + mass2[i] + " equals " + a);
                    try
                    {
                        values[i] = i * 2;
                        foreach (var value in values)
                            Console.WriteLine(value);
                    }
                    catch (NullReferenceException e)
                    {
                        Console.WriteLine(e.GetType() + "/ " + e.Message);
                    }
                }
                catch (DivideByZeroException e) {
                    Console.WriteLine(e.GetType() + "/ " + e.Message);
                }
            }
            return mass3;
        }

    }
}
