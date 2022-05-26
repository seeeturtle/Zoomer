using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public void OnRegister()
    {
        UI._.output_class.text = UI._.input_name.text;
        UI._.output_remain_time.text = UI._.input_time.text;
    }
}
