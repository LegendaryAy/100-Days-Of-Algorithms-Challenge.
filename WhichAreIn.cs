public static string[] inArray(string[] array1, string[] array2)
{
    HashSet<string> strArr = new HashSet<string>();
    for (int i = 0; i < array2.Length; i++)
    {
        for (int j = 0; j < array1.Length; j++)
        {
            if (array2[i].Contains(array1[j]))
            {
                strArr.Add(array1[j]);
            }
        }
    }
    var srr = strArr.ToArray();
    Array.Sort(srr);
    return srr;
}