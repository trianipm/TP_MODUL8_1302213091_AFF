using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace TP_MODUL8_1302213091_AFF
{
    class CovidConfig
    {
        private const string fileName = "C:\\Users\\Asus\\Documents\\SEMESTER 4\\KONTRUKSI PERANGKAT LUNAK\\TP_MODUL8_1302213091_AFF\\TP_MODUL8_1302213091_AFF\\covid_config.json";
        public string SatuanSuhu { get; set; }
        public int BatasHariDemam { get; set; }
        public string PesanDitolak { get; set; }
        public string PesanDiterima { get; set; }

        public CovidConfig()
        {
            LoadConfig();
        }

        private void LoadConfig()
        {
            try
            {
                string configJson = File.ReadAllText(fileName);
                var configData = JsonConvert.DeserializeObject<dynamic>(configJson);

                SatuanSuhu = configData["satuan suhu"] ?? "celcius";
                BatasHariDemam = configData["batas hari demam"] ?? 14;
                PesanDitolak = configData["pesan ditolak"] ?? "Anda tidak diperbolehkan masuk ke dalam gedung ini";
                PesanDiterima = configData["pesan diterima"] ?? "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading configuration file: " + e.Message);
            }
        }

        public void UbahSatuan()
        {
            if (SatuanSuhu.Equals("celcius"))
            {
                SatuanSuhu = "fahrenheit";
            }
            else
            {
                SatuanSuhu = "celcius";
            }
            Console.WriteLine("Satuan suhu telah diubah ke {0}", SatuanSuhu);
        }
    }
}
