using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MODUL8_1302213091_AFF;

namespace TP_MODUL8_1302213091_AFF
{
    class Program
    {
        static void Main(string[] args)
        {
            CovidConfig config = new CovidConfig();

            Console.WriteLine("Selamat datang di aplikasi pencegahan penyebaran COVID-19");

            while (true)
            {
                Console.WriteLine("\nSilakan masukkan data berikut ini:");
                Console.Write("Berapa suhu badan anda saat ini? Dalam nilai {0}: ", config.SatuanSuhu);
                double suhu = double.Parse(Console.ReadLine());

                if (config.SatuanSuhu.Equals("celcius"))
                {
                    if (suhu < 36.5 || suhu > 37.5)
                    {
                        Console.WriteLine(config.PesanDitolak);
                        continue;
                    }
                }
                else
                {
                    if (suhu < 97.7 || suhu > 99.5)
                    {
                        Console.WriteLine(config.PesanDitolak);
                        continue;
                    }
                }

                Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
                int hariDemam = int.Parse(Console.ReadLine());

                if (hariDemam >= config.BatasHariDemam)
                {
                    Console.WriteLine(config.PesanDiterima);
                }
                else
                {
                    Console.WriteLine(config.PesanDitolak);
                }
            }
        }
    }
}

