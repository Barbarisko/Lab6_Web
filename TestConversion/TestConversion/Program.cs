using System;

namespace TestConversion
{
    public class Person
    {
        String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class PersonWithId : Person
    {
        String _id;

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            try
            {
                PersonWithId pid = (PersonWithId)p;
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversion failed.");
            }

            PersonWithId pid1 = new PersonWithId();
            pid1.Name = "John";
            pid1.Id = "246";
            Person p1 = pid1;
            try
            {
                PersonWithId pid1a = (PersonWithId)p1;
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversion failed.");
            }

            Person p2 = null;
            try
            {
                PersonWithId pid2 = (PersonWithId)p2;
                Console.WriteLine("Conversion succeeded.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Conversion failed.");
            }
        }
    }
    // The example displays the following output:
    //       Conversion failed.
    //       Conversion succeeded.
    //       Conversion succeeded.        }
}

 

