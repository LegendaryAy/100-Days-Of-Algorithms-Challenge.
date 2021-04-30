public int[] solution(int[] A, int K)
{
    var B = new int[A.Length];
    for (int i = 0; i < A.Length; i++)
    {
        var j = (i + K) % A.Length;
        B[j] = A[i];
    }
    return B;
}