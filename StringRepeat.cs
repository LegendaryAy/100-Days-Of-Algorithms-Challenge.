public static string RepeatStr(int n, string s)
{
    var str = "";
    for (int i = 0; i < n; i++)
    {
        str += s;
    }
    return str;
}