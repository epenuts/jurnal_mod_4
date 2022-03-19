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