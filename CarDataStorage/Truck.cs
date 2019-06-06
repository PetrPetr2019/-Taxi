using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
   public class Truck
    {
        public int ID { get; set; }
        public string ModelAvto { get; set; }// Марка машины
        public int Carrying { get; set; }// Грузоподьемность
        public int DataofIssue { get; set; }// Дата выпуска
        public int DataofMajorOverhaur { get; set; }// Дата капитального ремонта
        public int NumberGos { get; set; }// Номер гос номера
        public int EncryptPark { get; set; }// Шифр автопарка
    }
}
