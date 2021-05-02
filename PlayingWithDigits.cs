using System;
using System.Linq;
public class DigPow
{
    public static long digPow(int n, int p)
    {
        var sum = 0d;
        var x = n.ToString().ToList();
        for (int i = 0; i < x.Count; i++)
        {
            var y = Math.Pow(Char.GetNumericValue(x[i]), p + i);
            sum += y;
        }
        Console.WriteLine(sum);
        return sum % n == 0 ? (long)sum / n : -1;
    }
}