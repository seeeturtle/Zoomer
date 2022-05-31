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
        Core.Right.OnGo();

    }
    
    public void Update()
    {
        Core.Right.Update();
    }
}