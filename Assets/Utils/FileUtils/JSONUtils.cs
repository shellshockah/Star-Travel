using System.IO;

public class JSONUtils
{
    public static string getJsonStr(string filename)
    {
        return File.ReadAllText(filename);
    }
}
