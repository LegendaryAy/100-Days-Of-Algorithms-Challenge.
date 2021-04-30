public static int solution(int N)
{
    var str = Convert.ToString(N, 2);
    Console.WriteLine(str);
    var count = 0;
    var max = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == '0')
        {
            count++;
            Console.WriteLine(count);
        }
        else
        {
            if (count > max)
            {
                max = count;

            }
            count = 0;
        }
    }
    return max;
}