using System;
using System.Linq;

public class GrassHopper 
{
    public static int FindAverage(int[] nums)
    {
        return nums.Sum() / nums.Length;
    }
}