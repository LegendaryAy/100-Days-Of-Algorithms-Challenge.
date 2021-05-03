public class Tortoise
{
	public static int[] Race(int v1, int v2, int g)
	{
		var time = (g * 3600) / (v2 - v1);
		return v1 < v2 ? new int[] { time / 3600, time % 3600 / 60, time % 60 } : null;
	}
}