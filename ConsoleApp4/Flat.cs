using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Flat
    {
        private Person[] _persons;
        public Flat()
        {
            _persons = new Person[2];
            
            for(int i = 0; i < _persons.Length; i++)
            {
                var rnd = new Random();
                var age = rnd.Next(18,30);
                _persons[i] = new Person(age);
            }
            
        }
        public void GetInfo(int flatNumber)
        {
            Console.WriteLine($"В квартире номер {flatNumber+1} живут {_persons.Length} человека");
            foreach(var person in _persons)
            {
                person.getInfo();
            }
        }
    }
}
