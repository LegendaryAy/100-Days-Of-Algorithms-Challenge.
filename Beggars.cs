public static int[] Beggars(int[] values, int n)
{
    var result = new int[n];
    for (int i = 0; i < n; i++)
    {
        var sum = 0;
        for (int j = i; j < values.Length; j += n)
        {
            sum += values[j];
        }
        result[i] = sum;
    }
    foreach (var item in result)
    {
        Console.WriteLine(item);
    }

    return result;
}