public static long[] NumbersWithDigitInside(long x, long d)
{
    var list = new List<long>();
    long sum = 0;
    long multi = 1;
    for (int i = 1; i <= x; i++)
    {
        if (i.ToString().Contains(d.ToString()))
        {
            list.Add(i);
        }
    }
    long count = list.Count;
    for (int j = 0; j < list.Count; j++)
    {
        sum += list[j];
        multi *= list[j];
    }
    if (count == 0)
    {
        multi = 0;
    }
    var arr = new long[3] { count, sum, multi };
    foreach (var item in arr)
    {
        Console.WriteLine(item);
    }
    return arr;

}