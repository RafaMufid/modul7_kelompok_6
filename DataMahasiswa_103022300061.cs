using System;
using System.Text.Json;

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Mahasiswa
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }
}

public class DataMahasiswa_103022300061
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("jurnal7_1_103022300061.JSON");
            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonContent);

            if (mhs != null)
            {
                Console.WriteLine($"Nama : {mhs.firstName} {mhs.lastName}");
                Console.WriteLine($"Gender : {mhs.gender}");
                Console.WriteLine($"Umur: {mhs.age}");
                Console.WriteLine($"Alamat: Jalan {mhs.address.streetAddress}, Kota {mhs.address.city}, Provinsi {mhs.address.state}");
                Console.WriteLine($"Mengambil mata kuliah :");
                for (int i = 0; i < mhs.courses.Count; i++)
                {
                    Console.WriteLine($"- {mhs.courses[i].code} : {mhs.courses[i].name}");
                }
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan atau format salah");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file: {ex.Message}");
        }
    }
}