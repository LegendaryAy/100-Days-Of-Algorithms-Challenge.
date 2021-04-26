public static int DontGiveMeFive(int start, int end)
{
    var count = 0;
    for (int i = start; i <= end; i++)
    {
        if (i.ToString().Contains('5'))
        {
            continue;
        }
        count++;
    }
    return count;
}