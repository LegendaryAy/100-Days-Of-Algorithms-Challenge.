public static int NbDig(int n, int d)
{
    var str = "";
    var count = 0;
    var z = d.ToString()[0];
    for (int i = 0; i <= n; i++)
    {
        str = (i * i).ToString();
        for (int j = 0; j < str.Length; j++)
        {
            if (str[j] == z)
                count++;
        }
    }
    return count;
}