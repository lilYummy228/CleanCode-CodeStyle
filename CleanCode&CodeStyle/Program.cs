internal class Program
{
    public static int Clamp(int minValue, int value, int maxValue)
    {
        if (minValue < value)
            return value;
        else if (value > maxValue)
            return maxValue;
        else
            return minValue;
    }    
}