using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204060
{
    class Program
    {
        static void Main(string[] args)
        {
            // memnaggil generic method Penjumlahan
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 02, 20));

            // validasi generic class SimpleDataBase
            SimpleDataBase<long> db = new SimpleDataBase<long>();
            db.AddNewData(0);
            db.AddNewData(13);
            db.AddNewData(02);
            db.AddNewData(20);
            db.PrintAllData();
        }
    }
}
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T x, T y, T z)
        {
            dynamic val_x = x;
            dynamic val_y = y;
            dynamic val_z = z;
            return val_x + val_y + val_z;
            
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            this.inputDates.Add(DateTime.Now);
            this.storedData.Add(newData);
        }

        public void PrintAllData()
        {
            for (int i = 1; i < this.inputDates.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] +
                    ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
            }
        }
    }