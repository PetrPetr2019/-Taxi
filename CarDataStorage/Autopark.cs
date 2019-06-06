using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDataStorage
{
   public class Autopark
    {
        public int ID { get; set; }
        public string NamePark { get; set; }// Название парка
        public string AdressPlacement { get; set; }// Адрес размещения
        public int SqerAreaAvto { get; set; }// Площадь размещения авто
        public int Encrypt { get; set; }// Шифр
    }
}
