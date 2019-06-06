using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
   public class Taxi
    {
        public int ID { get; set; }
        public string MarkaAvto { get; set; }// Марка авто
        public int NumberPassengerSeat { get; set; }// Количество посадочных мест
        public int Data { get; set; }// Дата выпуска
        public int GosNUmber { get; set; }// Государственный номер
        public int EncryptPark { get; set; }// Шифр автопарка
    }
}
