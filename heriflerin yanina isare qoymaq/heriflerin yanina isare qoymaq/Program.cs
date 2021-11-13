using System;
using System.Collections.Generic;

namespace heriflerin_yanina_isare_qoymaq
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<int> IntegerNumbers = new List<int>() { 1, 2, 4, 6, 12 };
            //for (int i = 0; i < IntegerNumbers.Count; i++)
            //{
            //    IntegerNumbers[i] = IntegerNumbers[i] * 3;
            //Console.WriteLine(IntegerNumbers[i]);
            //}


            #region task herfler
            //List<string> herfler = new List<string>() { "A", "B", "C" };
            //for (int i = 0; i < herfler.Count; i++)
            //{
            //    herfler[i] = herfler[i].PadLeft(2, '#').PadRight(3, '#');
            //    Console.WriteLine(herfler[i]);
            //}
            #endregion

            Car car1 = new Car() { Brand = "car1", Model = "1", DoorCount = 4 };
            Car car2 = new Car() { Brand = "car2", Model = "2", DoorCount = 2 };
            Car car3 = new Car() { Brand = "car3", Model = "3", DoorCount = 2 };
            Car car4 = new Car() { Brand = "car4", Model = "4", DoorCount = 2 };
            Car car5 = new Car() { Brand = "car5", Model = "5 ", DoorCount = 4 };

            List<Car> Cars = new List<Car>() { car1, car2, car3, car4, car5 };

            foreach (var item in Cars)
            {
                item.ShowInfo();

            }
        }
            class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int DoorCount { get; set; }
            public void ShowInfo()
            {
                Console.WriteLine($"{Brand}  {Model}  {DoorCount}");
            }
        }
    }
}

