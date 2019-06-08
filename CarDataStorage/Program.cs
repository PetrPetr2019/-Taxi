using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>
            {
                new Truck{ModelAvto = "Камаз", Carrying = 20, DataofIssue = 1999, DataofMajorOverhaur = 2015, NumberGos = 374532, EncryptPark = 23, ID = 1},
                new Truck{ModelAvto = "Белаз", Carrying = 200, DataofIssue = 2000, DataofMajorOverhaur = 2018, NumberGos = 34853, EncryptPark =12, ID = 2}
            };
            List<Taxi> taxis = new List<Taxi>
            {
              new Taxi{MarkaAvto = "Audi - 6", NumberPassengerSeat = 5, Data = 2000, GosNUmber = "С 065MK-78rus", EncryptPark = 55, ID =1},
              new Taxi{MarkaAvto ="BMW", NumberPassengerSeat = 4, Data = 2017, GosNUmber = "АН 7331-47КRus", EncryptPark = 45, ID = 2},
              new Taxi{MarkaAvto = "Lada Granta", NumberPassengerSeat = 6, Data = 1975, GosNUmber = "Н 700УУ-37rus"}
            };
            List<Autopark> autoparks = new List<Autopark>
            {
                new Autopark{NamePark = "7-автобусный парк", AdressPlacement = "Город Москва", SqerAreaAvto = 2000, Encrypt =45, ID = 1},
                new Autopark{NamePark = "33-авто парк", AdressPlacement = "Новые черемушки", SqerAreaAvto = 100, Encrypt = 33, ID = 2}
            };
            var Query = from TaxiNumber in taxis // Подсчет количества машин в парке
                        group TaxiNumber by TaxiNumber.MarkaAvto into t
                        select new
                        {
                            t.Key,
                        };

            int count = taxis.Count();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Количество машин в парке\n" + count);


            // Группировка данных  с использованием group

            //var Query = from TaxiCar in taxis
            //            group TaxiCar by TaxiCar.MarkaAvto into t
            //            select new
            //            {
            //                t.Key,
            //            };
            //foreach(var Taxis in taxis)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("\nМарка машины:{0} -Дата выпуска:{1}", Taxis.MarkaAvto, Taxis.Data);
            //}

            // Сортировка по дате выпуска с применением запроса Linq
            //var Query = from Cars in taxis
            //            orderby Cars.Data ascending
            //            select new
            //            {
            //                Cars.Data,
            //            };
            //foreach(var Ca in Query)
            //{
            //    Console.WriteLine("\n{0}", Ca.Data);
            //    Console.BackgroundColor = ConsoleColor.Red;
            Console.ReadLine();
        }
    }
}
