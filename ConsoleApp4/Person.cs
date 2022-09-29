using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class Person
    {
        private int _age;

        public Person(int age)
        {
            _age = age;
        }
        
        public void getInfo()
        {
            Console.WriteLine($"возраст жильца - {_age} лет");
        }
    }
   
}
