using System;
using System.Text.Json;

//Masih error belum bisa running

public class GlossDef
{
    public string para { get; set; }
    public string[] glossSeeAlso { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string sortAs{ get; set; }
    public string glossTerm { get; set; }
    public string acronym { get; set; }
    public string abbrev { get; set; }
    public GlossDef glossDef { get; set; }
    public string glossSee { get; set; }
}

public class GlossList
{
    public GlossEntry glossEntry { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList glossList{ get; set; }
}

public class Glossary
{
    public string title { get; set; }
    public GlossDiv glossDiv{ get; set; }
}

public class GlossaryItem_103022300061
{
    public static void ReadJSON()
    {
        try
        {
            string jsonContent = File.ReadAllText("jurnal7_1_103022300061.JSON");
            Glossary glos = JsonSerializer.Deserialize<Glossary>(jsonContent);

            if (glos != null)
            {
                Console.WriteLine("Glossary GlosEntry: ");
                Console.WriteLine($"ID -> {glos.glossDiv.glossList.glossEntry.ID}");
                Console.WriteLine($"SortAs -> {glos.glossDiv.glossList.glossEntry.sortAs}");
                Console.WriteLine($"GlossTerm -> {glos.glossDiv.glossList.glossEntry.glossTerm}");
                Console.WriteLine($"Acronym -> {glos.glossDiv.glossList.glossEntry.acronym}");
                Console.WriteLine($"Abbrev -> {glos.glossDiv.glossList.glossEntry.abbrev}");
                Console.WriteLine($"GlossDef : ");
                Console.WriteLine($"    para -> {glos.glossDiv.glossList.glossEntry.glossDef.para}");
                Console.WriteLine($"    GlossSeeAlso -> {glos.glossDiv.glossList.glossEntry.glossDef.glossSeeAlso}");
                Console.WriteLine($"GlossSee -> {glos.glossDiv.glossList.glossEntry.glossSee}");
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