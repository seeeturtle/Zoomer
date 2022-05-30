using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private void Awake()
    {
        Core.Load();
    }

    public void OnRegister()
    {
        Core.Data.Save(new Class(
            Core.UI.input_name,
            DateTime.Parse(Core.UI.input_start_time),
            DateTime.Parse(Core.UI.input_end_time),
            Core.UI.input_url,
            Core.UI.input_day));
    }

    public void OnGo()
    {
        if (Core.Right.Exists)
        {
            Application.OpenURL(Core.Right.URL);
        }
    }
    
    public void Update()
    {
        double min = Core.Right.Calculate();

        if (Core.Right.Exists)
        {
            Core.UI.output_class = Core.Right.Name;
            if (min < 0)
            {
                Core.UI.output_remain_time = "지금 수업 중입니다!";
            }
            else
            {
                Core.UI.output_remain_time = min.ToString();
            }
        }
    }
}