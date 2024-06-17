using System;
using System.Linq;



public class identificationValue
{
    public char[] value = new char[32];
    private static Random random = new Random();

    public identificationValue()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        for(int i = 0; i < value.Length; i++)
        {
            value[i] = chars[random.Next(chars.Length)];
        }
    }
}
