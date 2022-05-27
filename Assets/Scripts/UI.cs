using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public static UI _;

    public Text input_name;
    public Text input_start_time;
    public Text input_end_time;
    public Text input_url;

    public Text output_class;
    public Text output_remain_time;

    private void Awake()
    {
        _ = this;
    }
}
