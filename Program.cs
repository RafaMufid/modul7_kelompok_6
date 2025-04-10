using modul7_kelompok_6;
using static modul7_kelompok_6.DataMahasiswa103022300045;

class program
{
    public static void Main(string[] args)
    {
        var data1 = new DataMahasiswa103022300045();
        data1.ReadJSON();
        var anggota = new TeamMember103022300045();
        anggota.ReadJSON();
    }
}