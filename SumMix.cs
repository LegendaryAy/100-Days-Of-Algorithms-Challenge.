public static int SumMix(object[] x)
{

    var sum = 0;
    foreach (var item in x)
    {
        var y = Int32.Parse(item.ToString());
        sum += y;
    }
    return sum;

}