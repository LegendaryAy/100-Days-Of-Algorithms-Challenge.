public static int[] ReverseSeq(int n)
{
    int[] arr = new int[n];
    for (int i = n; i > 0; i--)
    {
        arr[n - i] = i;
    }
    return arr;
}
