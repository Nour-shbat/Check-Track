using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Track
{
    class Passenger
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string SeatNumber { get; set; }
        public Passenger(string name, int age, string seatNumber)
        {
            Name = name;
            Age = age;
            SeatNumber = seatNumber;
        }
        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Seat: {SeatNumber}";
        }
    }
}
