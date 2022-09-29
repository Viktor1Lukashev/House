using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public  class House
    {
        private Flat[] _flats;
        public House()
        {
            _flats = new Flat[20];
            for (int i = 0; i < _flats.Length; i++)
            {
              
                _flats[i] = new Flat();
            }

        }
        public void GetInfo()
        {
            Console.WriteLine($"в этом доме {20} квартир");
            
            for(int i = 0;i<_flats.Length;i++) 
            {
                _flats[i].GetInfo(i);
            }
        }

    

    }
}
