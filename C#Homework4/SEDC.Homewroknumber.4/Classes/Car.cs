using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homewroknumber._4.Classes
{
    public class Car
    {
        public string Model { get; set; }   
        public Driver Driver { get; set; }
        public int Speed { get; set; }

        public Car( string model, Driver driver, int speed) {
            Model = model;
            Driver = driver;
            Speed = speed;
        }
        public Car (string model, int speed)
        {
            Model = model;
            Speed=speed;
        }
        public Car()
        {

        }
        public int CalculateSpeed (Driver driver)
        {
            int resultWithDriver = Speed * driver.Level;
            Console.WriteLine($"result with own driver{Driver.Name} is {Speed * Driver.Level}");
            Console.WriteLine($"result with {driver.Name} is " + resultWithDriver);
            return resultWithDriver;
            
        }
        public void raceCars(Car car)
        {
            if (Speed*Driver.Level > car.Speed*car.Driver.Level) {
                Console.WriteLine($"{Model} is faster then {car.Model} ");
                Console.WriteLine($"Winning car is model{Model} driving by {Driver.Name} with speed {Speed} and coeficient {Driver.Level*Speed}");
                Console.ResetColor();
                Console.WriteLine($"Just to know the loosing car is with speed {car.Speed} and coeficient {car.Driver.Level * car.Speed} ");
            }
            if (Speed * Driver.Level > car.Speed * car.Driver.Level) { Console.WriteLine("they are the same "); }
            else { Console.WriteLine($"{car.Model} is faster then {Model} ");
                Console.WriteLine($"Winning car is model{car.Model} driving by {car.Driver.Name} with speed {car.Speed} and coeficient {car.Driver.Level * car.Speed}");
                Console.ResetColor();
                Console.WriteLine($"Just to know the loosing car is with speed {Speed} and coeficient {Driver.Level * Speed} ");
            }
        }

    }
}
