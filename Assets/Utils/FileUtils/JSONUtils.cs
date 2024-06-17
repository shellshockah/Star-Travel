using System.IO;
using UnityEngine;

public class JSONUtils
{
    public static string getJsonStr(string filename)
    {
        return File.ReadAllText(filename);
    }

    public static T deserialize<T>(string jsonStr)
    {
        return JsonUtility.FromJson<T>(jsonStr);
    }
}
