public static int FindDifference(int[] a, int[] b)
{
    return Math.Abs(getMulti(a) - getMulti(b));
}
public static int getMulti(int[] a)
{
    var multi = 1;
    for (int i = 0; i < a.Length; i++)
    {
        multi *= a[i];
    }
    return multi;
}