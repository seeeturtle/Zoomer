using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Right
{
    private Class target;

    public string URL => target.URL;
    public string Name => target.Name;
    public bool Exists => target != null;

    public Right()
    {
        target = null;
    }

    public double Calculate()
    {
        double min = -1;
        foreach (var c in Core.Data.Classes)
        {
            TimeSpan t1 = DateTime.Now.TimeOfDay - c.Start.TimeOfDay;
            TimeSpan t2 = DateTime.Now.TimeOfDay - c.End.TimeOfDay;

            if ((t1.TotalMinutes >= 0 && t2.TotalMinutes <= 0))
            {
                target = c;
                break;
            }

            double my;

            if (t1.TotalMinutes < 0)
                my = -t1.TotalMinutes;
            else
                my = t2.TotalMinutes;

            if (my < 20 && (min < 0 || my < min))
            {
                min = my;
                target = c;
            }
        }

        return min;
    }
}
//
// public class FakeRight : Right
// {
//     public new double Calculate()
//     {
//         Debug.Log("calculating");
//         return 1;
//     }
//
//     public new string URL => "https://google.com";
//     public new string Name => "New Class";
//     public new bool Exists => true;
// }
