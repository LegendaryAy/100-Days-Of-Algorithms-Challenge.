using System;

public class Braking
{

     public static double Dist(double v, double mu)        // suppose reaction time is 1
        {
            return (((v / 3.6) * (v / 3.6)) / (2 * mu * 9.81)) + (v / 3.6);
        }
        public static double Speed(double d, double mu)       // suppose reaction time is 1
        {
            return  (-mu * 9.81 + (Math.Sqrt((mu * mu * 9.81 * 9.81) + (2 * mu * 9.81 * d)))) * 3.6;
            
        }
}
