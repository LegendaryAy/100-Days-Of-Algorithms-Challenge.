public static string Accum(string s)
{
    var w = s.ToLower();
    var st = new StringBuilder();

    for (int i = 0; i < s.Length; i++)
    {
        var x = li(w[i], i);
        var y = x.Substring(0, 1).ToUpper();
        var z = x.Substring(1);
        var q = y + z + "-";
        st.Append(q);
    }
    var a = st.ToString();
    return a.Remove(a.Length - 1);
}
public static string li(char x, int index)
{
    var str = "";
    for (int i = 0; i < index + 1; i++)
    {
        str += x;
    }
    return str;
}