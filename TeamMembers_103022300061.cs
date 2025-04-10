using System;
using System.Text.Json;

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public string nim { get; set; }
}

public class MemberList
{
    public List<Member> members { get; set; }
}

public class TeamMembers_103022300061
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("jurnal7_2_103022300061.JSON");
            MemberList memberList= JsonSerializer.Deserialize<MemberList>(jsonContent);

            if (memberList != null && memberList.members != null)
            {
                Console.WriteLine("Team Member List: ");
                for (int i = 0; i < memberList.members.Count; i++)
                {
                    Console.WriteLine($"- {memberList.members[i].nim} - {memberList.members[i].firstName} " +
                        $"{memberList.members[i].lastName} ({memberList.members[i].age} {memberList.members[i].gender})");
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