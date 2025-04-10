using System;
using System.Text.Json;

public class Team1
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class TeamList1
{
    public List<Team1> courses { get; set; }
}

public class TeamMember_103022300037
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("jurnal7_2_103022300037.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            TeamList1 courseList = JsonSerializer.Deserialize<TeamList1>(jsonContent, options);

            if (courseList != null && courseList.courses != null)
            {
                Console.WriteLine("Daftar team member");

                // Gunakan for loop biasa
                for (int i = 0; i < courseList.courses.Count; i++)
                {
                    Console.WriteLine($"- {courseList.courses[i].code}: {courseList.courses[i].name}");
                }
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan atau format salah.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan saat membaca file: {ex.Message}");
        }
    }
}
