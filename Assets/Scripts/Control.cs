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
        Core.UI.output_class = Core.UI.input_name;
        Core.UI.output_remain_time = Core.UI.input_start_time;
    }
}
