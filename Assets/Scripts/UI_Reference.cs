using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI
{
    private UI_Reference _reference;

    public UI(UI_Reference reference)
    {
        _reference = reference;
    }

    public string input_name
    {
        get => _reference.input_name.text;
        set => _reference.input_name.text = value;
    }
    public string input_start_time
    {
        get => _reference.input_start_time.text;
        set => _reference.input_start_time.text = value;
    }
    public string input_end_time
    {
        get => _reference.input_end_time.text;
        set => _reference.input_end_time.text = value;
    }
    public string input_url
    {
        get => _reference.input_url.text;
        set => _reference.input_url.text = value;
    }
    public string output_class
    {
        get => _reference.output_class.text;
        set => _reference.output_class.text = value;
    }
    public string output_remain_time
    {
        get => _reference.output_remain_time.text;
        set => _reference.output_remain_time.text = value;
    }
}

public class UI_Reference : MonoBehaviour
{
    public Text input_name;
    public Text input_start_time;
    public Text input_end_time;
    public Text input_url;

    public Text output_class;
    public Text output_remain_time;
}