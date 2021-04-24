public static String revRot(String strng, int sz)
{
    if (sz <= 0 || sz > strng.Length || strng == "")
    {
        return "";
    }
    var length = strng.Length / sz;
    var first = 0;
    var last = sz;
    var result = "";
    for (int i = 0; i < length; i++)
    {
        var sub = strng.Substring(first, last);
        if (checkCube(sub) == true)
        {
            result += reverse(sub);
        }
        else
        {
            result += rotate(sub);
        }
        first += sz;
    }
    return result;
}
public static bool checkCube(string str)
{
    double sum = 0;
    var num = str.ToCharArray();
    foreach (var item in num)
    {
        var x = Char.GetNumericValue(item);
        sum += Math.Pow(x, 3);
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
public static string rotate(string str)
{
    var newArr = str.ToCharArray();
    var newStr = new List<char>();
    for (int i = 1; i < newArr.Length; i++)
    {
        newStr.Add(newArr[i]);
    }
    newStr.Add(newArr[0]);
    return new string(newStr.ToArray());
}
public static string reverse(string str)
{
    var newArr = str.ToCharArray();
    Array.Reverse(newArr);
    return new string(newArr);
}