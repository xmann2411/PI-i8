using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca.Model
{
    public enum VehicleTyp
    {
        [Description("50")]
        Car,
        [Description("80")]
        Van,
        [Description("70")]
        Bus,
        [Description("90")]
        Truck
    }
    
    internal class Vehicle
    {
        public VehicleTyp Type { get; set; }
        public int TankSize { get; set; }

        public int BatterySize { get; set; }

        public Vehicle(VehicleTyp type, int tankSize, int batterySize)
        {
            Type = type;
            TankSize = tankSize;
            BatterySize = batterySize;
        }

        public void FillUpGas()
        {
            this.TankSize = 100;
        }

        public void FillUpBattery()
        {
            this.BatterySize = 100;
        }
    }
}
