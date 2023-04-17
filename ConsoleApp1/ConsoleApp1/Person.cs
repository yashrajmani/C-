using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {


        //VARS
        string pName;
        int pAge;


        //SETTERS
        public void SetName(string uname)
        {
            pName = uname;
        }

        public void SetAge(int uage)
        {
           pAge = uage;
        }

        //GETTERS
        public string GetName()
        {
            return pName;
        }
        public int GetAge()
        {
            return pAge;
        }



       public void PrintData()
        {
           Console.WriteLine("-- Hello From the Person class -- ");
           Console.WriteLine("Person Name : "+ pName);
           Console.WriteLine("Person Age : "+ pAge);
        }



    }
}
