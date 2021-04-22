using System.Collections.Generic;
using System.Linq;

public static int GetUnique(IEnumerable<int> numbers)
{
    List<int> a = numbers.ToList();
    a.Sort();
    if (a[0] != a[1])
    {
        return a[0];
    }
    return a[a.Count - 1];
}