using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homewroknumber._4.Classes
{
    public class Human
    {
       public string  FirstName { get; set; }
       public string LastName { get; set; }
       public  int Age { get; set; }

    public void GetPersonDetails()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
        }
        public Human (string firstName, string lastName , int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


    }
}
