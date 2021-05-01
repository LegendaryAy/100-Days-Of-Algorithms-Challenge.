public static string HighAndLow(string numbers)
{
    var list = new List<int>();
    var arr = numbers.Split(' ');
    for (int i = 0; i < arr.Length; i++)
    {
        list.Add(Int32.Parse(arr[i]));
    }
    list.Sort();
    var str = $"{list[list.Count - 1]} {list[0]}";
    return str;
}
