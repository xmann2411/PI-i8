using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca.Model
{
    internal class Worker
    {
        public readonly int LOW = 10;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }


        public double Quocient { get; set; }

        public void CheckStatusOfVehicle(Vehicle vehicle, Train train)
        {


            if (train.getCapacity() > 0)
            {
                AddToSalary(vehicle.Type.GetValue());
                train.LowerCapacity();
                if (vehicle.TankSize < LOW)
                {
                    Console.WriteLine(GetFullName() + "-" + vehicle.Type.ToString() + "- gas size is: " + vehicle.TankSize + "% full");
                    Console.WriteLine("Gas has been refilled");
                    Console.WriteLine();
                    vehicle.FillUpGas();
                    Console.WriteLine(GetFullName() + "'s " + vehicle.GetType() + " gas size is " + vehicle.TankSize + "% full");

                }
                if (vehicle.BatterySize < LOW)
                {
                    Console.WriteLine(GetFullName() + "'s " + vehicle.Type.ToString() + " battery size is " + vehicle.BatterySize + "% full");
                    Console.WriteLine("Battery is currently refilling...");
                    Console.WriteLine();
                    vehicle.FillUpBattery();
                    Console.WriteLine(GetFullName() + "'s " + vehicle.BatterySize.ToString() + " battery size is " + vehicle.BatterySize + "% full");

                }
            }
        }

        public Worker(string firstName, string lastName, double quocient)
        {
            FirstName = firstName;
            LastName = lastName;
            Quocient = quocient;
        }

        private void AddToSalary(double fare)
        {
            Salary += fare * Quocient;

        }
        private string GetFullName() => $"{FirstName} {LastName}";

        public void GetEmployeeMoneyMade() => Console.WriteLine(GetFullName() + " made:" + Salary);
    }
}
