public static int DuplicateCount(string str)
{
    var myStr = str.ToLower().Distinct();
    var maxCount = 0;
    foreach (var item in myStr)
    {
        var count = 0;
        foreach (var item1 in str.ToLower())
        {
            if (item == item1)
            {
                count += 1;
            }
        }
        if (count > 1)
        {
            maxCount += 1;
        }
    }

    return maxCount;
}