using System;

public class Braking
{

    public static double Dist(double v, double mu)        // suppose reaction time is 1
    {
        var speed = v / 3.6;
        var frc = mu;
        var g = 9.81;
        var dis = (speed * speed) / (2 * frc * g);
        var reac = speed;
        var dist = dis + reac;
        return dist;
    }
    public static double Speed(double d, double mu)       // suppose reaction time is 1
    {
        var dist = d;
        var frc = mu;
        var g = 9.81;
        var sqr = Math.Sqrt((frc * frc * g * g) + (2 * frc * g * dist));
        var dis = -frc * g + sqr;
        return (dis * 3.6);
    }
