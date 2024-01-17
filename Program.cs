using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca.Model;
using Zadaca.Test;

namespace Zadaca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Station terminalSmallTrain = new Station();
            Station terminalLargeTrain = new Station();

            Worker employeeSmallTrain = new Worker("Karla", "Axmann", 0.1);
            Worker employeeLargeTrain = new Worker("Lara", "Krzak", 0.11);


            Vehicle bus = new Vehicle(VehicleTyp.Bus, 80, 30);
            Vehicle van = new Vehicle(VehicleTyp.Car, 20, 50);
            Vehicle truck = new Vehicle(VehicleTyp.Truck, 5, 30);
            Vehicle car = new Vehicle(VehicleTyp.Car, 12, 5);

            terminalLargeTrain.LoadVehichleToTrain(bus, employeeLargeTrain);
            terminalLargeTrain.LoadVehichleToTrain(truck, employeeLargeTrain);


            terminalSmallTrain.LoadVehichleToTrain(car, employeeSmallTrain);
            terminalSmallTrain.LoadVehichleToTrain(van, employeeSmallTrain);

            terminalSmallTrain.GetTotalMoneyMade();
            terminalLargeTrain.GetTotalMoneyMade();

            Console.WriteLine();

            employeeSmallTrain.GetEmployeeMoneyMade();
            employeeLargeTrain.GetEmployeeMoneyMade();

            Console.WriteLine();

            UnitTest test = new UnitTest();
            test.TestTrain();
        }
    }
}
