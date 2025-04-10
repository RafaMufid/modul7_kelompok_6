using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_6
{
    public class Address
    {
        public string steetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Mahasiswa
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address;
        public MataKuliah[] courses;
    }

    class DataMahasiswa103022300045
    {
        public void ReadJSON()
        {
            try
            {
                string jsonContent = File.ReadAllText("C:\\Users\\Muhammad Zaky A\\Documents\\Semester 4\\KPL PRAKTIKUM MOD 7\\modul7_kelompok_6\\jurnal7_1_103022300045.json");
                Mahasiswa mahasiswa1 = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);
                if(mahasiswa1 != null)
                {
                    Console.WriteLine($"Nama: {mahasiswa1.firstName} {mahasiswa1.lastName}, Gender:{mahasiswa1.gender}, Age: {mahasiswa1.age}, address: {mahasiswa1.address.steetAddress}{mahasiswa1.address.city}{mahasiswa1.address.state}");
                    Console.WriteLine($"Mata Kuluah {0}{1} - {2}", 1, mahasiswa1.courses[0].code, mahasiswa1.courses[0].name);
                }
                else
                {
                    Console.WriteLine("Gagal membaca data"); 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Terjadi Kesalahan: {ex.Message}");
            }
            
        }
    }
}
