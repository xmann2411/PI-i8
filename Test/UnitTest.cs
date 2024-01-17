using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca.Model;

namespace Zadaca.Test
{
    internal class UnitTest
    {
        [Test]
        public void TestTrain()
        {
            Train small = new Train(TrainSize.Small);

            Train big_train = new Train(TrainSize.Big);


            Assert.AreEqual(small.Size, TrainSize.Small);
            Console.WriteLine("test 1. done successfully");

            Assert.AreEqual(small.Size.GetValue(), 6);
            Console.WriteLine("test 2. done successfully");

            Assert.AreEqual(big_train.Size, TrainSize.Big);
            Console.WriteLine("test 3. done successfully");


            Assert.AreEqual(big_train.Size.GetValue(), 8);
            Console.WriteLine("test 4. done successfully");


        }

    }
}
