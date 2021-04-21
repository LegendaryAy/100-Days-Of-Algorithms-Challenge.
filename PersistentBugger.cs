public static int Persistence(long n)
{
    if (n <= 9)
    {
        return 0;
    }
    var count = 0;
    while (n > 9)
    {
        n = multi(n);
        count++;
    }
    return count;
}
public static int multi(long n)
{
    var y = 1;
    var str = n.ToString().ToCharArray();
    for (int i = 0; i < str.Length; i++)
    {
        y *= (int)char.GetNumericValue(str[i]);
    }
    return y;
}
