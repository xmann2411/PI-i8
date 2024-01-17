using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca.Model
{
    public enum TrainSize
    {
        [Description("8")]
        Big,
        [Description("6")]
        Small,
    }

    internal class Train
    {
        public Train(TrainSize size)
        {
            Size = size;
            setCapacity();
        }

        private int Capacity;

        public int getCapacity() => Capacity;
        private void setCapacity()
        {
            Capacity = Size.GetValue();
        }

        public TrainSize Size { get; set; }

        public void LowerCapacity()
        {
            if (Capacity >= 0)
            {
                Capacity--;
            }
        }
    }
}
