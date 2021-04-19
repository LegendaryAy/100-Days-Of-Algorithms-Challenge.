public static int CubeOdd(int[] arr)
{
    var sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        var x = Math.Pow((double)arr[i], 3); ;
        if (x % 2 != 0)
        {
            sum += (int)x;
        }
    }
    return sum;
}