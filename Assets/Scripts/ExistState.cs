using System;
using UnityEngine;

public abstract class ExistState
{
    public abstract void OnGo();

    public virtual ExistState Update()
    {
        double min = -1;
        ExistState next = null;
        foreach (var c in Core.Data.Classes)
        {
            if (c.Day != (int)DateTime.Now.DayOfWeek - 1)
                continue;
            
            TimeSpan t1 = DateTime.Now.TimeOfDay - c.Start.TimeOfDay;
            TimeSpan t2 = DateTime.Now.TimeOfDay - c.End.TimeOfDay;

            if ((t1.TotalMinutes >= 0 && t2.TotalMinutes <= 0))
            {
                return new Exist(c, new InClass());
            }

            if (t1.TotalMinutes < 0)
            {
                var my = -t1.TotalMinutes;

                if (my < 20 && (min < 0 || my < min))
                {
                    min = my;
                    next = new Exist(c, new Before(min));
                }
            }
        }

        if (next != null)
            return next;
        
        return new UnExist();
    }
}

public class Exist : ExistState
{
    private Class target;
    private TimeState timeState;

    public Exist(Class target, TimeState timeState)
    {
        this.target = target;
        this.timeState = timeState;
    }

    public override void OnGo()
    {
        Application.OpenURL(target.URL);
    }

    public override ExistState Update()
    {
        Core.UI.output_class = target.Name;
        timeState.Update();

        return base.Update();
    }
}

public class UnExist : ExistState
{
    public override void OnGo()
    {
    }

    public override ExistState Update()
    {
        Core.UI.output_class = "현재 찾을 수 있는 수업이 없습니다";
        Core.UI.output_remain_time = "";

        return base.Update();
    }
}