using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca.Model
{
    internal class Station
    {
        private Train trainSmall = new Train(TrainSize.Small);
        private Train trainBig = new Train(TrainSize.Big);
        private int ticketEarnings = 0;


        public void LoadVehichleToTrain(Vehicle vehicle, Worker worker)
        {
            if (VehicleIsSmall(vehicle))
            {
                worker.CheckStatusOfVehicle(vehicle, trainSmall);
            }
            else
            {
                worker.CheckStatusOfVehicle(vehicle, trainBig);
            }
            ticketEarnings += vehicle.Type.GetValue();

        }

        private static bool VehicleIsSmall(Vehicle vehicle)
        {
            return vehicle.Type == VehicleTyp.Car || vehicle.Type == VehicleTyp.Van;
        }

        public void GetTotalMoneyMade() => Console.WriteLine("Total money Made from this Station:" + ticketEarnings);

    }
}
